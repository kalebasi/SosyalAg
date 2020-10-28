using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KullanicilarModel
{
    using System;
    using SonucModel;
    using YorumlarModel;
    using ProfilModel;
    using KutuphaneModel;
    using KitapBilgileriModel;

    [Serializable]
    public class Kullanicilar
    {
        public Kullanicilar()
        {

        }
        public int ID { get; set; }
        public string Ad_Soyad { get; set; }
        private string _Email;
        public string E_Mail
        {
            get { return _Email; }
            set
            {
                try
                {
                    value = Guvenlik.Char39Replace(value);
                    if (!string.IsNullOrEmpty(value))
                    {
                        System.Net.Mail.MailAddress m = new System.Net.Mail.MailAddress(value);
                        _Email = value;
                    }
                }
                catch
                {
                    //throw new Exception("Hatalı bir email adresi girdiniz!");
                }
            }
        }
        public string Sifre { get; set; }
        public int OkunanKitapSayisi { get; set; }
        public virtual ResultModel Result { get; set; }
        public virtual Yorumlar yorum { get; set; }
        public virtual Kutuphane kutuphane { get; set; }
        public virtual KitapBilgileri kitapBilgileri { get; set; }
        public virtual Profil profil { get; set; }
        private string _IpAdress;
        public string IpAdress
        {
            get { return _IpAdress; }
            set { _IpAdress = Guvenlik.Char39Replace(value); }
        }
        private string _SessionId;
        public string SessionId {
            get { return _SessionId; }
            set { _SessionId = Guvenlik.Char39Replace(value); }
        }
        public bool Durum { get; set; }
       
    }
}