using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProfilModel
{
    using System;
    using KitapBilgileriModel;
    using KullanicilarModel;
    using YorumlarModel;

    [Serializable]
    public class Profil
    {
        public Profil()
        {

        }
        public int ID { get; set; }
        public int? Kullanici_ID { get; set; }
        public string YasadigiYer { get; set; }
        public string Memleket { get; set; }
        public string DogumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string ProfilResmi { get; set; }
        public string ArkaPlanResmi { get; set; }
        public virtual KitapBilgileri kitapBilgileri { get; set; }
        public virtual Kullanicilar kullanici { get; set; }
        public virtual Yorumlar yorum { get; set; }
    }
}