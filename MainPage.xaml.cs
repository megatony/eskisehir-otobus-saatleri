﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using eskisehir.Resources;
using eskisehir.ViewModels;
using Microsoft.Phone.Tasks;
using System.IO.IsolatedStorage;

namespace eskisehir
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            OylamaDenetleyici(null, null);
            // Set the data context of the LongListSelector control to the sample data
            DataContext = App.ViewModel;

            // Sample code to localize the ApplicationBar
            BuildLocalizedApplicationBar();
        }


        private void OylamaDenetleyici(object sender, LaunchingEventArgs e)
        {
            int AcilisSayisi = 0;
            if (IsolatedStorageSettings.ApplicationSettings.Contains("ProgramAcildi"))
            {
                AcilisSayisi = (int)IsolatedStorageSettings.ApplicationSettings["ProgramAcildi"];
            }
            else
            {
                IsolatedStorageSettings.ApplicationSettings["ProgramAcildi"] = 0;
            }

            AcilisSayisi++;

            IsolatedStorageSettings.ApplicationSettings["ProgramAcildi"] = AcilisSayisi;
            if (AcilisSayisi == 5)
            {
                var returnvalue = MessageBox.Show("merhabalar, uygulamayı kullandığınız için çok teşekkürler. bu bir öğrenci projesi olduğundan olumlu ya da olumsuz her türlü görüşünüzü bana iletirseniz uygulamayı daha iyi bir hale getirebilirim. Şimdiden vakit ayırdığın için teşekkür ederim.", "bir dakikanı alabilir miyim?", MessageBoxButton.OKCancel);
                if (returnvalue == MessageBoxResult.OK)
                {
                    var marketplaceReviewTask = new MarketplaceReviewTask();
                    marketplaceReviewTask.Show();
                }
            }
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        // Handle selection changed on LongListSelector
        private void MainLongListSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // If selected item is null (no selection) do nothing
            if (MainLongListSelector.SelectedItem == null)
                return;

            // Navigate to the new page
            NavigationService.Navigate(new Uri("/DetailsPage.xaml?selectedItem=" + (MainLongListSelector.SelectedItem as ItemViewModel).ID, UriKind.Relative));

            // Reset selected item to null (no selection)
            MainLongListSelector.SelectedItem = null;
        }

         
        private void BuildLocalizedApplicationBar()
        {
            // Set the page's ApplicationBar to a new instance of ApplicationBar.
            ApplicationBar = new ApplicationBar();

            // Create a new button and set the text value to the localized string from AppResources.
            
            // Create a new menu item with the localized string from AppResources.
            ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem("Hakkında");
            ApplicationBar.MenuItems.Add(appBarMenuItem);
            appBarMenuItem.Click += appBarMenuItem_Click;
        }

        void appBarMenuItem_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page1.xaml", UriKind.Relative));

        }
    }
}