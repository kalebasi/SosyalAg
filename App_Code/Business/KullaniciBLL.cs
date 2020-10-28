using KitapBilgileriModel;
using KitaplarModel;
using KullanicilarModel;
using KullaniciModel;
using ProfilModel;
using SonucModel;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Web;
using YorumlarModel;

public class KullaniciBLL
{
    public class Admin
    {
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public static ResultModel OturumAc(string KullaniciAdi, string Parola)
        {
            if (string.IsNullOrEmpty(KullaniciAdi) || string.IsNullOrEmpty(Parola))
            {
                return new ResultModel() { Code = 27, Tanim = "Alınan parametrelerden biri veya birkaçı hatalı." };
            }
            string Ip = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            string SessionId = HttpContext.Current.Session.SessionID;

            BayiYetkili managementResult = KullaniciDAL.Admin.OturumAc(KullaniciAdi, Parola, Ip, SessionId);
            if (managementResult.Result.Code == 56)
            {
                managementResult.IpAdress = Ip;
                managementResult.SessionId = SessionId;
                //if (managementResult.KullaniciTurID == 1)
                //    HttpContext.Current.Session["bayiObject"] = managementResult;
                //else
                HttpContext.Current.Session["bayiObject"] = managementResult;
            }
            else if (managementResult.Result.Code == 23)
            {
                HttpCookie aCookie = null;
                if (HttpContext.Current.Request.Cookies["forgetPassword"] == null)
                {
                    aCookie = new HttpCookie("forgetPassword");
                    NameValueCollection col = new NameValueCollection();
                    aCookie.Values["KullaniciAdi"] = KullaniciAdi;
                    aCookie.Values["Count"] = "1";
                    aCookie.Expires = DateTime.Now.AddHours(1);
                    HttpContext.Current.Response.Cookies.Add(aCookie);
                }
                else
                {
                    aCookie = HttpContext.Current.Request.Cookies["forgetPassword"];

                    if (aCookie.Values["KullaniciAdi"] == KullaniciAdi && aCookie.Values["Count"] == "2")
                    {
                        aCookie = new HttpCookie("forgetPassword");
                        HttpContext.Current.Response.Cookies.Add(aCookie);
                    }
                    else if (aCookie.Values["KullaniciAdi"] == KullaniciAdi && aCookie.Values["Count"] == "1")
                    {
                        aCookie.Values["Count"] = (Convert.ToInt32(aCookie.Values["Count"]) + 1).ToString();
                        HttpContext.Current.Response.Cookies.Add(aCookie);
                    }
                    else if (aCookie.Values["KullaniciAdi"] != KullaniciAdi)
                    {
                        aCookie = new HttpCookie("forgetPassword");
                        NameValueCollection col = new NameValueCollection();
                        aCookie.Values["KullaniciAdi"] = KullaniciAdi;
                        aCookie.Values["Count"] = "1";
                        aCookie.Expires = DateTime.Now.AddHours(1);
                        HttpContext.Current.Response.Cookies.Add(aCookie);
                    }
                }
            }
            else
            {

            }

            return managementResult.Result;
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public static Tuple<ResultModel, int, ICollection<Kitaplar>> KitaplariGetir()
        {
            ResultModel x1 = new ResultModel();

            BayiYetkili kullaniciObject = HttpContext.Current.Session["bayiObject"] as BayiYetkili;

            int x2 = 0;
            try
            {
                return KullaniciDAL.Admin.KitaplariGetir();
            }
            catch (Exception ex)
            {
                x1.Code = 57;
                x1.Tanim = "Hata: " + ex.Message;
            }
            return new Tuple<ResultModel, int, ICollection<Kitaplar>>(x1, x2, new List<Kitaplar>());
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public static Tuple<ResultModel, int, ICollection<KitapBilgileri>> Listele(AramaKriterleri aramaKriterleri)
        {
            ResultModel x1 = new ResultModel();
            try
            {
                BayiYetkili kullaniciModel = HttpContext.Current.Session["bayiObject"] as BayiYetkili;

                if (kullaniciModel == null)
                {
                    x1.Code = 85;
                    x1.Tanim = "Kullanıcı oturumu oluşturulamadı.";
                }
                else
                {
                    return KullaniciDAL.Admin.Listele(aramaKriterleri);
                }
            }
            catch (Exception ex)
            {
                x1.Code = 57;
                x1.Tanim = ex.Message;

            }
            return new Tuple<ResultModel, int, ICollection<KitapBilgileri>>(x1, 0, new List<KitapBilgileri>());
        }

        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public static Tuple<ResultModel> YeniKitapEkle(KitapBilgileri kitapModel)
        {
            ResultModel x = new ResultModel();
            try
            {
                BayiYetkili bayiObject = HttpContext.Current.Session["bayiObject"] as BayiYetkili;

                if (string.IsNullOrEmpty(kitapModel.KitapAdi) || string.IsNullOrEmpty(kitapModel.KitapYazari) || string.IsNullOrEmpty(kitapModel.BasimTarihi) || (kitapModel.SayfaSayisi == null) || string.IsNullOrEmpty(kitapModel.Ulke) || string.IsNullOrEmpty(kitapModel.Dil) || string.IsNullOrEmpty(kitapModel.YayınEvi) || (kitapModel.ISBN == null) || (kitapModel.Kitaplar_ID == null))
                {
                    x.Code = 27;
                    x.Tanim = "Alınan parametrelerden biri veya birkaçı hatalı!!!";
                }
                else if (kitapModel == null)
                {
                    x.Code = 85;
                    x.Tanim = "Kullanıcı oturumu oluşturulamadı.";
                }
                else
                {
                    //Tuple<ResultModel> sonuc = KullaniciDAL.Admin.YeniKitapEkle(kitapModel);
                    return KullaniciDAL.Admin.YeniKitapEkle(kitapModel);
                }
            }
            catch (Exception ex)
            {
                x.Code = 57;
                x.Tanim = ex.Message;
            }
            return new Tuple<ResultModel>(x);
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public static Tuple<ResultModel, KitapBilgileri> KitapBilgileriniGetir(string _KitapID)
        {
            ResultModel x = new ResultModel();
            try
            {
                int KitapID = Convert.ToInt32(_KitapID);
                BayiYetkili bayiObject = HttpContext.Current.Session["bayiObject"] as BayiYetkili;

                if (string.IsNullOrEmpty(KitapID.ToString()))
                {
                    x.Code = 27;
                    x.Tanim = "Alınan parametrelerden biri veya birkaçı hatalı!!!";
                }
                else if (bayiObject == null)
                {
                    x.Code = 85;
                    x.Tanim = "Kullanıcı oturumu oluşturulamadı.";
                }
                else
                {
                    return KullaniciDAL.Admin.KitapBilgileriniGetir(KitapID);
                }
            }
            catch (Exception ex)
            {
                x.Code = 57;
                x.Tanim = ex.Message;
            }

            return new Tuple<ResultModel, KitapBilgileri>(x, new KitapBilgileri());
        }


        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public static ResultModel KitapBilgileriniGuncelle(KitapBilgileri kitapModel)
        {
            ResultModel x = new ResultModel();
            try
            {
                BayiYetkili bayiObject = HttpContext.Current.Session["bayiObject"] as BayiYetkili;

                if (string.IsNullOrEmpty(kitapModel.KitapAdi) || string.IsNullOrEmpty(kitapModel.KitapYazari) || string.IsNullOrEmpty(kitapModel.BasimTarihi) || (kitapModel.SayfaSayisi == null) || string.IsNullOrEmpty(kitapModel.Ulke) || string.IsNullOrEmpty(kitapModel.Dil) || string.IsNullOrEmpty(kitapModel.YayınEvi) || (kitapModel.ISBN == null) || (kitapModel.Kitaplar_ID == null))
                {
                    return new ResultModel() { Code = 27, Tanim = "Alınan parametrelerden biri veya birkaçı hatalı!!!" };
                }
                else if (bayiObject == null)
                {
                    x.Code = 85;
                    x.Tanim = "Kullanıcı oturumu oluşturulamadı.";
                }
                else
                {
                    x = KullaniciDAL.Admin.KitapBilgileriniGuncelle(kitapModel);
                }
            }
            catch (Exception ex)
            {
                x.Code = 57;
                x.Tanim = ex.Message;
            }
            return x;
        }



    }



    /*KULLANICI TARAFLI İŞLEMLER*/
    [DataObjectMethod(DataObjectMethodType.Select, true)]
    public static ResultModel OturumAc(Kullanicilar login)
    {
        if (string.IsNullOrEmpty(login.E_Mail) || string.IsNullOrEmpty(login.Sifre))
        {
            return new ResultModel() { Code = 27, Tanim = "Alınan parametrelerden biri veya birkaçı hatalı." };
        }
        string Ip = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
        string SessionId = HttpContext.Current.Session.SessionID;

        Kullanicilar managementResult = KullaniciDAL.OturumAc(login.E_Mail, login.Sifre, Ip, SessionId);
        if (managementResult.Result.Code == 1)
        {
            managementResult.IpAdress = Ip;
            managementResult.SessionId = SessionId;
            HttpContext.Current.Session["kullaniciObject"] = managementResult;
        }
        else if (managementResult.Result.Code == 0)
        {
            HttpCookie aCookie = null;
            if (HttpContext.Current.Request.Cookies["forgetPassword"] == null)
            {
                aCookie = new HttpCookie("forgetPassword");
                NameValueCollection col = new NameValueCollection();
                aCookie.Values["email"] = login.E_Mail;
                aCookie.Values["Count"] = "1";
                aCookie.Expires = DateTime.Now.AddHours(1);
                HttpContext.Current.Response.Cookies.Add(aCookie);
            }
            else
            {
                aCookie = HttpContext.Current.Request.Cookies["forgetPassword"];

                if (aCookie.Values["email"] == login.E_Mail && aCookie.Values["Count"] == "2")
                {
                    aCookie = new HttpCookie("forgetPassword");
                    HttpContext.Current.Response.Cookies.Add(aCookie);
                }
                else if (aCookie.Values["email"] == login.E_Mail && aCookie.Values["Count"] == "1")
                {
                    aCookie.Values["Count"] = (Convert.ToInt32(aCookie.Values["Count"]) + 1).ToString();
                    HttpContext.Current.Response.Cookies.Add(aCookie);
                }
                else if (aCookie.Values["email"] != login.E_Mail)
                {
                    aCookie = new HttpCookie("forgetPassword");
                    NameValueCollection col = new NameValueCollection();
                    aCookie.Values["email"] = login.E_Mail;
                    aCookie.Values["Count"] = "1";
                    aCookie.Expires = DateTime.Now.AddHours(1);
                    HttpContext.Current.Response.Cookies.Add(aCookie);
                }
            }
        }
        else
        {

        }
        return managementResult.Result;
    }

    [DataObjectMethod(DataObjectMethodType.Insert, true)]
    public static ResultModel UyeKayit(Kullanicilar uyekayit)
    {
        ResultModel x = new ResultModel();
        try
        {
            if (string.IsNullOrEmpty(uyekayit.Ad_Soyad) || string.IsNullOrEmpty(uyekayit.E_Mail) || string.IsNullOrEmpty(uyekayit.Sifre))
            {
                x.Tanim = "Alınan parametrelerden biri veya birkaçı hatalı!!!";
                x.Code = 28;
            }
            else
            {
                return KullaniciDAL.UyeKayit(uyekayit);
            }
        }
        catch (Exception ex)
        {
            x.Code = 57;
            x.Tanim = ex.Message;
        }
        return x;
    }

    [DataObjectMethod(DataObjectMethodType.Select, true)]
    public static Tuple<ResultModel, int, ICollection<KitapBilgileri>> KitapListele(int? KitapTürID)
    {
        ResultModel x1 = new ResultModel();
        try
        {
            return KullaniciDAL.KitapListele(KitapTürID);
        }
        catch (Exception ex)
        {
            x1.Code = 57;
            x1.Tanim = ex.Message;

        }
        return new Tuple<ResultModel, int, ICollection<KitapBilgileri>>(x1, 0, new List<KitapBilgileri>());
    }

    [DataObjectMethod(DataObjectMethodType.Select, true)]
    public static Tuple<ResultModel, int, ICollection<KitapBilgileri>> AnasayfaKitapListele()
    {
        ResultModel x1 = new ResultModel();
        try
        {
            return KullaniciDAL.AnasayfaKitapListele();
        }
        catch (Exception ex)
        {
            x1.Code = 57;
            x1.Tanim = ex.Message;

        }
        return new Tuple<ResultModel, int, ICollection<KitapBilgileri>>(x1, 0, new List<KitapBilgileri>());
    }

    [DataObjectMethod(DataObjectMethodType.Select, true)]
    public static Tuple<ResultModel, int, ICollection<Kullanicilar>> AnasayfaOkuyucuListele()
    {
        ResultModel x1 = new ResultModel();
        try
        {
            return KullaniciDAL.AnasayfaOkuyucuListele();
        }
        catch (Exception ex)
        {
            x1.Code = 57;
            x1.Tanim = ex.Message;

        }
        return new Tuple<ResultModel, int, ICollection<Kullanicilar>>(x1, 0, new List<Kullanicilar>());
    }

    [DataObjectMethod(DataObjectMethodType.Select, true)]
    public static Tuple<ResultModel, int, ICollection<Kitaplar>> KitapTürleriListele()
    {
        ResultModel x1 = new ResultModel();

        try
        {
            return KullaniciDAL.KitapTürleriListele();
        }
        catch (Exception ex)
        {
            x1.Code = 57;
            x1.Tanim = ex.Message;

        }
        return new Tuple<ResultModel, int, ICollection<Kitaplar>>(x1, 0, new List<Kitaplar>());
    }

    [DataObjectMethod(DataObjectMethodType.Select, true)]
    public static Tuple<ResultModel, int, List<KitapBilgileri>, ICollection<Kullanicilar>> KitapBilgileri(int? KitapID)
    {
        ResultModel x1 = new ResultModel();
        try
        {
            Tuple<ResultModel, int, List<KitapBilgileri>, ICollection<Kullanicilar>> result = KullaniciDAL.KitapBilgileri(KitapID);
            return new Tuple<ResultModel, int, List<KitapBilgileri>, ICollection<Kullanicilar>>(result.Item1, result.Item2, result.Item3, result.Item4);

        }
        catch (Exception ex)
        {
            x1.Code = 57;
            x1.Tanim = ex.Message;

        }
        return new Tuple<ResultModel, int, List<KitapBilgileri>, ICollection<Kullanicilar>>(x1, 0, new List<KitapBilgileri>(), new List<Kullanicilar>());
    }

    [DataObjectMethod(DataObjectMethodType.Select, true)]
    public static Tuple<ResultModel, List<KitapBilgileri>, ICollection<Kullanicilar>> KitapBasimBilgileri(int? KitapID)
    {
        ResultModel x1 = new ResultModel();
        try
        {
            Tuple<ResultModel, List<KitapBilgileri>, ICollection<Kullanicilar>> result = KullaniciDAL.KitapBasimBilgileri(KitapID);
            return new Tuple<ResultModel, List<KitapBilgileri>, ICollection<Kullanicilar>>(result.Item1, result.Item2, result.Item3);

        }
        catch (Exception ex)
        {
            x1.Code = 57;
            x1.Tanim = ex.Message;

        }
        return new Tuple<ResultModel, List<KitapBilgileri>, ICollection<Kullanicilar>>(x1,new List<KitapBilgileri>(), new List<Kullanicilar>());
    }

    [DataObjectMethod(DataObjectMethodType.Select, true)]
    public static Tuple<ResultModel, List<Profil>> ProfilBilgileri(int? KullaniciID)
    {
        ResultModel x1 = new ResultModel();

        try
        {
            return KullaniciDAL.ProfilBilgileri(KullaniciID);
        }
        catch (Exception ex)
        {
            x1.Code = 57;
            x1.Tanim = ex.Message;
        }
        return new Tuple<ResultModel, List<Profil>>(x1, new List<Profil>());
    }

    [DataObjectMethod(DataObjectMethodType.Select, true)]
    public static Tuple<ResultModel, int, List<Yorumlar>> ProfilYorumlari(int? KullaniciID)
    {
        ResultModel x1 = new ResultModel();
        try
        {
            return KullaniciDAL.ProfilYorumlari(KullaniciID);

        }
        catch (Exception ex)
        {
            x1.Code = 57;
            x1.Tanim = ex.Message;

        }
        return new Tuple<ResultModel, int, List<Yorumlar>>(x1, 0, new List<Yorumlar>());
    }

    [DataObjectMethod(DataObjectMethodType.Select, true)]
    public static Tuple<ResultModel, int, List<KitapBilgileri>> MenuOkuyacaklarimiGetir(int? KullaniciID)
    {
        ResultModel x1 = new ResultModel();
        try
        {
            return KullaniciDAL.MenuOkuyacaklarimiGetir(KullaniciID);

        }
        catch (Exception ex)
        {
            x1.Code = 57;
            x1.Tanim = ex.Message;

        }
        return new Tuple<ResultModel, int, List<KitapBilgileri>>(x1, 0, new List<KitapBilgileri>());
    }

    [DataObjectMethod(DataObjectMethodType.Select, true)]
    public static Tuple<ResultModel, int, List<KitapBilgileri>> MenuOkumaktaOlduklarimiGetir(int? KullaniciID)
    {
        ResultModel x1 = new ResultModel();
        try
        {
            return KullaniciDAL.MenuOkumaktaOlduklarimiGetir(KullaniciID);

        }
        catch (Exception ex)
        {
            x1.Code = 57;
            x1.Tanim = ex.Message;

        }
        return new Tuple<ResultModel, int, List<KitapBilgileri>>(x1, 0, new List<KitapBilgileri>());
    }

    [DataObjectMethod(DataObjectMethodType.Select, true)]
    public static Tuple<ResultModel, int, List<KitapBilgileri>> MenuOkuduklarimiGetir(int? KullaniciID)
    {
        ResultModel x1 = new ResultModel();
        try
        {
            return KullaniciDAL.MenuOkuduklarimiGetir(KullaniciID);

        }
        catch (Exception ex)
        {
            x1.Code = 57;
            x1.Tanim = ex.Message;

        }
        return new Tuple<ResultModel, int, List<KitapBilgileri>>(x1, 0, new List<KitapBilgileri>());
    }

    [DataObjectMethod(DataObjectMethodType.Select, true)]
    public static Tuple<ResultModel, int, List<KitapBilgileri>> MenuKutuphanemiGetir(int? KullaniciID)
    {
        ResultModel x1 = new ResultModel();
        try
        {
            return KullaniciDAL.MenuKutuphanemiGetir(KullaniciID);

        }
        catch (Exception ex)
        {
            x1.Code = 57;
            x1.Tanim = ex.Message;

        }
        return new Tuple<ResultModel, int, List<KitapBilgileri>>(x1, 0, new List<KitapBilgileri>());
    }

    [DataObjectMethod(DataObjectMethodType.Select, true)]
    public static Tuple<ResultModel, Profil> ProfilBilgilerimiGetirPopUp(int? KullaniciID)
    {
        ResultModel x1 = new ResultModel();
        try
        {
            return KullaniciDAL.ProfilBilgilerimiGetirPopUp(KullaniciID);
        }
        catch (Exception ex)
        {
            x1.Code = 57;
            x1.Tanim = ex.Message;
        }
        return new Tuple<ResultModel, Profil>(x1, new Profil());
    }

    [DataObjectMethod(DataObjectMethodType.Update, true)]
    public static ResultModel ProfilBilgilerimiGuncelle(Profil profilModel)
    {
        ResultModel x = new ResultModel();
        try
        {
            //int len; // "len" isimli integer tip değişken tanımlıyor...
            //len = textBox1.Text.Length;//..textBox1 'in uzunluğuna atıyorum
            //string a;// string olarak "a" değişkeni tanımlıyorum
            //a = textBox1.Text.Substring(0, 1); // substring ile "a" değişkenimi ilk karakter için ayarlıyorum
            //label1.Text = a.ToUpper() + textBox1.Text.Substring(1, len - 1);// ilk karakterim olan "a"değişkenimi " büyük ,diğerlerini küçük yaptırıyorum ve label'a aktarıyorum
            x = KullaniciDAL.ProfilBilgilerimiGuncelle(profilModel);
        }
        catch (Exception ex)
        {
            x.Code = 57;
            x.Tanim = ex.Message;
        }
        return x;
    }

    [DataObjectMethod(DataObjectMethodType.Insert, true)]
    public static ResultModel YeniYorumEkle(Yorumlar yorumModel)
    { /*Yapılan yorum Kontrol edilecek*/
        ResultModel x = new ResultModel();
        try
        {
            if (string.IsNullOrEmpty(yorumModel.Yorum) || (yorumModel.Kullanici_ID == null) || (yorumModel.KitapBilgileri_ID == null))
            {
                x.Tanim = "Hatalı işlem yapıyorsunuz!!!";
            }
            else
            {
                x = KullaniciDAL.YeniYorumEkle(yorumModel);
            }

        }
        catch (Exception ex)
        {
            x.Code = 57;
            x.Tanim = ex.Message;
        }
        return x;
    }

    [DataObjectMethod(DataObjectMethodType.Update, true)]
    public static ResultModel OyBegendim(int? OySayisi,int? KitapID)
    { /*Yapılan yorum Kontrol edilecek*/
        ResultModel x = new ResultModel();
        try
        {
            if (OySayisi==null || OySayisi==0)
            {
                x.Tanim = "Hatalı işlem yapıyorsunuz!!!";
            }
            else
            {
                x = KullaniciDAL.OyBegendim(OySayisi,KitapID);
            }

        }
        catch (Exception ex)
        {
            x.Code = 57;
            x.Tanim = ex.Message;
        }
        return x;
    }

    [DataObjectMethod(DataObjectMethodType.Update, true)]
    public static ResultModel OyBegenmedim(int? OySayisi, int? KitapID)
    { /*Yapılan yorum Kontrol edilecek*/
        ResultModel x = new ResultModel();
        try
        {
            if (OySayisi == null || OySayisi == 0)
            {
                x.Tanim = "Hatalı işlem yapıyorsunuz!!!";
            }
            else
            {
                x = KullaniciDAL.OyBegenmedim(OySayisi, KitapID);
            }

        }
        catch (Exception ex)
        {
            x.Code = 57;
            x.Tanim = ex.Message;
        }
        return x;
    }

    [DataObjectMethod(DataObjectMethodType.Insert, true)]
    public static ResultModel OkumaktaOlduklarimaEkle(int? KitapID, int? KullaniciID)
    { /*Yapılan yorum Kontrol edilecek*/
        ResultModel x = new ResultModel();
        try
        {
            if (KitapID == null || KullaniciID == null)
            {
                x.Tanim = "Hatalı işlem yapıyorsunuz!!!";
            }
            else
            {
                return KullaniciDAL.OkumaktaOlduklarimaEkle(KitapID, KullaniciID);
            }

        }
        catch (Exception ex)
        {
            x.Code = 57;
            x.Tanim = ex.Message;
        }
        return x;
    }

    [DataObjectMethod(DataObjectMethodType.Insert, true)]
    public static ResultModel OkuyacaklarimaEkle(int? KitapID, int? KullaniciID)
    { /*Yapılan yorum Kontrol edilecek*/
        ResultModel x = new ResultModel();
        try
        {
            if (KullaniciID == null || KitapID==null)
            {
                x.Tanim = "Hatalı işlem yapıyorsunuz!!!";
            }
            else
            {
                return KullaniciDAL.OkuyacaklarimaEkle(KitapID,KullaniciID);
            }

        }
        catch (Exception ex)
        {
            x.Code = 57;
            x.Tanim = ex.Message;
        }
        return x;
    }

    [DataObjectMethod(DataObjectMethodType.Insert, true)]
    public static ResultModel OkuduklarimaEkle(int? KitapID, int? KullaniciID)
    { /*Yapılan yorum Kontrol edilecek*/
        ResultModel x = new ResultModel();
        try
        {
            if (KullaniciID == null || KitapID == null)
            {
                x.Tanim = "Hatalı işlem yapıyorsunuz!!!";
            }
            else
            {
                return KullaniciDAL.OkuduklarimaEkle(KitapID, KullaniciID);
            }

        }
        catch (Exception ex)
        {
            x.Code = 57;
            x.Tanim = ex.Message;
        }
        return x;
    }

    [DataObjectMethod(DataObjectMethodType.Insert, true)]
    public static ResultModel KutuphanemeEkle(int? KitapID, int? KullaniciID)
    { /*Yapılan yorum Kontrol edilecek*/
        ResultModel x = new ResultModel();
        try
        {
            if (KullaniciID == null || KitapID == null)
            {
                x.Tanim = "Hatalı işlem yapıyorsunuz!!!";
            }
            else
            {
                return KullaniciDAL.KutuphanemeEkle(KitapID, KullaniciID);
            }

        }
        catch (Exception ex)
        {
            x.Code = 57;
            x.Tanim = ex.Message;
        }
        return x;
    }

    [DataObjectMethod(DataObjectMethodType.Delete, true)]
    public static ResultModel KitapSil(int? KitapID, int? KullaniciID)
    { /*Yapılan yorum Kontrol edilecek*/
        ResultModel x = new ResultModel();
        try
        {
            if (KullaniciID == null || KitapID == null)
            {
                x.Tanim = "Hatalı işlem yapıyorsunuz!!!";
            }
            else
            {
                return KullaniciDAL.KitapSil(KitapID, KullaniciID);
            }

        }
        catch (Exception ex)
        {
            x.Code = 57;
            x.Tanim = ex.Message;
        }
        return x;
    }

    [DataObjectMethod(DataObjectMethodType.Insert, true)]
    public static void ResimKaydet(string resimadi, int? KullaniciID)
    {
        KullaniciDAL.ResimKaydet(resimadi, KullaniciID);
    }
    [DataObjectMethod(DataObjectMethodType.Insert, true)]
    public static void KapakResimKaydet(string resimadi, int? KullaniciID)
    {
        KullaniciDAL.KapakResimKaydet(resimadi, KullaniciID);
    }

    [DataObjectMethod(DataObjectMethodType.Insert, true)]
    public static ResultModel DuvarınaYaz(Yorumlar yorumModel)
    {
        ResultModel x = new ResultModel();
        try
        {
            if (string.IsNullOrEmpty(yorumModel.Yorum) || (yorumModel.Kullanici_ID == null))
            {
                x.Tanim = "Hatalı işlem yapıyorsunuz!!!";
            }
            else
            {
                x = KullaniciDAL.DuvarınaYaz(yorumModel);
            }

        }
        catch (Exception ex)
        {
            x.Code = 57;
            x.Tanim = ex.Message;
        }
        return x;
    }
}