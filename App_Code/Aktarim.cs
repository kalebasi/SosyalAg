using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for Aktarim
/// </summary>
[WebService(Namespace = "http://www.bcssoft.net/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class Aktarim : System.Web.Services.WebService {

    public string ConnString = ConfigurationManager.ConnectionStrings["TahsilatDbConnectionString"].ConnectionString;

   

    [WebMethod]
    public string A_KullanicilariAktar()
    {
        string result = "";

        try
        {
            #region Bayileri Taşı

            StringBuilder insertQuery = new StringBuilder();
            insertQuery.Append("INSERT INTO TahsilatDb.dbo.tblKullanicilar(SirketID, Ad, Soyad, AdSoyad, TcKimlikNo, DogumTarihi, DogumYeri, BabaAdi, EklenmeTarihi, IletisimBilgileri, AnneAdi, Il, Ilce, PortfoyHareketID, AktarimID, KBBSkor, KBBTakipKaydi, YapilandirmaSMS, MusteriTurID, SonGuncellenmeTarihi, VergiNo, PortfoyID, KurumSubeID, DosyaNo, UrunNo, MusteriNo, AnaPara, Faiz, ToplamBorc, TahsilEdilecekBorc, DosyaDurumID, IcraTarihi, IcraDairesi,                        IcraDosyaNo, TaksitlendirmeVarMi, OzelAlan1, OzelAlan2, OzelAlan3, UrunKodu, KampanyaUrunKodu, KampanyaUrunAdi, Limit, Bakiye, TaksitSayisi, OdemesiGecikenTaksitSayisi, OdemeYapilmasiGerekenIlkTaksit, ProblemliGun, FaizGun, VerilenOdemeSozuTutari, VerilenOdemeSozuTarihi, MaxGun, KartEkstreStatusu, KartTuru, ToplamRisk, HesapKesimTarihi, SonOdemeTarihi,    GecikmeGunSayisi, BorcluTipID, DosyaTurID, DosyaSahipID, SistemDurumID, Islendi, DosyaKapanmaTarihi, Atandi, AtanmaTarihi, SonGuncelleyenKullaniciID, Alacakli, AileSiraNo, CiltNo, CuzdanSeriNo,  Cinsiyet, KalanBorc, AnaParaKalan, MasrafBakiyesi, KTVU, TahminiDosyaKapanisTarihi, IbranameDosyaAdi) SELECT SirketID, Ad, Soyad, AdSoyad, TcKimlikNo, DogumTarihi, DogumYeri, BabaAdi, EklenmeTarihi, IletisimBilgileri, AnneAdi, Il, Ilce, PortfoyHareketID, AktarimID, KBBSkor, KBBTakipKaydi, YapilandirmaSMS, MusteriTurID, SonGuncellenmeTarihi, VergiNo, PortfoyID, KurumSubeID, DosyaNo, UrunNo, MusteriNo, AnaPara, Faiz, ToplamBorc, TahsilEdilecekBorc, DosyaDurumID, IcraTarihi, IcraDairesi,                        IcraDosyaNo, TaksitlendirmeVarMi, OzelAlan1, OzelAlan2, OzelAlan3, UrunKodu, KampanyaUrunKodu, KampanyaUrunAdi, Limit, Bakiye, TaksitSayisi, OdemesiGecikenTaksitSayisi, OdemeYapilmasiGerekenIlkTaksit, ProblemliGun, FaizGun, VerilenOdemeSozuTutari, VerilenOdemeSozuTarihi, MaxGun, KartEkstreStatusu, KartTuru, ToplamRisk, HesapKesimTarihi, SonOdemeTarihi,    GecikmeGunSayisi, BorcluTipID, DosyaTurID, DosyaSahipID, SistemDurumID, Islendi, DosyaKapanmaTarihi, Atandi, AtanmaTarihi, SonGuncelleyenKullaniciID, Alacakli, AileSiraNo, CiltNo, CuzdanSeriNo,  Cinsiyet, KalanBorc, AnaParaKalan, MasrafBakiyesi, KTVU, TahminiDosyaKapanisTarihi, IbranameDosyaAdi from KapanDb.dbo.tblKullanicilar ");

            string sorgu = insertQuery.ToString();
            sorgu += "";
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(sorgu, con))
                {
                    cmd.CommandTimeout = (60 * 60) * 60;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    int queryResult = cmd.ExecuteNonQuery();

                    result = "Toplam " + queryResult + " bayi sisteme kayıt edildi.";
                }
            }

            #endregion
        }
        catch (Exception ex)
        {
            result = ex.Message;
        }

        return result;
    }

    [WebMethod]
    public string B_BayiYetkilileriniAktar()
    {
        string result = "";

        try
        {
            #region Bayileri Taşı

            StringBuilder insertQuery = new StringBuilder();
            insertQuery.Append("SET IDENTITY_INSERT asistanSQL.dbo.tblBayiYetkili ON INSERT INTO asistanSQL.dbo.tblBayiYetkili(ID, BayiKodu, AdSoyad, Gsm, Email, KullaniciAdi, Parola, AktifMi, BayiGoruntuleme, BayiEkleme, BayiDuzenleme, YetkiliGoruntuleme, YetkiliEkleme, YetkiliDuzenleme, MusteriListesi, MusteriGoruntuleme, MusteriEkleme, MusteriDuzenleme, MusteriDestek, GonderimRaporOzet, GonderimRaporDetay, SistemLoglari, ExcelAktarim, KomisyonHesaplari, KomisyonRaporlari, HesapEkstresi, Aktivasyon) SELECT ID, BayiKodu, AdSoyad, Gsm, Email, KullaniciAdi, Parola, AktifMi, BayiGoruntuleme, BayiEkleme, BayiDuzenleme, YetkiliGoruntuleme, YetkiliEkleme, YetkiliDuzenleme, MusteriListesi, MusteriGoruntuleme, MusteriEkleme, MusteriDuzenleme, MusteriDestek, GonderimRaporOzet, GonderimRaporDetay, SistemLoglari, ExcelAktarim, KomisyonHesaplari, KomisyonRaporlari, HesapEkstresi, Aktivasyon from asistanSQLSunucu.dbo.tblBayiYetkili ");

            string sorgu = insertQuery.ToString();
            sorgu += " SET IDENTITY_INSERT asistanSQL.dbo.tblBayiYetkili OFF ";
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(sorgu, con))
                {
                    cmd.CommandTimeout = (60 * 60) * 60;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    int queryResult = cmd.ExecuteNonQuery();

                    result = "Toplam " + queryResult + " bayi yetkilisi sisteme kayıt edildi.";
                }
            }

            #endregion
        }
        catch (Exception ex)
        {
            result = ex.Message;
        }

        return result;
    }

    [WebMethod]
    public string C_PopupAktar()
    {
        string result = "";

        try
        {
            #region Bayileri Taşı

            StringBuilder insertQuery = new StringBuilder();
            insertQuery.Append("SET IDENTITY_INSERT asistanSQL.dbo.tblPopup ON INSERT INTO asistanSQL.dbo.tblPopup(ID, ResimAdi, Sayfa, URL, Link, Cookie, Durum) SELECT ID, ResimAdi, Sayfa, URL, Link, Cookie, Durum from asistanSQLSunucu.dbo.tblPopup ");

            string sorgu = insertQuery.ToString();
            sorgu += " SET IDENTITY_INSERT asistanSQL.dbo.tblPopup OFF ";
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(sorgu, con))
                {
                    cmd.CommandTimeout = (60 * 60) * 60;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    int queryResult = cmd.ExecuteNonQuery();

                    result = "Toplam " + queryResult + " popup sisteme kayıt edildi.";
                }
            }

            #endregion
        }
        catch (Exception ex)
        {
            result = ex.Message;
        }

        return result;
    }

    [WebMethod]
    public string D_KullanıcıAktar()
    {
        string result = "";

        try
        {
            #region Bayileri Taşı

            StringBuilder insertQuery = new StringBuilder();
            insertQuery.Append("SET IDENTITY_INSERT asistanSQL.dbo.tblKullanicilar ON INSERT INTO asistanSQL.dbo.tblKullanicilar(ID, UstKullaniciID, BayiKodu, Unvan, AdiSoyadi, Gsm, Email, Adres, DogumTarihi, VergiDairesi, VergiNo, KullaniciAdi, Parola, AktifMi, SabitNo) SELECT ID, UstKullaniciID, BayiKodu, Unvan, AdiSoyadi, Gsm, Email, Adres, DogumTarihi, VergiDairesi, VergiNo, KullaniciAdi, Parola, AktifMi, SabitNo from asistanSQLSunucu.dbo.tblKullanicilar ");

            string sorgu = insertQuery.ToString();
            sorgu += " SET IDENTITY_INSERT asistanSQL.dbo.tblKullanicilar OFF ";
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(sorgu, con))
                {
                    cmd.CommandTimeout = (60 * 60) * 60;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    int queryResult = cmd.ExecuteNonQuery();

                    result = "Toplam " + queryResult + " kullanıcı kayıt edildi.";
                }
            }

            #endregion
        }
        catch (Exception ex)
        {
            result = ex.Message;
        }

        return result;
    }

    [WebMethod]
    public string E_YetkilendirmeAktar()
    {
        string result = "";

        try
        {
            #region Bayileri Taşı

            StringBuilder insertQuery = new StringBuilder();
            insertQuery.Append("SET IDENTITY_INSERT asistanSQL.dbo.tblYetkilendirme ON INSERT INTO asistanSQL.dbo.tblYetkilendirme(ID, KullaniciID, KayitGoruntuleme, KayitEkleme, KayitDuzenleme, KayitSilme, GrupGoruntuleme, GrupEkleme, GrupDuzenleme, GrupSilme, GruplarArasiTransfer, SMS, AylikSmsKredi, TC, AylikTcKredi, GonderimOnay, SMSRaporOzet, SMSRaporDetay, SMSRaporPaketIptal, TCRaporOzet, TCRaporDetay, TCRaporPaketIptal, Transfer, Ayarlar) SELECT ID, KullaniciID, KayitGoruntuleme, KayitEkleme, KayitDuzenleme, KayitSilme, GrupGoruntuleme, GrupEkleme, GrupDuzenleme, GrupSilme, GruplarArasiTransfer, SMS, AylikSmsKredi, TC, AylikTcKredi, GonderimOnay, SMSRaporOzet, SMSRaporDetay, SMSRaporPaketIptal, TCRaporOzet, TCRaporDetay, TCRaporPaketIptal, Transfer, Ayarlar from asistanSQLSunucu.dbo.tblYetkilendirme ");

            string sorgu = insertQuery.ToString();
            sorgu += " SET IDENTITY_INSERT asistanSQL.dbo.tblYetkilendirme OFF ";
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(sorgu, con))
                {
                    cmd.CommandTimeout = (60 * 60) * 60;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    int queryResult = cmd.ExecuteNonQuery();

                    result = "Toplam " + queryResult + " kullanıcı yetkilendirmesi kayıt edildi.";
                }
            }

            #endregion
        }
        catch (Exception ex)
        {
            result = ex.Message;
        }

        return result;
    }

    [WebMethod]
    public string F_SablonlariAktar()
    {
        string result = "";

        try
        {
            #region Bayileri Taşı

            StringBuilder insertQuery = new StringBuilder();
            insertQuery.Append("SET IDENTITY_INSERT asistanSQL.dbo.tblSablonlar ON INSERT INTO asistanSQL.dbo.tblSablonlar(ID, KullaniciID, SablonAdi, SablonIcerik) SELECT ID, KullaniciID, SablonAdi, SablonIcerik from asistanSQLSunucu.dbo.tblSablonlar ");

            string sorgu = insertQuery.ToString();
            sorgu += " SET IDENTITY_INSERT asistanSQL.dbo.tblSablonlar OFF ";
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(sorgu, con))
                {
                    cmd.CommandTimeout = (60 * 60) * 60;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    int queryResult = cmd.ExecuteNonQuery();

                    result = "Toplam " + queryResult + " Şablon kayıt edildi.";
                }
            }

            #endregion
        }
        catch (Exception ex)
        {
            result = ex.Message;
        }

        return result;
    }

    [WebMethod]
    public string G_KullaniciHesaplariniAktar()
    {
        //operatorID Güncelle 4-2
        string result = "";

        try
        {
            #region Bayileri Taşı

            StringBuilder insertQuery = new StringBuilder();
            insertQuery.Append("UPDATE asistanSQLSunucu.dbo.tblKullaniciHesaplari SET OperatorID=2 WHERE OperatorID=4 SET IDENTITY_INSERT asistanSQL.dbo.tblKullaniciHesaplari ON INSERT INTO asistanSQL.dbo.tblKullaniciHesaplari(ID, OperatorID, KullaniciID, HesapAdi, KullaniciAdi, Sifre, MusteriKodu, SanalNo, KurumsalNo, HesapTuru, SMSYetki, TCKSMSYetki, TRSMSYetki, EklenmeTarihi, GuncellenmeTarihi, Durum) SELECT ID, OperatorID, KullaniciID, HesapAdi, KullaniciAdi, Sifre, MusteriKodu, SanalNo, KurumsalNo, HesapTuru,SMSYetki, TCKSMSYetki, TRSMSYetki, EklenmeTarihi, GuncellenmeTarihi, Durum from asistanSQLSunucu.dbo.tblKullaniciHesaplari ");

            string sorgu = insertQuery.ToString();
            sorgu += " SET IDENTITY_INSERT asistanSQL.dbo.tblKullaniciHesaplari OFF ";
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(sorgu, con))
                {
                    cmd.CommandTimeout = (60 * 60) * 60;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    int queryResult = cmd.ExecuteNonQuery();

                    result = "Toplam " + queryResult + " Kullanıcı Hesabı kayıt edildi.";
                }
            }

            #endregion
        }
        catch (Exception ex)
        {
            result = ex.Message;
        }

        return result;
    }

    [WebMethod]
    public string H_MesajlariAktar()
    {
       
        string result = "";

        try
        {
            #region Bayileri Taşı

            StringBuilder insertQuery = new StringBuilder();
            insertQuery.Append("SET IDENTITY_INSERT asistanSQL.dbo.tblMesajlar ON INSERT INTO asistanSQL.dbo.tblMesajlar(ID, Kimden, Kime, Baslik, MesajIcerik, Tarih, OkunduMu, AlanSildiMi, GonderenSildiMi) SELECT ID, Kimden, Kime, Baslik, MesajIcerik, Tarih, OkunduMu, AlanSildiMi, GonderenSildiMi from asistanSQLSunucu.dbo.tblMesajlar ");

            string sorgu = insertQuery.ToString();
            sorgu += " SET IDENTITY_INSERT asistanSQL.dbo.tblMesajlar OFF ";
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(sorgu, con))
                {
                    cmd.CommandTimeout = (60 * 60) * 60;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    int queryResult = cmd.ExecuteNonQuery();

                    result = "Toplam " + queryResult + " Kullanıcı Hesabı kayıt edildi.";
                }
            }

            #endregion
        }
        catch (Exception ex)
        {
            result = ex.Message;
        }

        return result;
    }

    [WebMethod]
    public string I_KisileriAktar()
    {

        string result = "";

        try
        {
            #region Bayileri Taşı

            StringBuilder insertQuery = new StringBuilder();
            insertQuery.Append("SET IDENTITY_INSERT asistanSQL.dbo.tblKisiler ON INSERT INTO asistanSQL.dbo.tblKisiler(ID, KullaniciID, Gsm1, Gsm2, Gsm3, TCKimlikNo, Ad, Soyad, Adres, EvTel, IsTel, Faks, Email, Cinsiyet, DogumTarihi, EvlilikTarihi, FirmaAdi, Gorevi, KaralistedeMi,KaralisteSebebi, KaralisteTarihi) SELECT ID, KullaniciID, Gsm1, Gsm2, Gsm3, TCKimlikNo, Ad, Soyad, Adres, EvTel, IsTel, Faks, Email, Cinsiyet, DogumTarihi, EvlilikTarihi, FirmaAdi, Gorevi, KaralistedeMi,KaralisteSebebi, KaralisteTarihi from asistanSQLSunucu.dbo.tblKisiler");

            string sorgu = insertQuery.ToString();
            sorgu += " SET IDENTITY_INSERT asistanSQL.dbo.tblKisiler OFF ";
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(sorgu, con))
                {
                    cmd.CommandTimeout = (60 * 60) * 60;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    int queryResult = cmd.ExecuteNonQuery();

                    result = "Toplam " + queryResult + " Kişi kayıt edildi.";
                }
            }

            #endregion
        }
        catch (Exception ex)
        {
            result = ex.Message;
        }

        return result;
    }

    [WebMethod]
    public string J_GruplariAktar()
    {

        string result = "";

        try
        {
            #region Bayileri Taşı

            StringBuilder insertQuery = new StringBuilder();
            insertQuery.Append("SET IDENTITY_INSERT asistanSQL.dbo.tblGruplar ON INSERT INTO asistanSQL.dbo.tblGruplar(ID, KullaniciID, AnaGrupID, GrupAdi) SELECT ID, KullaniciID, AnaGrupID, GrupAdi from asistanSQLSunucu.dbo.tblGruplar");

            string sorgu = insertQuery.ToString();
            sorgu += " SET IDENTITY_INSERT asistanSQL.dbo.tblGruplar OFF ";
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(sorgu, con))
                {
                    cmd.CommandTimeout = (60 * 60) * 60;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    int queryResult = cmd.ExecuteNonQuery();

                    result = "Toplam " + queryResult + " grup kayıt edildi.";
                }
            }

            #endregion
        }
        catch (Exception ex)
        {
            result = ex.Message;
        }

        return result;
    }

    [WebMethod]
    public string K_GrupKisileriAktar()
    {

        string result = "";

        try
        {
            #region Bayileri Taşı

            StringBuilder insertQuery = new StringBuilder();
            insertQuery.Append(" INSERT INTO asistanSQL.dbo.tblGrupKisi(KisiID, GrupID) SELECT KisiID, GrupID from asistanSQLSunucu.dbo.tblGrupKisi");

            string sorgu = insertQuery.ToString();
        
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(sorgu, con))
                {
                    cmd.CommandTimeout = (60 * 60) * 60;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    int queryResult = cmd.ExecuteNonQuery();

                    result = "Toplam " + queryResult + " grup kişisi kayıt edildi.";
                }
            }

            #endregion
        }
        catch (Exception ex)
        {
            result = ex.Message;
        }

        return result;
    }

    [WebMethod]
    public string M_OzelAlanlariAktar()
    {

        string result = "";

        try
        {
            #region Bayileri Taşı

            StringBuilder insertQuery = new StringBuilder();
            insertQuery.Append("SET IDENTITY_INSERT asistanSQL.dbo.tblOzelAlanlar ON INSERT INTO asistanSQL.dbo.tblOzelAlanlar(ID, KullaniciID, AlanAdi, Tip) SELECT ID, KullaniciID, AlanAdi, Tip from asistanSQLSunucu.dbo.tblOzelAlanlar");

            string sorgu = insertQuery.ToString();
            sorgu += " SET IDENTITY_INSERT asistanSQL.dbo.tblOzelAlanlar OFF ";
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(sorgu, con))
                {
                    cmd.CommandTimeout = (60 * 60) * 60;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    int queryResult = cmd.ExecuteNonQuery();

                    result = "Toplam " + queryResult + " özel alan kayıt edildi.";
                }
            }

            #endregion
        }
        catch (Exception ex)
        {
            result = ex.Message;
        }

        return result;
    }

    [WebMethod]
    public string N_OzelAlanKisileriAktar()
    {

        string result = "";

        try
        {
            #region Bayileri Taşı

            StringBuilder insertQuery = new StringBuilder();
            insertQuery.Append("SET IDENTITY_INSERT asistanSQL.dbo.tblOzelAlanKisi ON INSERT INTO asistanSQL.dbo.tblOzelAlanKisi(ID, KisiID, OzelAlanID, Deger) SELECT ID, KisiID, OzelAlanID, Deger from asistanSQLSunucu.dbo.tblOzelAlanKisi");

            string sorgu = insertQuery.ToString();
            sorgu += " SET IDENTITY_INSERT asistanSQL.dbo.tblOzelAlanKisi OFF ";
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(sorgu, con))
                {
                    cmd.CommandTimeout = (60 * 60) * 60;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    int queryResult = cmd.ExecuteNonQuery();

                    result = "Toplam " + queryResult + " özel alan kişi kayıt edildi.";
                }
            }

            #endregion
        }
        catch (Exception ex)
        {
            result = ex.Message;
        }

        return result;
    }

    [WebMethod]
    public string O_AlfanumerikAktar()
    {

        string result = "";

        try
        {
            #region Bayileri Taşı

            StringBuilder insertQuery = new StringBuilder();
            insertQuery.Append("DELETE FROM asistanSQLSunucu.dbo.tblAlfanumerik WHERE ServisID=6 SET IDENTITY_INSERT asistanSQL.dbo.tblAlfanumerik ON INSERT INTO asistanSQL.dbo.tblAlfanumerik(ID, KullaniciHesapID, ServisID, GatewayAlfanumerikID, AlfanumerikAdi, SiraNo, EklenmeTarihi) SELECT ID, KullaniciHesapID, ServisID, GatewayAlfanumerikID, AlfanumerikAdi, SiraNo, EklenmeTarihi from asistanSQLSunucu.dbo.tblAlfanumerik");

            string sorgu = insertQuery.ToString();
            sorgu += " SET IDENTITY_INSERT asistanSQL.dbo.tblAlfanumerik OFF ";
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(sorgu, con))
                {
                    cmd.CommandTimeout = (60 * 60) * 60;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    int queryResult = cmd.ExecuteNonQuery();

                    result = "Toplam " + queryResult + " Alfanumerik kayıt edildi.";
                }
            }

            #endregion
        }
        catch (Exception ex)
        {
            result = ex.Message;
        }

        return result;
    }

    [WebMethod]
    public string P_AltKullaniciHesaplariAktar()
    {

        string result = "";

        try
        {
            #region Bayileri Taşı

            StringBuilder insertQuery = new StringBuilder();
            insertQuery.Append("SET IDENTITY_INSERT asistanSQL.dbo.tblAltKullaniciHesaplari ON INSERT INTO asistanSQL.dbo.tblAltKullaniciHesaplari(ID, KullaniciID, KullaniciHesapID) SELECT ID, KullaniciID, KullaniciHesapID from asistanSQLSunucu.dbo.tblAltKullaniciHesaplari");

            string sorgu = insertQuery.ToString();
            sorgu += " SET IDENTITY_INSERT asistanSQL.dbo.tblAltKullaniciHesaplari OFF ";
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(sorgu, con))
                {
                    cmd.CommandTimeout = (60 * 60) * 60;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    int queryResult = cmd.ExecuteNonQuery();

                    result = "Toplam " + queryResult + " Alt Kullanıcı Hesabı kayıt edildi.";
                }
            }

            #endregion
        }
        catch (Exception ex)
        {
            result = ex.Message;
        }

        return result;
    }

    [WebMethod]
    public string R_AltKullaniciAlfanumerikleriAktar()
    {

        string result = "";

        try
        {
            #region Bayileri Taşı

            StringBuilder insertQuery = new StringBuilder();
            insertQuery.Append("INSERT INTO asistanSQL.dbo.tblAltKullaniciAlfanumerik(AltKullaniciHesapID, AlfanumerikID) SELECT AltKullaniciHesapID, AlfanumerikID from asistanSQLSunucu.dbo.tblAltKullaniciAlfanumerik");

            string sorgu = insertQuery.ToString();
 
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(sorgu, con))
                {
                    cmd.CommandTimeout = (60 * 60) * 60;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    int queryResult = cmd.ExecuteNonQuery();

                    result = "Toplam " + queryResult + " Alt Kullanıcı Alfanumerik kayıt edildi.";
                }
            }

            #endregion
        }
        catch (Exception ex)
        {
            result = ex.Message;
        }

        return result;
    }

    [WebMethod]
    public string S_AltKullaniciGrupAktar()
    {

        string result = "";

        try
        {
            #region Bayileri Taşı

            StringBuilder insertQuery = new StringBuilder();
            insertQuery.Append("INSERT INTO asistanSQL.dbo.tblAltKullaniciGrup(KullaniciID, GrupID) SELECT KullaniciID, GrupID from asistanSQLSunucu.dbo.tblAltKullaniciGrup");

            string sorgu = insertQuery.ToString();

            using (SqlConnection con = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(sorgu, con))
                {
                    cmd.CommandTimeout = (60 * 60) * 60;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    int queryResult = cmd.ExecuteNonQuery();

                    result = "Toplam " + queryResult + " Alt Kullanıcı Grup kayıt edildi.";
                }
            }

            #endregion
        }
        catch (Exception ex)
        {
            result = ex.Message;
        }

        return result;
    }

    [WebMethod]
    public string T_OtomatikSmsGonderimAktar()
    {

        string result = "";

        try
        {
            #region Bayileri Taşı

            StringBuilder insertQuery = new StringBuilder();
            insertQuery.Append("SET IDENTITY_INSERT asistanSQL.dbo.tblOtomatikSmsGonderim ON INSERT INTO asistanSQL.dbo.tblOtomatikSmsGonderim(ID, KullaniciID, AlfanumerikID, GonderimAdi, GonderimKolonu, GonderimGrubu, GonderimTipi, MesajMetni, ParametreVarMi, Ay, Gun, Hafta, Saat, SonIslemTarihi, Durum, IsUTF8Allowed) SELECT ID, KullaniciID, AlfanumerikID, GonderimAdi, GonderimKolonu, GonderimGrubu, GonderimTipi, MesajMetni, ParametreVarMi, Ay, Gun, Hafta, Saat, SonIslemTarihi, Durum, IsUTF8Allowed from asistanSQLSunucu.dbo.tblOtomatikSmsGonderim");

            string sorgu = insertQuery.ToString();
            sorgu += " SET IDENTITY_INSERT asistanSQL.dbo.tblOtomatikSmsGonderim OFF ";
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(sorgu, con))
                {
                    cmd.CommandTimeout = (60 * 60) * 60;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    int queryResult = cmd.ExecuteNonQuery();

                    result = "Toplam " + queryResult + " Otomatik Sms Gönderim kayıt edildi.";
                }
            }

            #endregion
        }
        catch (Exception ex)
        {
            result = ex.Message;
        }

        return result;
    }

    [WebMethod]
    public string U_SmsPaketleriAktar()
    {

        string result = "";

        try
        {
            #region Bayileri Taşı

            StringBuilder insertQuery = new StringBuilder();
            insertQuery.Append("SET IDENTITY_INSERT asistanSQL.dbo.tblSmsPaketleri ON INSERT INTO asistanSQL.dbo.tblSmsPaketleri(ID, KullaniciHesapID, KullaniciID, AlfanumerikID, AlfanumerikAdi, Iletilen, Iletilmeyen, Beklemede, Toplam, Ucretlendirilen, MesajMetni, IsUTF8Allowed,Groups, ParametreVarMi, IslemTarihi, IletimBaslangicTarihi, IletimBitisTarihi, GecerlilikSuresi, IleriTarihliMi, GonderimTarihi, PaketDurum, PaketAdi, Aciklama,ApiKey, KanalId) SELECT ID, KullaniciHesapID, KullaniciID, AlfanumerikID, AlfanumerikAdi, Iletilen, Iletilmeyen, Beklemede, Toplam, Ucretlendirilen, MesajMetni, IsUTF8Allowed, Groups, ParametreVarMi, IslemTarihi, IletimBaslangicTarihi, IletimBitisTarihi, GecerlilikSuresi, IleriTarihliMi, GonderimTarihi, PaketDurum, PaketAdi, Aciklama, ApiKey,KanalId from asistanSQLSunucu.dbo.tblSmsPaketleri");

            string sorgu = insertQuery.ToString();
            sorgu += " SET IDENTITY_INSERT asistanSQL.dbo.tblSmsPaketleri OFF ";
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(sorgu, con))
                {
                    cmd.CommandTimeout = (60 * 60) * 60;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    int queryResult = cmd.ExecuteNonQuery();

                    result = "Toplam " + queryResult + " Sms Paketi kayıt edildi.";
                }
            }

            #endregion
        }
        catch (Exception ex)
        {
            result = ex.Message;
        }

        return result;
    }

    [WebMethod]
    public string V_SmsPaketDetaylarileriAktar()
    {

        string result = "";

        try
        {
            #region Bayileri Taşı

            StringBuilder insertQuery = new StringBuilder();
            insertQuery.Append("SET IDENTITY_INSERT asistanSQL.dbo.tblSmsPaketDetay ON INSERT INTO asistanSQL.dbo.tblSmsPaketDetay(ID, PaketID, GsmNo, Boyut, Parametre, Durum, Aciklama, TransactionID, RaporDonusTarihi) SELECT ID, PaketID, GsmNo, Boyut, Parametre, Durum, Aciklama, TransactionID, RaporDonusTarihi from asistanSQLSunucu.dbo.tblSmsPaketDetay");

            string sorgu = insertQuery.ToString();
            sorgu += " SET IDENTITY_INSERT asistanSQL.dbo.tblSmsPaketDetay OFF ";
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(sorgu, con))
                {
                    cmd.CommandTimeout = (60 * 60) * 60;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    int queryResult = cmd.ExecuteNonQuery();

                    result = "Toplam " + queryResult + " Sms Paketi kayıt edildi.";
                }
            }

            #endregion
        }
        catch (Exception ex)
        {
            result = ex.Message;
        }

        return result;
    }

    [WebMethod]
    public string Y_SmsOlaylariniAktar()
    {

        string result = "";

        try
        {
            #region Bayileri Taşı

            StringBuilder insertQuery = new StringBuilder();
            insertQuery.Append("DELETE FROM asistanSQLSunucu.dbo.tblSmsOlaylari WHERE Tur=1  SET IDENTITY_INSERT asistanSQL.dbo.tblSmsOlaylari ON INSERT INTO asistanSQL.dbo.tblSmsOlaylari(ID, PaketID, Tur, IleriTarihliMi, GonderilecekIleriTarih, SonRaporTarihi, RaporSorgulamaSayisi, Durum) SELECT ID, PaketID, Tur, IleriTarihliMi, GonderilecekIleriTarih, SonRaporTarihi, RaporSorgulamaSayisi, Durum from asistanSQLSunucu.dbo.tblSmsOlaylari");

            string sorgu = insertQuery.ToString();
            sorgu += " SET IDENTITY_INSERT asistanSQL.dbo.tblSmsOlaylari OFF ";
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(sorgu, con))
                {
                    cmd.CommandTimeout = (60 * 60) * 60;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    int queryResult = cmd.ExecuteNonQuery();

                    result = "Toplam " + queryResult + " Sms Olayı kayıt edildi.";
                }
            }

            #endregion
        }
        catch (Exception ex)
        {
            result = ex.Message;
        }

        return result;
    }

    [WebMethod]
    public string X_TckSmsPaketleriniAktar()
    {

        string result = "";

        try
        {
            #region Bayileri Taşı

            StringBuilder insertQuery = new StringBuilder();
            insertQuery.Append("SET IDENTITY_INSERT asistanSQL.dbo.tblTCKSmsPaketleri ON INSERT INTO asistanSQL.dbo.tblTCKSmsPaketleri( ID, KullaniciHesapID, KullaniciID, AlfanumerikID, AlfanumerikAdi, Iletilen, Iletilmeyen, Beklemede, Toplam, Ucretlendirilen, MesajMetni, IsUTF8Allowed, ParametreVarMi, IslemTarihi, IletimBaslangicTarihi, IletimBitisTarihi, GecerlilikSuresi, IleriTarihliMi, GonderimTarihi, PaketDurum, PaketAdi, Aciklama, ApiKey) SELECT  ID, KullaniciHesapID, KullaniciID, AlfanumerikID, AlfanumerikAdi, Iletilen, Iletilmeyen, Beklemede, Toplam, Ucretlendirilen, MesajMetni, IsUTF8Allowed,ParametreVarMi, IslemTarihi, IletimBaslangicTarihi, IletimBitisTarihi, GecerlilikSuresi, IleriTarihliMi, GonderimTarihi, PaketDurum, PaketAdi, Aciklama, ApiKey from asistanSQLSunucu.dbo.tblTCKSmsPaketleri");

            string sorgu = insertQuery.ToString();
            sorgu += " SET IDENTITY_INSERT asistanSQL.dbo.tblTCKSmsPaketleri OFF ";
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(sorgu, con))
                {
                    cmd.CommandTimeout = (60 * 60) * 60;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    int queryResult = cmd.ExecuteNonQuery();

                    result = "Toplam " + queryResult + " Tck Sms Paketi kayıt edildi.";
                }
            }

            #endregion
        }
        catch (Exception ex)
        {
            result = ex.Message;
        }

        return result;
    }

    [WebMethod]
    public string ZA_TCKSmsPaketDetayAktar()
    {
        string result = "";

        try
        {
            #region Bayileri Taşı

            StringBuilder insertQuery = new StringBuilder();
            insertQuery.Append("SET IDENTITY_INSERT asistanSQL.dbo.tblTCKSmsPaketDetay ON INSERT INTO asistanSQL.dbo.tblTCKSmsPaketDetay(ID, PaketID, TCNo, Boyut, Parametre, Durum, Aciklama, TransactionID, RaporDonusTarihi) SELECT ID, PaketID, TCNo, Boyut, Parametre, Durum, Aciklama, TransactionID, RaporDonusTarihi from asistanSQLSunucu.dbo.tblTCKSmsPaketDetay");

            string sorgu = insertQuery.ToString();
            sorgu += " SET IDENTITY_INSERT asistanSQL.dbo.tblTCKSmsPaketDetay OFF ";
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(sorgu, con))
                {
                    cmd.CommandTimeout = (60 * 60) * 60;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    int queryResult = cmd.ExecuteNonQuery();

                    result = "Toplam " + queryResult + " Tck Sms Paket detay kayıt edildi.";
                }
            }

            #endregion
        }
        catch (Exception ex)
        {
            result = ex.Message;
        }

        return result;
    }

    [WebMethod]
    public string ZB_SmsGonderimGruplariAktar()
    {
        string result = "";

        try
        {
            #region Bayileri Taşı

            StringBuilder insertQuery = new StringBuilder();
            insertQuery.Append("SET IDENTITY_INSERT asistanSQL.dbo.tblSmsGonderimGruplari ON INSERT INTO asistanSQL.dbo.tblSmsGonderimGruplari(ID, PaketID, GrupAdi) SELECT ID, PaketID, GrupAdi from asistanSQLSunucu.dbo.tblSmsGonderimGruplari");

            string sorgu = insertQuery.ToString();
            sorgu += " SET IDENTITY_INSERT asistanSQL.dbo.tblSmsGonderimGruplari OFF ";
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(sorgu, con))
                {
                    cmd.CommandTimeout = (60 * 60) * 60;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    int queryResult = cmd.ExecuteNonQuery();

                    result = "Toplam " + queryResult + " Sms Gönderim Grubu kayıt edildi.";
                }
            }

            #endregion
        }
        catch (Exception ex)
        {
            result = ex.Message;
        }

        return result;
    }

    [WebMethod]
    public string ZC_TCKSmsOlaylariAktar()
    {
        string result = "";

        try
        {
            #region Bayileri Taşı

            StringBuilder insertQuery = new StringBuilder();
            insertQuery.Append("SET IDENTITY_INSERT asistanSQL.dbo.tblTCKSmsOlaylari ON INSERT INTO asistanSQL.dbo.tblTCKSmsOlaylari(ID, PaketID, GrupAdi) SELECT ID, PaketID, GrupAdi from asistanSQLSunucu.dbo.tblTCKSmsOlaylari");

            string sorgu = insertQuery.ToString();
            sorgu += " SET IDENTITY_INSERT asistanSQL.dbo.tblTCKSmsOlaylari OFF ";
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(sorgu, con))
                {
                    cmd.CommandTimeout = (60 * 60) * 60;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    int queryResult = cmd.ExecuteNonQuery();

                    result = "Toplam " + queryResult + " Tck Sms Olayları kayıt edildi.";
                }
            }

            #endregion
        }
        catch (Exception ex)
        {
            result = ex.Message;
        }

        return result;
    }

    [WebMethod]
    public string ZD_TCKSmsOlaylariAktar()
    {
        string result = "";

        try
        {
            #region Bayileri Taşı

            StringBuilder insertQuery = new StringBuilder();
            insertQuery.Append("DELETE FROM asistanSQLSunucu.dbo.tblTCKSmsOlaylari WHERE Tur=1  SET IDENTITY_INSERT asistanSQL.dbo.tblTCKSmsOlaylari ON INSERT INTO asistanSQL.dbo.tblTCKSmsOlaylari(ID, PaketID, GrupAdi) SELECT ID, PaketID, GrupAdi from asistanSQLSunucu.dbo.tblTCKSmsOlaylari");

            string sorgu = insertQuery.ToString();
            sorgu += " SET IDENTITY_INSERT asistanSQL.dbo.tblTCKSmsOlaylari OFF ";
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(sorgu, con))
                {
                    cmd.CommandTimeout = (60 * 60) * 60;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    int queryResult = cmd.ExecuteNonQuery();

                    result = "Toplam " + queryResult + " Tck Sms Olayları kayıt edildi.";
                }
            }

            #endregion
        }
        catch (Exception ex)
        {
            result = ex.Message;
        }

        return result;
    }

    [WebMethod]
    public string ZE_IslemTipleriAktar()
    {
        string result = "";

        try
        {
            #region Bayileri Taşı

            StringBuilder insertQuery = new StringBuilder();
            insertQuery.Append("INSERT INTO asistanSQL.dbo.tblIslemTipleri(Id, IslemTipi) SELECT  Id, IslemTipi from asistanSQLSunucu.dbo.tblIslemTipleri");

            string sorgu = insertQuery.ToString();
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(sorgu, con))
                {
                    cmd.CommandTimeout = (60 * 60) * 60;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    int queryResult = cmd.ExecuteNonQuery();

                    result = "Toplam " + queryResult + " Kredi kayıt edildi.";
                }
            }

            #endregion
        }
        catch (Exception ex)
        {
            result = ex.Message;
        }

        return result;
    }

    [WebMethod]
    public string ZF_KrediTurleriAktar()
    {
        string result = "";

        try
        {
            #region Bayileri Taşı

            StringBuilder insertQuery = new StringBuilder();
            insertQuery.Append("INSERT INTO asistanSQL.dbo.tblKrediTurleri(ID, KrediTuru) SELECT ID, KrediTuru from asistanSQLSunucu.dbo.tblKrediTurleri");

            string sorgu = insertQuery.ToString();
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(sorgu, con))
                {
                    cmd.CommandTimeout = (60 * 60) * 60;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    int queryResult = cmd.ExecuteNonQuery();

                    result = "Toplam " + queryResult + " Kredi Turu kayıt edildi.";
                }
            }

            #endregion
        }
        catch (Exception ex)
        {
            result = ex.Message;
        }

        return result;
    }

    [WebMethod]
    public string ZG_KredileriAktar()
    {
        string result = "";

        try
        {
            #region Bayileri Taşı

            StringBuilder insertQuery = new StringBuilder();
            insertQuery.Append("SET IDENTITY_INSERT asistanSQL.dbo.tblKrediler ON INSERT INTO asistanSQL.dbo.tblKrediler(Id, KHesapId, Kredi, KrediTurId, IslemTipi, KullaniciId, KrediSkt, Aciklama, BayiId) SELECT  Id, KHesapId, Kredi, KrediTurId, IslemTipi, KullaniciId, KrediSkt, Aciklama, BayiId from asistanSQLSunucu.dbo.tblKrediler");

            string sorgu = insertQuery.ToString();
            sorgu += " SET IDENTITY_INSERT asistanSQL.dbo.tblKrediler OFF ";
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(sorgu, con))
                {
                    cmd.CommandTimeout = (60 * 60) * 60;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    int queryResult = cmd.ExecuteNonQuery();

                    result = "Toplam " + queryResult + " Kredi kayıt edildi.";
                }
            }

            #endregion
        }
        catch (Exception ex)
        {
            result = ex.Message;
        }

        return result;
    }

    [WebMethod]
    public string ZH_KrediLoglariAktar()
    {
        string result = "";

        try
        {
            #region Bayileri Taşı

            StringBuilder insertQuery = new StringBuilder();
            insertQuery.Append("SET IDENTITY_INSERT asistanSQL.dbo.tblKrediLoglari ON INSERT INTO asistanSQL.dbo.tblKrediLoglari(ID, KullaniciID, KHesapId, IP, IslemTarihi, KrediTurId, Kredi, IslemTipId, Aciklama, PaketId) SELECT ID, KullaniciID, KHesapId, IP, IslemTarihi, KrediTurId, Kredi, IslemTipId, Aciklama, PaketId from asistanSQLSunucu.dbo.tblKrediLoglari");

            string sorgu = insertQuery.ToString();
            sorgu += " SET IDENTITY_INSERT asistanSQL.dbo.tblKrediLoglari OFF ";
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(sorgu, con))
                {
                    cmd.CommandTimeout = (60 * 60) * 60;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    int queryResult = cmd.ExecuteNonQuery();

                    result = "Toplam " + queryResult + " Kredi Log'u kayıt edildi.";
                }
            }

            #endregion
        }
        catch (Exception ex)
        {
            result = ex.Message;
        }

        return result;
    }

    [WebMethod]
    public string ZJ_KanallariAktar()
    {
        string result = "";

        try
        {
            #region Bayileri Taşı

            StringBuilder insertQuery = new StringBuilder();
            insertQuery.Append("INSERT INTO asistanSQL.dbo.tblKanallar(KanalAdi, Kodu, KullaniciAdi, Sifre, Gorunur, RaporlamaUrl, ManySenderUrl, MultiSenderUrl, KrediSorgulamaUrl, Aktif) SELECT KanalAdi, Kodu, KullaniciAdi, Sifre, Gorunur, RaporlamaUrl, ManySenderUrl, MultiSenderUrl, KrediSorgulamaUrl, Aktif from asistanSQLSunucu.dbo.tblKanallar");

            string sorgu = insertQuery.ToString();
          
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(sorgu, con))
                {
                    cmd.CommandTimeout = (60 * 60) * 60;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    int queryResult = cmd.ExecuteNonQuery();

                    result = "Toplam " + queryResult + " kanal kayıt edildi.";
                }
            }

            #endregion
        }
        catch (Exception ex)
        {
            result = ex.Message;
        }

        return result;
    }
    [WebMethod]
    public string ZK_TekilGonderimSayisiAktar()
    {
        string result = "";

        try
        {
            #region Bayileri Taşı

            StringBuilder insertQuery = new StringBuilder();
            insertQuery.Append("SET IDENTITY_INSERT asistanSQL.dbo.tblMaksimumTekliSmsSayisi ON  INSERT INTO asistanSQL.dbo.tblMaksimumTekliSmsSayisi(Id, DkMaksimumTekliSmsSayisi) SELECT Id, DkMaksimumTekliSmsSayisi from asistanSQLSunucu.dbo.tblMaksimumTekliSmsSayisi");

            string sorgu = insertQuery.ToString();
            sorgu += " SET IDENTITY_INSERT asistanSQL.dbo.tblMaksimumTekliSmsSayisi OFF ";
            using (SqlConnection con = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(sorgu, con))
                {
                    cmd.CommandTimeout = (60 * 60) * 60;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    int queryResult = cmd.ExecuteNonQuery();

                    result = "Toplam " + queryResult + " kayıt edildi.";
                }
            }

            #endregion
        }
        catch (Exception ex)
        {
            result = ex.Message;
        }

        return result;
    }

}
