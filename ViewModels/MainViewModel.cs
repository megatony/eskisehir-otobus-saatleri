using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using eskisehir.Resources;

namespace eskisehir.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            this.Items = new ObservableCollection<ItemViewModel>();
        }

        /// <summary>
        /// A collection for ItemViewModel objects.
        /// </summary>
        public ObservableCollection<ItemViewModel> Items { get; private set; }

        private string _sampleProperty = "Sample Runtime Property Value";
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding
        /// </summary>
        /// <returns></returns>
        public string SampleProperty
        {
            get
            {
                return _sampleProperty;
            }
            set
            {
                if (value != _sampleProperty)
                {
                    _sampleProperty = value;
                    NotifyPropertyChanged("SampleProperty");
                }
            }
        }

        /// <summary>
        /// Sample property that returns a localized string
        /// </summary>
        public string LocalizedSampleProperty
        {
            get
            {
                return AppResources.SampleProperty;
            }
        }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        /// <summary>
        /// Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        public void LoadData()
        {
            this.Items.Add(new ItemViewModel() { ID = "0", LineOne = "1 (Siyah)", LineTwo = "Çankaya - Odunpazarı" });
            this.Items.Add(new ItemViewModel() { ID = "1", LineOne = "2 (Siyah)", LineTwo = "Yeşiltepe - Tıp Fakültesi" });
            this.Items.Add(new ItemViewModel() { ID = "2", LineOne = "2 (Mavi)", LineTwo = "Yeşiltepe - Sönmezkent" });
            this.Items.Add(new ItemViewModel() { ID = "3", LineOne = "3 (Siyah)", LineTwo = "Ertuğrulgazi - S.S.K. " });
            this.Items.Add(new ItemViewModel() { ID = "4", LineOne = "3 (Mavi)", LineTwo = "Ertuğrulgazi - Tıp - Mimarlık" });
            this.Items.Add(new ItemViewModel() { ID = "5", LineOne = "4 (Kırmızı)", LineTwo = "Yıldız - A.Ü.Iki Eylül Kampüsü" });
            this.Items.Add(new ItemViewModel() { ID = "6", LineOne = "4 (Siyah)", LineTwo = "Tunalı - 61 Evler" });
            this.Items.Add(new ItemViewModel() { ID = "7", LineOne = "5 (Siyah)", LineTwo = "Zincirli Kuyu - S.S.K" });
            this.Items.Add(new ItemViewModel() { ID = "8", LineOne = "6 (Siyah)", LineTwo = "Organize Sanayi - Odunpazarı" });
            this.Items.Add(new ItemViewModel() { ID = "9", LineOne = "8 (Mavi)", LineTwo = "Sakintepe - Devlet Hastanesi" });
            this.Items.Add(new ItemViewModel() { ID = "10", LineOne = "8 (Siyah)", LineTwo = "Esentepe - Tıp Fakültesi" });
            this.Items.Add(new ItemViewModel() { ID = "11", LineOne = "9 (Siyah)", LineTwo = "Terminal - Sümer Mah." });
            this.Items.Add(new ItemViewModel() { ID = "12", LineOne = "10 (Siyah)", LineTwo = "Ihlamurkent - Terminal" });
            this.Items.Add(new ItemViewModel() { ID = "13", LineOne = "10 (Mavi)", LineTwo = "V.Şehir Personel Konutları - İki Eylül Kamp." });
            this.Items.Add(new ItemViewModel() { ID = "14", LineOne = "11 (Kırmızı)", LineTwo = "Karacasehir - Odunpazarı" });
            this.Items.Add(new ItemViewModel() { ID = "15", LineOne = "11 (Siyah)", LineTwo = "Orhangazi & Ömür Mah. - Odunpazarı" });
            this.Items.Add(new ItemViewModel() { ID = "16", LineOne = "12 (Siyah)-33 ", LineTwo = "Fevzi Çakmak Mah. - Devlet Hastanesi" });
            this.Items.Add(new ItemViewModel() { ID = "17", LineOne = "12 (Mavi)", LineTwo = "Fevzi Çakmak Mah. - Tıp Fakültesi" });
            this.Items.Add(new ItemViewModel() { ID = "18", LineOne = "13 (Siyah)", LineTwo = "Tıp Fakültesi - Terminal" });
            this.Items.Add(new ItemViewModel() { ID = "19", LineOne = "14 (Siyah)", LineTwo = "Gündoğdu Mah. - Tıp Fak." });
            this.Items.Add(new ItemViewModel() { ID = "20", LineOne = "15 (Siyah)", LineTwo = "Emek Mah. - Devlet Hastanesi" });
            this.Items.Add(new ItemViewModel() { ID = "21", LineOne = "16 (Kırmızı)", LineTwo = "Çamlıca Mah. - Odunpazarı" });
            this.Items.Add(new ItemViewModel() { ID = "22", LineOne = "16 (Siyah)", LineTwo = "Çamlıca Mah. - Odunpazarı" });
            this.Items.Add(new ItemViewModel() { ID = "23", LineOne = "17 (Siyah)", LineTwo = "Sazova Mah. - Odunpazarı" });
            this.Items.Add(new ItemViewModel() { ID = "24", LineOne = "17 (Kırmızı)", LineTwo = "Ömür Mah. - S.S.K." });
            this.Items.Add(new ItemViewModel() { ID = "25", LineOne = "17 (Mavi)", LineTwo = "Sazova / Elmalı - Odunpazarı" });
            this.Items.Add(new ItemViewModel() { ID = "26", LineOne = "18 (Siyah)", LineTwo = "Terminal - Tıp Fakültesi" });
            this.Items.Add(new ItemViewModel() { ID = "27", LineOne = "18 (Kırmızı)", LineTwo = "Terminal - Üniversite Evleri" });
            this.Items.Add(new ItemViewModel() { ID = "28", LineOne = "19 (Siyah)", LineTwo = "Şirintepe Mah. - Tıp Fakültesi " });
            this.Items.Add(new ItemViewModel() { ID = "29", LineOne = "20 (Siyah)", LineTwo = "Fevzi Çakmak (Kuyubaşı) - Odunpazarı" });
            this.Items.Add(new ItemViewModel() { ID = "30", LineOne = "23 (Siyah)", LineTwo = "Tıp Fakültesi - Batıkent" });
            this.Items.Add(new ItemViewModel() { ID = "31", LineOne = "24 (Siyah)", LineTwo = "Mamuca - Tıp Fakültesi" });
            this.Items.Add(new ItemViewModel() { ID = "32", LineOne = "24 (Kırmızı)", LineTwo = "Ölçe Sitesi - Eski Otogar" });
            this.Items.Add(new ItemViewModel() { ID = "33", LineOne = "25 (Siyah)", LineTwo = "71 Evler - Diş Hastanesi" });
            this.Items.Add(new ItemViewModel() { ID = "34", LineOne = "27 (Siyah)", LineTwo = "Tren Garı - Tıp Fakültesi" });
            this.Items.Add(new ItemViewModel() { ID = "35", LineOne = "29 (Siyah)", LineTwo = "Uluönder Mah. - Terminal" });
            this.Items.Add(new ItemViewModel() { ID = "36", LineOne = "30 (Siyah)", LineTwo = "Terminal - Yenikent" });
            this.Items.Add(new ItemViewModel() { ID = "37", LineOne = "31 (Siyah)", LineTwo = "Karabayır Bağlari - Odunpazarı" });
            this.Items.Add(new ItemViewModel() { ID = "38", LineOne = "32 (Siyah)", LineTwo = "Ihlamurkent  - Akademi" });
            this.Items.Add(new ItemViewModel() { ID = "39", LineOne = "34-59 (Siyah)", LineTwo = "Muttalip - Tıp Fakültesi" });
            this.Items.Add(new ItemViewModel() { ID = "40", LineOne = "35 (Siyah)", LineTwo = "Şirintepe - Odunpazarı" });
            this.Items.Add(new ItemViewModel() { ID = "41", LineOne = "36 (Siyah)", LineTwo = "Tıp Fakültesi - Keskin Köyü" });
            this.Items.Add(new ItemViewModel() { ID = "42", LineOne = "37 (Siyah)", LineTwo = "Ihlamurkent - Metal İş Bloklari" });
            this.Items.Add(new ItemViewModel() { ID = "43", LineOne = "38 (Siyah)", LineTwo = "S.S.K. - Çamlıca Mahallesi" });
            this.Items.Add(new ItemViewModel() { ID = "44", LineOne = "39 (Siyah)", LineTwo = "Erenköy - Tepebasi" });
            this.Items.Add(new ItemViewModel() { ID = "45", LineOne = "43 (Siyah)", LineTwo = "71 Evler - Tıp Fakültesi" });
            this.Items.Add(new ItemViewModel() { ID = "46", LineOne = "44 (Kırmızı)", LineTwo = "Sultandere - Tıp Fakültesi" });
            this.Items.Add(new ItemViewModel() { ID = "47", LineOne = "44 (Siyah)", LineTwo = "Sultandere - Yıldız" });
            this.Items.Add(new ItemViewModel() { ID = "48", LineOne = "48 (Siyah)", LineTwo = "Emek Mah. - Yıldız" });
            this.Items.Add(new ItemViewModel() { ID = "49", LineOne = "50 (Siyah)", LineTwo = "Satılmışoğlu Mh. - Bademlik" });
            this.Items.Add(new ItemViewModel() { ID = "50", LineOne = "51 (Siyah)", LineTwo = "S.S.K. Hastanesi - Terminal" });
            this.Items.Add(new ItemViewModel() { ID = "51", LineOne = "54 (Siyah)", LineTwo = "Tıp Fakültesi - Batıkent" });
            this.Items.Add(new ItemViewModel() { ID = "52", LineOne = "57 (Siyah)", LineTwo = "Devlet Hastanesi - Karapınar Mah." });
            this.Items.Add(new ItemViewModel() { ID = "53", LineOne = "56 (Siyah)", LineTwo = "Yenikent - 2 Eylül Kamp." });
            this.Items.Add(new ItemViewModel() { ID = "54", LineOne = "58 (Siyah)", LineTwo = "Çukurhisar - Bademlik" });
            this.Items.Add(new ItemViewModel() { ID = "55", LineOne = "60 (Siyah)", LineTwo = "Odunpazarı - H Tipi Ceza Evi" });
            this.Items.Add(new ItemViewModel() { ID = "56", LineOne = "63 (Siyah)", LineTwo = "Ihlamurkent - Sıraevler" });
            this.Items.Add(new ItemViewModel() { ID = "57", LineOne = "63 (Kırmızı)", LineTwo = "Ihlamurkent - Iki Eylül Kamp." });
            this.Items.Add(new ItemViewModel() { ID = "58", LineOne = "64 (Siyah)", LineTwo = "Atlı Spor Kulübü - Şehir Hattı" });
            this.Items.Add(new ItemViewModel() { ID = "59", LineOne = "74 (Siyah)", LineTwo = "SSK - TOKİ" });
            this.Items.Add(new ItemViewModel() { ID = "60", LineOne = "78 (Siyah)", LineTwo = "TOKİ - SSK" });

            this.IsDataLoaded = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}