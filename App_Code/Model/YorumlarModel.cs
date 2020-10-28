using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YorumlarModel
{
    using System;
    using KitapBilgileriModel;
    using KullanicilarModel;
    using ProfilModel;

    [Serializable]
    public class Yorumlar
    {
        public Yorumlar()
        {

        }
        public int ID { get; set; }
        public int? Kullanici_ID { get; set; }
        public int? KitapBilgileri_ID { get; set; }
        public string Yorum { get; set; }
        public virtual KitapBilgileri kitapBilgileri { get; set; }
        public virtual Kullanicilar kullanici { get; set; }
        public virtual Profil profil { get; set; }
    }
}