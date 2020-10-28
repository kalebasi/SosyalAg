using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KitapBilgileriModel
{
    using KitaplarModel;
    using System;
    [Serializable]
    public class KitapBilgileri
    {
        public KitapBilgileri()
        {

        }
        public int? ID { get; set; }
        public int? Kitaplar_ID { get; set; }
        public string KitapAdi { get; set; }
        public string KitapYazari { get; set; }
        public string KitapResmi { get; set; }
        public string BasimTarihi { get; set; }
        public int? SayfaSayisi { get; set; }
        public string ISBN { get; set; }
        public string Dil { get; set; }
        public string Ulke { get; set; }
        public string YayınEvi { get; set; }
        public string KitapHakkinda { get; set; }
        public int? BegenenKisiSayisi { get; set; }
        public virtual Kitaplar kitaplar { get; set; }
        public bool? Durum { get; set; }
    }

    [Serializable]
    public class AramaKriterleri
    {
        public Nullable<int> sayfa { get; set; }
        public Nullable<int> sayfaBasiKayitSayisi { get; set; }
        public int? KitapTürID { get; set; }
        private string _aranacakKelime;
        public string aranacakKelime
        {
            get { return _aranacakKelime; }
            set
            { _aranacakKelime = Guvenlik.Char39Replace(value); }
        }
        public bool? Durum { get; set; }
    }
}