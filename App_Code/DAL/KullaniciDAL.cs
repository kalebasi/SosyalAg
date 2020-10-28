using KitapBilgileriModel;
using KitaplarModel;
using KullanicilarModel;
using KullaniciModel;
using ProfilModel;
using SonucModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using YorumlarModel;

/// <summary>
/// Summary Tanim for MusteriDAL
/// </summary>
public class KullaniciDAL
{
    private static Kullanicilar LoadDataRecordKullanici(IDataRecord dr)
    {
        Kullanicilar x = new Kullanicilar();
        try
        {
            if (dr["ID"] != DBNull.Value)
            {
                x.ID = (int)dr["ID"];
            }
        }
        catch
        { }
        try
        {
            if (dr["Ad_Soyad"] != DBNull.Value)
            {
                x.Ad_Soyad = (string)dr["Ad_Soyad"];
            }
        }
        catch
        { }
        try
        {
            if (dr["E_Mail"] != DBNull.Value)
            {
                x.E_Mail = (string)dr["E_Mail"];
            }
        }
        catch
        {
        }

        try
        {
            if (dr["Sifre"] != DBNull.Value)
            {
                x.Sifre = (string)dr["Sifre"];
            }
        }
        catch
        { }
        return x;
    }
    public static KitapBilgileri LoadDataRecordKitaplar(IDataRecord dr)
    { //GİTTİĞİM PROCEDUREDE İSTENİLEN KAYIT BİLGİLERİ HANGİLERİ İSE BURADA KULLANILIR VE STORE PROCEDUREDEN ÇEKİLİR.
        KitapBilgileri x = new KitapBilgileri();

        try
        {
            if (dr["ID"] != DBNull.Value)
            {
                x.ID = (int)dr["ID"];
            }
        }
        catch
        { }
        try
        {
            if (dr["Kitaplar_ID"] != DBNull.Value)
            {
                x.Kitaplar_ID = (int)dr["Kitaplar_ID"];
            }
        }
        catch
        { }
        try
        {
            if (dr["KitapAdi"] != DBNull.Value)
            {
                x.KitapAdi = (string)dr["KitapAdi"];
            }
        }
        catch
        { }
        try
        {
            if (dr["KitapYazari"] != DBNull.Value)
            {
                x.KitapYazari = (string)dr["KitapYazari"];
            }
        }
        catch
        { }
        try
        {
            if (dr["KitapResmi"] != DBNull.Value)
            {
                x.KitapResmi = (string)dr["KitapResmi"];
            }
        }
        catch
        { }

        return x;
    }
    public static Kitaplar LoadDataRecordKitapTürleri(IDataRecord dr)
    {
        Kitaplar x = new Kitaplar();

        try
        {
            if (dr["ID"] != DBNull.Value)
            {
                x.ID = (int)dr["ID"];
            }
        }
        catch
        { }
        try
        {
            if (dr["KitapTürü"] != DBNull.Value)
            {
                x.KitapTürü = (string)dr["KitapTürü"];
            }
        }
        catch
        { }

        return x;
    }
    public static KitapBilgileri LoadDataRecordKitapBilgileri(IDataRecord dr)
    {
        KitapBilgileri kb = new KitapBilgileri();
        kb.kitaplar = new Kitaplar();
        try
        {
            if (dr["ID"] != DBNull.Value)
            {
                kb.ID = (int)dr["ID"];
            }
        }
        catch
        { }
        try
        {
            if (dr["KitapAdi"] != DBNull.Value)
            {
                kb.KitapAdi = (string)dr["KitapAdi"];
            }
        }
        catch
        { }
        try
        {
            if (dr["KitapYazari"] != DBNull.Value)
            {
                kb.KitapYazari = (string)dr["KitapYazari"];
            }
        }
        catch
        { }
        try
        {
            if (dr["KitapResmi"] != DBNull.Value)
            {
                kb.KitapResmi = (string)dr["KitapResmi"];
            }
        }
        catch
        { }

        try
        {
            if (dr["KitapTürü"] != DBNull.Value)
            {
                kb.kitaplar.KitapTürü = (string)dr["KitapTürü"];
            }
        }
        catch
        { }
        try
        {
            if (dr["BasimTarihi"] != DBNull.Value)
            {
                kb.BasimTarihi = (string)dr["BasimTarihi"];
            }
        }
        catch
        { }
        try
        {
            if (dr["ISBN"] != DBNull.Value)
            {
                kb.ISBN = (string)dr["ISBN"];
            }
        }
        catch
        { }
        try
        {
            if (dr["Dil"] != DBNull.Value)
            {
                kb.Dil = (string)dr["Dil"];
            }
        }
        catch
        { }
        try
        {
            if (dr["SayfaSayisi"] != DBNull.Value)
            {
                kb.SayfaSayisi = (int)dr["SayfaSayisi"];
            }
        }
        catch
        { }
        try
        {
            if (dr["YayinEvi"] != DBNull.Value)
            {
                kb.YayınEvi = (string)dr["YayinEvi"];
            }
        }
        catch
        { }
        try
        {
            if (dr["KitapHakkinda"] != DBNull.Value)
            {
                kb.KitapHakkinda = (string)dr["KitapHakkinda"];
            }
        }
        catch
        { }
        try
        {
            if (dr["Ulke"] != DBNull.Value)
            {
                kb.Ulke = (string)dr["Ulke"];
            }
        }
        catch
        { }
        try
        {
            if (dr["BegenenKisiSayisi"] != DBNull.Value)
            {
                kb.BegenenKisiSayisi = (int)dr["BegenenKisiSayisi"];
            }
        }
        catch
        { }

        return kb;
    }
    public static Kullanicilar LoadDataRecordKullaniciYorumlari(IDataRecord dr)
    {
        Kullanicilar k = new Kullanicilar();
        k.profil = new Profil();
        k.yorum = new Yorumlar();
        try
        {
            if (dr["ID"] != DBNull.Value)
            {
                k.ID = (int)dr["ID"];
            }
        }
        catch
        { }
        try
        {
            if (dr["Ad_Soyad"] != DBNull.Value)
            {
                k.Ad_Soyad = (string)dr["Ad_Soyad"];
            }
        }
        catch
        { }
        try
        {
            if (dr["Yorum"] != DBNull.Value)
            {
                k.yorum.Yorum = (string)dr["Yorum"];
            }
        }
        catch
        { }
        try
        {
            if (dr["ProfilResmi"] != DBNull.Value)
            {
                k.profil.ProfilResmi = (string)dr["ProfilResmi"];
            }
        }
        catch
        { }
        try
        {
            if (dr["OkunanKitapSayisi"] != DBNull.Value)
            {
                k.OkunanKitapSayisi = (int)dr["OkunanKitapSayisi"];
            }
        }
        catch
        { }

        return k;
    }
    public static Profil LoadDataRecordProfilBilgileri(IDataRecord dr)
    {
        Profil p = new Profil();
        p.kullanici = new Kullanicilar();
        try
        {
            if (dr["Kullanici_ID"] != DBNull.Value)
            {
                p.Kullanici_ID = (int)dr["Kullanici_ID"];
            }
        }
        catch
        { }
        try
        {
            if (dr["Ad_Soyad"] != DBNull.Value)
            {
                p.kullanici.Ad_Soyad = (string)dr["Ad_Soyad"];
            }
        }
        catch
        { }
        try
        {
            if (dr["YasadigiYer"] != DBNull.Value)
            {
                p.YasadigiYer = (string)dr["YasadigiYer"];
            }
        }
        catch
        { }
        try
        {
            if (dr["Memleket"] != DBNull.Value)
            {
                p.Memleket = (string)dr["Memleket"];
            }
        }
        catch
        { }
        try
        {
            if (dr["DogumTarihi"] != DBNull.Value)
            {
                p.DogumTarihi = (string)dr["DogumTarihi"];
            }
        }
        catch
        { }
        try
        {
            if (dr["Cinsiyet"] != DBNull.Value)
            {
                p.Cinsiyet = (string)dr["Cinsiyet"];
            }
        }
        catch
        { }
        try
        {
            if (dr["ProfilResmi"] != DBNull.Value)
            {
                p.ProfilResmi = (string)dr["ProfilResmi"];
            }
        }
        catch
        { }
        try
        {
            if (dr["ArkaplanResmi"] != DBNull.Value)
            {
                p.ArkaPlanResmi = (string)dr["ArkaplanResmi"];
            }
        }
        catch
        { }

        return p;
    }
    public static Yorumlar LoadDataRecordProfilYorumlari(IDataRecord dr)
    {
        Yorumlar y = new Yorumlar();
        y.profil = new Profil();
        y.kullanici = new Kullanicilar();
        y.kitapBilgileri = new KitapBilgileri();
        try
        {
            if (dr["ID"] != DBNull.Value)
            {
                y.kitapBilgileri.ID = (int)dr["ID"];
            }
        }
        catch
        { }
        try
        {
            if (dr["Ad_Soyad"] != DBNull.Value)
            {
                y.kullanici.Ad_Soyad = (string)dr["Ad_Soyad"];
            }
        }
        catch
        { }
        try
        {
            if (dr["Yorum"] != DBNull.Value)
            {
                y.Yorum = (string)dr["Yorum"];
            }
        }
        catch
        { }
        try
        {
            if (dr["KitapAdi"] != DBNull.Value)
            {
                y.kitapBilgileri.KitapAdi = (string)dr["KitapAdi"];
            }
        }
        catch
        { }
        try
        {
            if (dr["KitapYazari"] != DBNull.Value)
            {
                y.kitapBilgileri.KitapYazari = (string)dr["KitapYazari"];
            }
        }
        catch
        { }
        try
        {
            if (dr["KitapResmi"] != DBNull.Value)
            {
                y.kitapBilgileri.KitapResmi = (string)dr["KitapResmi"];
            }
        }
        catch
        { }
        try
        {
            if (dr["ProfilResmi"] != DBNull.Value)
            {
                y.profil.ProfilResmi = (string)dr["ProfilResmi"];
            }
        }
        catch
        { }

        return y;
    }
    private static BayiYetkili LoadDataRecordBayiYetkili(IDataRecord dr)
    {
        BayiYetkili x = new BayiYetkili();

        try
        {
            if (dr["ID"] != DBNull.Value)
            {
                x.ID = (int)dr["ID"];
            }
        }
        catch
        {
        }


        try
        {
            if (dr["KullaniciAdi"] != DBNull.Value)
            {
                x.KullaniciAdi = (string)dr["KullaniciAdi"];
            }
        }
        catch
        {
        }

        try
        {
            if (dr["Parola"] != DBNull.Value)
            {
                x.Parola = (string)dr["Parola"];
            }
        }
        catch
        {
        }


        return x;
    }


    public class Admin
    {
        public static BayiYetkili OturumAc(string KullaniciAdi, string Parola, string Ip, string SessionId)
        {
            BayiYetkili x = new BayiYetkili();
            try
            {
                using (SqlConnection con = new SqlConnection(Guvenlik.ConnString))
                {
                    using (SqlCommand cmd = new SqlCommand("yp_OturumAc", con))
                    {
                        cmd.CommandTimeout = (60 * 60);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
                        cmd.Parameters.AddWithValue("@Parola", Parola);
                        cmd.Parameters.AddWithValue("@IP", Ip);
                        cmd.Parameters.AddWithValue("@SessionId", SessionId);

                        if (con.State != ConnectionState.Open)
                            con.Open();

                        using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            if (dr.Read())
                            {
                                if (dr["Result"].ToString() == "1")
                                {
                                    x = LoadDataRecordBayiYetkili(dr);


                                    x.Result = new ResultModel();
                                    x.Result.Code = 56;
                                    x.Result.Tanim = "İşlem başarıyla gerçekleştirildi.";
                                }
                                else
                                {
                                    x.Result = new ResultModel();
                                    x.Result.Code = 86;
                                    x.Result.Tanim = dr["Result"].ToString();
                                }

                            }
                            else
                            {
                                x.Result = new ResultModel();
                                x.Result.Code = 23;
                                x.Result.Tanim = "Girilen bilgilere sahip bir kullanıcı bulunamadı.";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                x.Result = new ResultModel();
                x.Result.Code = 57;
                x.Result.Tanim = ex.Message;
            }
            return x;
        }

        public static Tuple<ResultModel, int, ICollection<Kitaplar>> KitaplariGetir()
        {
            ResultModel x1 = new ResultModel();
            int x2 = 0;
            List<Kitaplar> x3 = new List<Kitaplar>();

            try
            {
                using (SqlConnection con = new SqlConnection(Guvenlik.ConnString))
                {
                    using (SqlCommand cmd = new SqlCommand("yp_KitapTürüListele", con))
                    {
                        cmd.CommandTimeout = (60 * 60);
                        cmd.CommandType = CommandType.StoredProcedure;

                        if (con.State != ConnectionState.Open)
                            con.Open();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {

                            while (dr.Read())
                            {
                                x3.Add(LoadDataRecordKitapTürleri(dr));
                            }
                            x2 = x3.Count();
                            if (x2 > 0)
                            {
                                x1 = new ResultModel();
                                x1.Code = 56;
                                x1.Tanim = "İşlem başarıyla gerçekleştirildi.";
                            }
                            else
                            {
                                x1 = new ResultModel();
                                x1.Code = 64;
                                x1.Tanim = "Kriterlere uygun kayıt bulunamadı!";
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                x1.Code = 57;
                x1.Tanim = ex.Message;
            }

            return new Tuple<ResultModel, int, ICollection<Kitaplar>>(x1, x2, x3);
        }

        public static Tuple<ResultModel, int, ICollection<KitapBilgileri>> Listele(AramaKriterleri aramaKriterleri)
        {
            ResultModel x1 = new ResultModel();
            int x2 = 0;
            List<KitapBilgileri> x3 = new List<KitapBilgileri>();
            try
            {
                using (SqlConnection con = new SqlConnection(Guvenlik.ConnString))
                {
                    using (SqlCommand cmd = new SqlCommand("yp_KitaplariListele", con))
                    {
                        cmd.CommandTimeout = (60 * 60);
                        cmd.CommandType = CommandType.StoredProcedure;

                        //cmd.Parameters.AddWithValue("@Durum", string.IsNullOrEmpty(aramaKriterleri.durum.ToString()) ? (object)DBNull.Value : aramaKriterleri.durum);

                        cmd.Parameters.AddWithValue("@Baslangic", (aramaKriterleri.sayfa == null || aramaKriterleri.sayfaBasiKayitSayisi == null) ? (object)DBNull.Value : ((Convert.ToInt32(aramaKriterleri.sayfaBasiKayitSayisi) * Convert.ToInt32(aramaKriterleri.sayfa)) + 1) - Convert.ToInt32(aramaKriterleri.sayfaBasiKayitSayisi));
                        cmd.Parameters.AddWithValue("@Bitis", (aramaKriterleri.sayfa == null || aramaKriterleri.sayfaBasiKayitSayisi == null) ? (object)DBNull.Value : Convert.ToInt32(aramaKriterleri.sayfaBasiKayitSayisi) * Convert.ToInt32(aramaKriterleri.sayfa));
                        cmd.Parameters.AddWithValue("@ArananText", string.IsNullOrEmpty(aramaKriterleri.aranacakKelime) ? (object)DBNull.Value : aramaKriterleri.aranacakKelime);
                        cmd.Parameters.AddWithValue("@KitapTürID", (aramaKriterleri.KitapTürID == null || aramaKriterleri.KitapTürID == 0) ? (object)DBNull.Value : aramaKriterleri.KitapTürID);

                        if (con.State != ConnectionState.Open)
                            con.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            x2 = Convert.ToInt32(dr["ToplamKayitSayisi"]);
                            if (x2 > 0)
                            {
                                if (dr.NextResult())
                                {
                                    while (dr.Read())
                                    {
                                        x3.Add(LoadDataRecordKitapBilgileri(dr));
                                    }
                                }
                                x1.Code = 56;
                                x1.Tanim = "İşlem Başarıyla Gerçekleştirildi";
                            }
                            else
                            {
                                x1.Code = 64;
                                x1.Tanim = "Kriterlere uygun kayıt bulunamadı";
                            }
                        }
                        else
                        {
                            x1.Code = 64;
                            x1.Tanim = "Kriterlere uygun kayıt bulunamadı";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                x1.Code = 57;
                x1.Tanim = ex.Message;
            }

            return new Tuple<ResultModel, int, ICollection<KitapBilgileri>>(x1, x2, x3);
        }

        public static Tuple<ResultModel> YeniKitapEkle(KitapBilgileri kitapModelleri)
        {
            ResultModel x = new ResultModel();
            try
            {
                using (SqlConnection con = new SqlConnection(Guvenlik.ConnString))
                {
                    using (SqlCommand cmd = new SqlCommand("yp_KitapEkle", con))
                    {
                        cmd.CommandTimeout = (60 * 60);
                        cmd.CommandType = CommandType.StoredProcedure;

                        //cmd.Parameters.AddWithValue("@ID", kitapModelleri.ID);
                        cmd.Parameters.AddWithValue("@Kitaplar_ID", kitapModelleri.Kitaplar_ID);
                        cmd.Parameters.AddWithValue("@KitapAdi", string.IsNullOrEmpty(kitapModelleri.KitapAdi) ? (object)DBNull.Value : kitapModelleri.KitapAdi);
                        cmd.Parameters.AddWithValue("@KitapYazari", string.IsNullOrEmpty(kitapModelleri.KitapYazari) ? (object)DBNull.Value : kitapModelleri.KitapYazari);
                        cmd.Parameters.AddWithValue("@KitapResmi", string.IsNullOrEmpty(kitapModelleri.KitapResmi) ? (object)DBNull.Value : kitapModelleri.KitapResmi);
                        cmd.Parameters.AddWithValue("@BasimTarihi", string.IsNullOrEmpty(kitapModelleri.BasimTarihi) ? (object)DBNull.Value : kitapModelleri.BasimTarihi);
                        cmd.Parameters.AddWithValue("@SayfaSayisi", kitapModelleri.SayfaSayisi == null ? (object)DBNull.Value : kitapModelleri.SayfaSayisi);
                        cmd.Parameters.AddWithValue("@ISBN", string.IsNullOrEmpty(kitapModelleri.ISBN) ? (object)DBNull.Value : kitapModelleri.ISBN);
                        cmd.Parameters.AddWithValue("@Dil", string.IsNullOrEmpty(kitapModelleri.Dil) ? (object)DBNull.Value : kitapModelleri.Dil);
                        cmd.Parameters.AddWithValue("@Ulke", string.IsNullOrEmpty(kitapModelleri.Ulke) ? (object)DBNull.Value : kitapModelleri.Ulke);
                        cmd.Parameters.AddWithValue("@YayinEvi", string.IsNullOrEmpty(kitapModelleri.YayınEvi) ? (object)DBNull.Value : kitapModelleri.YayınEvi);
                        cmd.Parameters.AddWithValue("@KitapHakkinda", string.IsNullOrEmpty(kitapModelleri.KitapHakkinda) ? (object)DBNull.Value : kitapModelleri.KitapHakkinda);

                        if (con.State != ConnectionState.Open)
                            con.Open();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                string queryResult = dr["Sonuc"].ToString();

                                if (queryResult == "1")
                                {
                                    x.Code = 56;
                                    x.Tanim = "İşleminiz başarıyla gerçekleştirildi.";
                                }
                                else
                                {
                                    x.Code = 57;
                                    x.Tanim = queryResult;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                x.Code = 57;
                x.Tanim = ex.Message;
            }
            return new Tuple<ResultModel>(x);
        }

        public static ResultModel KitapBilgileriniGuncelle(KitapBilgileri kitapModel)
        {
            ResultModel x = new ResultModel();
            try
            {
                using (SqlConnection con = new SqlConnection(Guvenlik.ConnString))
                {
                    using (SqlCommand cmd = new SqlCommand("yp_KitapBilgileriniGuncelle", con))
                    {
                        cmd.CommandTimeout = (60 * 60);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ID", kitapModel.ID);
                        cmd.Parameters.AddWithValue("@Kitaplar_ID", kitapModel.Kitaplar_ID);
                        cmd.Parameters.AddWithValue("@KitapAdi", string.IsNullOrEmpty(kitapModel.KitapAdi) ? (object)DBNull.Value : kitapModel.KitapAdi);
                        cmd.Parameters.AddWithValue("@KitapYazari", string.IsNullOrEmpty(kitapModel.KitapYazari) ? (object)DBNull.Value : kitapModel.KitapYazari);
                        cmd.Parameters.AddWithValue("@KitapResmi", string.IsNullOrEmpty(kitapModel.KitapResmi) ? (object)DBNull.Value : kitapModel.KitapResmi);
                        cmd.Parameters.AddWithValue("@BasimTarihi", string.IsNullOrEmpty(kitapModel.BasimTarihi) ? (object)DBNull.Value : kitapModel.BasimTarihi);
                        cmd.Parameters.AddWithValue("@SayfaSayisi", kitapModel.SayfaSayisi == null ? (object)DBNull.Value : kitapModel.SayfaSayisi);
                        cmd.Parameters.AddWithValue("@ISBN", string.IsNullOrEmpty(kitapModel.ISBN) ? (object)DBNull.Value : kitapModel.ISBN);
                        cmd.Parameters.AddWithValue("@Dil", string.IsNullOrEmpty(kitapModel.Dil) ? (object)DBNull.Value : kitapModel.Dil);
                        cmd.Parameters.AddWithValue("@Ulke", string.IsNullOrEmpty(kitapModel.Ulke) ? (object)DBNull.Value : kitapModel.Ulke);
                        cmd.Parameters.AddWithValue("@YayinEvi", string.IsNullOrEmpty(kitapModel.YayınEvi) ? (object)DBNull.Value : kitapModel.YayınEvi);
                        cmd.Parameters.AddWithValue("@KitapHakkinda", string.IsNullOrEmpty(kitapModel.KitapHakkinda) ? (object)DBNull.Value : kitapModel.KitapHakkinda);

                        if (con.State != ConnectionState.Open)
                            con.Open();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                string queryResult = dr["Sonuc"].ToString();

                                if (queryResult == "1")
                                {
                                    x.Code = 56;
                                    x.Tanim = "İşleminiz başarıyla gerçekleştirildi.";
                                }
                                else
                                {
                                    x.Code = 57;
                                    x.Tanim = queryResult;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                x.Code = 57;
                x.Tanim = ex.Message;
            }
            return x;
        }

        public static Tuple<ResultModel, KitapBilgileri> KitapBilgileriniGetir(int KitapID)
        {
            ResultModel x1 = new ResultModel();
            KitapBilgileri x2 = new KitapBilgileri();
            try
            {
                using (SqlConnection con = new SqlConnection(Guvenlik.ConnString))
                {
                    using (SqlCommand cmd = new SqlCommand("yp_KitapBilgileriniGetir", con))
                    {
                        cmd.CommandTimeout = (60 * 60);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@KitapID", KitapID);

                        if (con.State != ConnectionState.Open)
                            con.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow))
                        {
                            if (dr.Read())
                            {
                                x2 = LoadDataRecordKitapBilgileri(dr);
                                x1.Code = 56;
                                x1.Tanim = "İşlem başarıyla gerçekleştirildi";
                            }
                            else
                            {
                                x1.Code = 64;
                                x1.Tanim = "Kriterlere uygun kayıt bulunamadı";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                x1.Code = 57;
                x1.Tanim = ex.Message;
            }
            return new Tuple<ResultModel, KitapBilgileri>(x1, x2);
        }
    }


    /*KULLANICI TARAFINDA Kİ İŞLEMLER*/
    public static Kullanicilar OturumAc(string email, string password, string Ip, string SessionId)
    {
        Kullanicilar x = new Kullanicilar();
        try
        {
            using (SqlConnection con = new SqlConnection(Guvenlik.ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("kl_OturumAc", con))
                {
                    cmd.CommandTimeout = (60 * 60);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@IP", Ip);
                    cmd.Parameters.AddWithValue("@SessionId", SessionId);

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        if (dr.Read())
                        {
                            if (dr["Result"].ToString() == "1")
                            {
                                x = LoadDataRecordKullanici(dr);


                                x.Result = new ResultModel();
                                x.Result.Code = 1;
                                x.Result.Tanim = "İşlem başarıyla gerçekleştirildi.";
                            }
                            //else
                            //{
                            //    x.Result = new ResultModel();
                            //    x.Result.Code = 0;
                            //    x.Result.Tanim = "Girilen bilgilere sahip bir kullanıcı bulunamadı.";
                            //}
                        }
                        else
                        {
                            x.Result = new ResultModel();
                            x.Result.Code = 0;
                            x.Result.Tanim = "Girilen bilgilere sahip bir kullanıcı bulunamadı.";
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            x.Result = new ResultModel();
            x.Result.Code = 57;
            x.Result.Tanim = ex.Message;
        }
        return x;
    }
    public static ResultModel UyeKayit(Kullanicilar uyekayit)
    {
        ResultModel x = new ResultModel();
        try
        {
            using (SqlConnection con = new SqlConnection(Guvenlik.ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("kl_YeniKullaniciEkle", con))
                {
                    cmd.CommandTimeout = (60 * 60);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Ad_Soyad", string.IsNullOrEmpty(uyekayit.Ad_Soyad) ? (object)DBNull.Value : uyekayit.Ad_Soyad);
                    cmd.Parameters.AddWithValue("@E_Mail", string.IsNullOrEmpty(uyekayit.E_Mail) ? (object)DBNull.Value : uyekayit.E_Mail);
                    cmd.Parameters.AddWithValue("@Sifre", string.IsNullOrEmpty(uyekayit.Sifre) ? (object)DBNull.Value : uyekayit.Sifre);

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            string queryResult = dr["Result"].ToString();

                            if (queryResult == "0")
                            {
                                x.Code = 0;
                                x.Tanim = "Bu E-Mail adresinde kayıt mevcuttur.Lütfen farklı bir e-mail adresi giriniz!";
                            }
                            else
                            {
                                x.Code = 1;
                                x.Tanim = "İşleminiz başarıyla gerçekleştirildi.";
                            }
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            x.Code = 57;
            x.Tanim = ex.Message;
        }
        return x;
    }

    public static Tuple<ResultModel, int, ICollection<KitapBilgileri>> KitapListele(int? KitapTürID)
    {
        ResultModel x1 = new ResultModel();
        int x2 = 0;
        List<KitapBilgileri> x3 = new List<KitapBilgileri>();
        try
        {
            using (SqlConnection con = new SqlConnection(Guvenlik.ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("kl_KitaplariListele", con))
                {
                    cmd.CommandTimeout = (60 * 60);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID", (KitapTürID == null || KitapTürID == 0) ? (object)DBNull.Value : KitapTürID);


                    if (con.State != ConnectionState.Open)
                        con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        x2 = Convert.ToInt32(dr["ToplamKayitSayisi"]);
                        if (x2 > 0)
                        {
                            if (dr.NextResult())
                            {
                                while (dr.Read())
                                {
                                    x3.Add(LoadDataRecordKitaplar(dr));
                                }
                            }
                            x1.Code = 1;
                            x1.Tanim = "İşlem Başarıyla Gerçekleştirildi";
                        }
                        else
                        {
                            x1.Code = 0;
                            x1.Tanim = "Kriterlere uygun kayıt bulunamadı";
                        }
                    }
                    else
                    {
                        x1.Code = 64;
                        x1.Tanim = "Kriterlere uygun kayıt bulunamadı";
                    }
                }
            }
        }
        catch (Exception ex)
        {
            x1.Code = 57;
            x1.Tanim = ex.Message;
        }

        return new Tuple<ResultModel, int, ICollection<KitapBilgileri>>(x1, x2, x3);
    }

    public static Tuple<ResultModel, int, ICollection<KitapBilgileri>> AnasayfaKitapListele()
    {
        ResultModel x1 = new ResultModel();
        int x2 = 9;
        List<KitapBilgileri> x3 = new List<KitapBilgileri>();
        try
        {
            using (SqlConnection con = new SqlConnection(Guvenlik.ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("as_KitaplariListele", con))
                {
                    cmd.CommandTimeout = (60 * 60);
                    cmd.CommandType = CommandType.StoredProcedure;


                    if (con.State != ConnectionState.Open)
                        con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read() && x2 > 0)
                        {
                            x3.Add(LoadDataRecordKitapBilgileri(dr));
                            x2--;
                        }
                        int x4 = x3.Count();
                        if (x4 > 0)
                        {
                            x1 = new ResultModel();
                            x1.Code = 56;
                            x1.Tanim = "İşlem başarıyla gerçekleştirildi.";
                        }
                        else
                        {
                            x1 = new ResultModel();
                            x1.Code = 64;
                            x1.Tanim = "Kriterlere uygun kayıt bulunamadı!";
                        }
                    }

                }
            }
        }
        catch (Exception ex)
        {
            x1.Code = 57;
            x1.Tanim = ex.Message;
        }

        return new Tuple<ResultModel, int, ICollection<KitapBilgileri>>(x1, x2, x3);
    }

    public static Tuple<ResultModel, int, ICollection<Kullanicilar>> AnasayfaOkuyucuListele()
    {
        ResultModel x1 = new ResultModel();
        int x2 = 5;
        List<Kullanicilar> x3 = new List<Kullanicilar>();
        try
        {
            using (SqlConnection con = new SqlConnection(Guvenlik.ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("as_OkuyuculariListele", con))
                {
                    cmd.CommandTimeout = (60 * 60);
                    cmd.CommandType = CommandType.StoredProcedure;


                    if (con.State != ConnectionState.Open)
                        con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read() && x2 > 0)
                        {
                            x3.Add(LoadDataRecordKullaniciYorumlari(dr));
                            x2--;
                        }
                        int x4 = x3.Count();
                        if (x4 > 0)
                        {
                            x1 = new ResultModel();
                            x1.Code = 56;
                            x1.Tanim = "İşlem başarıyla gerçekleştirildi.";
                        }
                        else
                        {
                            x1 = new ResultModel();
                            x1.Code = 64;
                            x1.Tanim = "Kriterlere uygun kayıt bulunamadı!";
                        }
                    }

                }
            }
        }
        catch (Exception ex)
        {
            x1.Code = 57;
            x1.Tanim = ex.Message;
        }

        return new Tuple<ResultModel, int, ICollection<Kullanicilar>>(x1, x2, x3);
    }

    public static Tuple<ResultModel, int, ICollection<Kitaplar>> KitapTürleriListele()
    {
        ResultModel x1 = new ResultModel();
        int x2 = 0;
        List<Kitaplar> x3 = new List<Kitaplar>();

        try
        {
            using (SqlConnection con = new SqlConnection(Guvenlik.ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("kl_KitapTürleriListele", con))
                {
                    cmd.CommandTimeout = (60 * 60);
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            x3.Add(LoadDataRecordKitapTürleri(dr));
                        }
                        x2 = x3.Count();
                        if (x2 > 0)
                        {
                            x1 = new ResultModel();
                            x1.Code = 56;
                            x1.Tanim = "İşlem başarıyla gerçekleştirildi.";
                        }
                        else
                        {
                            x1 = new ResultModel();
                            x1.Code = 64;
                            x1.Tanim = "Kriterlere uygun kayıt bulunamadı!";
                        }

                    }
                }
            }
        }
        catch (Exception ex)
        {
            x1.Code = 57;
            x1.Tanim = ex.Message;
        }

        return new Tuple<ResultModel, int, ICollection<Kitaplar>>(x1, x2, x3);
    }

    public static Tuple<ResultModel, int, List<KitapBilgileri>, ICollection<Kullanicilar>> KitapBilgileri(int? KitapID)
    {
        ResultModel x1 = new ResultModel();
        int x2 = 0;
        List<KitapBilgileri> x3 = new List<KitapBilgileri>();
        List<Kullanicilar> x4 = new List<Kullanicilar>();
        try
        {
            using (SqlConnection con = new SqlConnection(Guvenlik.ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("kl_KitapBilgileri", con))
                {
                    cmd.CommandTimeout = (60 * 60);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID", (KitapID == null || KitapID == 0) ? (object)DBNull.Value : KitapID);


                    if (con.State != ConnectionState.Open)
                        con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        x2 = Convert.ToInt32(dr["ToplamKayitSayisi"]);
                        if (dr.NextResult())
                        {
                            while (dr.Read())
                            {
                                x3.Add(LoadDataRecordKitapBilgileri(dr));
                            }
                        }
                        if (x2 > 0)
                        {
                            if (dr.NextResult())
                            {
                                while (dr.Read())
                                {
                                    x4.Add(LoadDataRecordKullaniciYorumlari(dr));
                                }
                            }
                            x1.Code = 1;
                            x1.Tanim = "İşlem Başarıyla Gerçekleştirildi";
                        }
                        else
                        {
                            x1.Code = 0;
                            x1.Tanim = "Kriterlere uygun kayıt bulunamadı";
                        }
                    }
                    else
                    {
                        x1.Code = 64;
                        x1.Tanim = "Kriterlere uygun kayıt bulunamadı";
                    }
                }
            }
        }
        catch (Exception ex)
        {
            x1.Code = 57;
            x1.Tanim = ex.Message;
        }

        return new Tuple<ResultModel, int, List<KitapBilgileri>, ICollection<Kullanicilar>>(x1, x2, x3, x4);
    }

    public static Tuple<ResultModel, List<KitapBilgileri>, ICollection<Kullanicilar>> KitapBasimBilgileri(int? KitapID)
    {
        ResultModel x1 = new ResultModel();
        List<KitapBilgileri> x2 = new List<KitapBilgileri>();
        List<Kullanicilar> x3 = new List<Kullanicilar>();
        try
        {
            using (SqlConnection con = new SqlConnection(Guvenlik.ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("kl_KitapBasimBilgileri", con))
                {
                    cmd.CommandTimeout = (60 * 60);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@KitapID", (KitapID == null || KitapID == 0) ? (object)DBNull.Value : KitapID);


                    if (con.State != ConnectionState.Open)
                        con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        x2.Add(LoadDataRecordKitapBilgileri(dr));
                        if (dr.NextResult())
                        {
                            while (dr.Read())
                            {
                                x3.Add(LoadDataRecordKullaniciYorumlari(dr));
                            }
                            x1.Code = 1;
                            x1.Tanim = "İşlem Başarıyla Gerçekleştirildi";
                        }
                        else
                        {
                            x1.Code = 0;
                            x1.Tanim = "Kriterlere uygun kayıt bulunamadı";
                        }
                    }
                    else
                    {
                        x1.Code = 64;
                        x1.Tanim = "Kriterlere uygun kayıt bulunamadı";
                    }
                }
            }
        }
        catch (Exception ex)
        {
            x1.Code = 57;
            x1.Tanim = ex.Message;
        }

        return new Tuple<ResultModel, List<KitapBilgileri>, ICollection<Kullanicilar>>(x1, x2, x3);
    }

    public static Tuple<ResultModel, List<Profil>> ProfilBilgileri(int? KullaniciID)
    {
        ResultModel x1 = new ResultModel();
        List<Profil> x2 = new List<Profil>();
        try
        {
            using (SqlConnection con = new SqlConnection(Guvenlik.ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("kl_ProfilBilgileri", con))
                {
                    cmd.CommandTimeout = (60 * 60);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@KullaniciID", (KullaniciID == null || KullaniciID == 0) ? (object)DBNull.Value : KullaniciID);

                    if (con.State != ConnectionState.Open)
                        con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        x2.Add(LoadDataRecordProfilBilgileri(dr));
                        x1.Code = 1;
                        x1.Tanim = "İşlem Başarıyla Gerçekleştirildi.";
                    }
                    else
                    {
                        x1.Code = 0;
                        x1.Tanim = "Kriterlere Uygun Bilgi Bulunamadı.";
                    }
                }
            }
        }
        catch (Exception ex)
        {
            x1.Code = 51;
            x1.Tanim = ex.Message;
        }

        return new Tuple<ResultModel, List<Profil>>(x1, x2);
    }

    public static Tuple<ResultModel, int, List<Yorumlar>> ProfilYorumlari(int? KullaniciID)
    {
        ResultModel x1 = new ResultModel();
        int x2 = 0;
        List<Yorumlar> x3 = new List<Yorumlar>();
        try
        {
            using (SqlConnection con = new SqlConnection(Guvenlik.ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("kl_ProfilYorumlari", con))
                {
                    cmd.CommandTimeout = (60 * 60);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@KullaniciID", (KullaniciID == null || KullaniciID == 0) ? (object)DBNull.Value : KullaniciID);


                    if (con.State != ConnectionState.Open)
                        con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        x2 = Convert.ToInt32(dr["ToplamKayitSayisi"]);
                        if (x2 > 0 || x2 == 1)
                        {
                            if (dr.NextResult())
                            {
                                while (dr.Read())
                                {
                                    x3.Add(LoadDataRecordProfilYorumlari(dr));
                                }
                                x1.Code = 1;
                                x1.Tanim = "İşlem Başarıyla Gerçekleştirildi";
                            }
                            else
                            {
                                x1.Code = 0;
                                x1.Tanim = "Kriterlere uygun kayıt bulunamadı";
                            }
                        }
                    }
                    else
                    {
                        x1.Code = 64;
                        x1.Tanim = "Kriterlere uygun kayıt bulunamadı";
                    }
                }
            }
        }
        catch (Exception ex)
        {
            x1.Code = 57;
            x1.Tanim = ex.Message;
        }

        return new Tuple<ResultModel, int, List<Yorumlar>>(x1, x2, x3);
    }


    public static Tuple<ResultModel, int, List<KitapBilgileri>> MenuOkuyacaklarimiGetir(int? KullaniciID)
    {
        ResultModel x1 = new ResultModel();
        int x2 = 0;
        List<KitapBilgileri> x3 = new List<KitapBilgileri>();
        try
        {
            using (SqlConnection con = new SqlConnection(Guvenlik.ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("kl_OkuyacaklarimiGetir", con))
                {
                    cmd.CommandTimeout = (60 * 60);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@KullaniciID", (KullaniciID == null || KullaniciID == 0) ? (object)DBNull.Value : KullaniciID);


                    if (con.State != ConnectionState.Open)
                        con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        x2 = Convert.ToInt32(dr["ToplamKayitSayisi"]);
                        if (x2 > 0 || x2 == 1)
                        {
                            if (dr.NextResult())
                            {
                                while (dr.Read())
                                {
                                    x3.Add(LoadDataRecordKitapBilgileri(dr));
                                }
                                x1.Code = 1;
                                x1.Tanim = "İşlem Başarıyla Gerçekleştirildi";
                            }
                            else
                            {
                                x1.Code = 0;
                                x1.Tanim = "Kriterlere uygun kayıt bulunamadı";
                            }
                        }
                    }
                    else
                    {
                        x1.Code = 64;
                        x1.Tanim = "Kriterlere uygun kayıt bulunamadı";
                    }
                }
            }
        }
        catch (Exception ex)
        {
            x1.Code = 57;
            x1.Tanim = ex.Message;
        }

        return new Tuple<ResultModel, int, List<KitapBilgileri>>(x1, x2, x3);
    }

    public static Tuple<ResultModel, int, List<KitapBilgileri>> MenuOkumaktaOlduklarimiGetir(int? KullaniciID)
    {
        ResultModel x1 = new ResultModel();
        int x2 = 0;
        List<KitapBilgileri> x3 = new List<KitapBilgileri>();
        try
        {
            using (SqlConnection con = new SqlConnection(Guvenlik.ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("kl_OkumaktaOlduklarimiGetir", con))
                {
                    cmd.CommandTimeout = (60 * 60);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@KullaniciID", (KullaniciID == null || KullaniciID == 0) ? (object)DBNull.Value : KullaniciID);


                    if (con.State != ConnectionState.Open)
                        con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        x2 = Convert.ToInt32(dr["ToplamKayitSayisi"]);
                        if (x2 > 0 || x2 == 1)
                        {
                            if (dr.NextResult())
                            {
                                while (dr.Read())
                                {
                                    x3.Add(LoadDataRecordKitapBilgileri(dr));
                                }
                                x1.Code = 1;
                                x1.Tanim = "İşlem Başarıyla Gerçekleştirildi";
                            }
                            else
                            {
                                x1.Code = 0;
                                x1.Tanim = "Kriterlere uygun kayıt bulunamadı";
                            }
                        }
                    }
                    else
                    {
                        x1.Code = 64;
                        x1.Tanim = "Kriterlere uygun kayıt bulunamadı";
                    }
                }
            }
        }
        catch (Exception ex)
        {
            x1.Code = 57;
            x1.Tanim = ex.Message;
        }

        return new Tuple<ResultModel, int, List<KitapBilgileri>>(x1, x2, x3);
    }

    public static Tuple<ResultModel, int, List<KitapBilgileri>> MenuOkuduklarimiGetir(int? KullaniciID)
    {
        ResultModel x1 = new ResultModel();
        int x2 = 0;
        List<KitapBilgileri> x3 = new List<KitapBilgileri>();
        try
        {
            using (SqlConnection con = new SqlConnection(Guvenlik.ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("kl_OkuduklarimiGetir", con))
                {
                    cmd.CommandTimeout = (60 * 60);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@KullaniciID", (KullaniciID == null || KullaniciID == 0) ? (object)DBNull.Value : KullaniciID);


                    if (con.State != ConnectionState.Open)
                        con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        x2 = Convert.ToInt32(dr["ToplamKayitSayisi"]);
                        if (x2 > 0 || x2 == 1)
                        {
                            if (dr.NextResult())
                            {
                                while (dr.Read())
                                {
                                    x3.Add(LoadDataRecordKitapBilgileri(dr));
                                }
                                x1.Code = 1;
                                x1.Tanim = "İşlem Başarıyla Gerçekleştirildi";
                            }
                            else
                            {
                                x1.Code = 0;
                                x1.Tanim = "Kriterlere uygun kayıt bulunamadı";
                            }
                        }
                    }
                    else
                    {
                        x1.Code = 64;
                        x1.Tanim = "Kriterlere uygun kayıt bulunamadı";
                    }
                }
            }
        }
        catch (Exception ex)
        {
            x1.Code = 57;
            x1.Tanim = ex.Message;
        }

        return new Tuple<ResultModel, int, List<KitapBilgileri>>(x1, x2, x3);
    }

    public static Tuple<ResultModel, int, List<KitapBilgileri>> MenuKutuphanemiGetir(int? KullaniciID)
    {
        ResultModel x1 = new ResultModel();
        int x2 = 0;
        List<KitapBilgileri> x3 = new List<KitapBilgileri>();
        try
        {
            using (SqlConnection con = new SqlConnection(Guvenlik.ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("kl_KutuphanemiGetir", con))
                {
                    cmd.CommandTimeout = (60 * 60);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@KullaniciID", (KullaniciID == null || KullaniciID == 0) ? (object)DBNull.Value : KullaniciID);


                    if (con.State != ConnectionState.Open)
                        con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        x2 = Convert.ToInt32(dr["ToplamKayitSayisi"]);
                        if (x2 > 0 || x2 == 1)
                        {
                            if (dr.NextResult())
                            {
                                while (dr.Read())
                                {
                                    x3.Add(LoadDataRecordKitapBilgileri(dr));
                                }
                                x1.Code = 1;
                                x1.Tanim = "İşlem Başarıyla Gerçekleştirildi";
                            }
                            else
                            {
                                x1.Code = 0;
                                x1.Tanim = "Kriterlere uygun kayıt bulunamadı";
                            }
                        }
                    }
                    else
                    {
                        x1.Code = 64;
                        x1.Tanim = "Kriterlere uygun kayıt bulunamadı";
                    }
                }
            }
        }
        catch (Exception ex)
        {
            x1.Code = 57;
            x1.Tanim = ex.Message;
        }

        return new Tuple<ResultModel, int, List<KitapBilgileri>>(x1, x2, x3);
    }

    public static Tuple<ResultModel, Profil> ProfilBilgilerimiGetirPopUp(int? KullaniciID)
    {
        ResultModel x1 = new ResultModel();
        Profil x2 = new Profil();
        try
        {
            using (SqlConnection con = new SqlConnection(Guvenlik.ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("kl_ProfilBilgileri", con))
                {
                    cmd.CommandTimeout = (60 * 60);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@KullaniciID", (KullaniciID == null || KullaniciID == 0) ? (object)DBNull.Value : KullaniciID);

                    if (con.State != ConnectionState.Open)
                        con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        x2 = LoadDataRecordProfilBilgileri(dr);
                        x1.Code = 1;
                        x1.Tanim = "İşlem başarı ile gerçekleştirildi";
                    }
                    else
                    {
                        x1.Code = 0;
                        x1.Tanim = "İşlem sırasında bir hata oluştu";
                    }
                }
            }
        }
        catch (Exception ex)
        {
            x1.Code = 51;
            x1.Tanim = ex.Message;
        }
        return new Tuple<ResultModel, Profil>(x1, x2);
    }

    public static ResultModel ProfilBilgilerimiGuncelle(Profil profilModel)
    {
        ResultModel x = new ResultModel();
        try
        {
            using (SqlConnection con = new SqlConnection(Guvenlik.ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("kl_ProfilBilgilerimiGuncelle", con))
                {
                    cmd.CommandTimeout = (60 * 60);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@KullaniciID", (profilModel.Kullanici_ID == null || profilModel.Kullanici_ID == 0) ? (object)DBNull.Value : profilModel.Kullanici_ID);
                    cmd.Parameters.AddWithValue("@YasadigiYer", string.IsNullOrEmpty(profilModel.YasadigiYer) ? (object)DBNull.Value : profilModel.YasadigiYer);
                    cmd.Parameters.AddWithValue("@Memleket", string.IsNullOrEmpty(profilModel.Memleket) ? (object)DBNull.Value : profilModel.Memleket);
                    cmd.Parameters.AddWithValue("@DogumTarihi", string.IsNullOrEmpty(profilModel.DogumTarihi) ? (object)DBNull.Value : profilModel.DogumTarihi);
                    cmd.Parameters.AddWithValue("@Cinsiyet", string.IsNullOrEmpty(profilModel.Cinsiyet) ? (object)DBNull.Value : profilModel.Cinsiyet);

                    if (con.State != ConnectionState.Open)
                        con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        if (dr.Read())
                        {
                            if (dr["Result"].ToString() == "1")
                            {
                                x.Code = 1;
                                x.Tanim = "Profiliniz Güncellenmiştir.";
                            }
                            else
                            {
                                x.Code = 0;
                                x.Tanim = "İşlem sırasında bir hata ile karşılaşılmıştır.";
                            }
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            x.Code = 57;
            x.Tanim = ex.Message;
        }
        return x;
    }

    public static ResultModel YeniYorumEkle(Yorumlar yorumModel)
    {
        ResultModel x = new ResultModel();
        try
        {
            using (SqlConnection con = new SqlConnection(Guvenlik.ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("kl_YeniYorumEkle", con))
                {
                    cmd.CommandTimeout = (60 * 60);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@KullaniciID", (yorumModel.Kullanici_ID == null || yorumModel.Kullanici_ID == 0) ? (object)DBNull.Value : yorumModel.Kullanici_ID);
                    cmd.Parameters.AddWithValue("@KitapBilgileriID", (yorumModel.KitapBilgileri_ID == null || yorumModel.KitapBilgileri_ID == 0) ? (object)DBNull.Value : yorumModel.KitapBilgileri_ID);
                    cmd.Parameters.AddWithValue("@Yorum", string.IsNullOrEmpty(yorumModel.Yorum) ? (object)DBNull.Value : yorumModel.Yorum);


                    if (con.State != ConnectionState.Open)
                        con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())

                    {
                        if (dr.Read())
                        {
                            string queryResult = dr["Result"].ToString();

                            if (queryResult == "1")
                            {
                                x.Code = 1;
                                x.Tanim = "İşleminiz başarıyla gerçekleştirildi.";
                            }
                            else
                            {
                                x.Code = 0;
                                x.Tanim = "Bu E-Mail adresinde kayıt mevcuttur.Lütfen farklı bir e-mail adresi giriniz!";
                            }
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            x.Code = 57;
            x.Tanim = ex.Message;
        }
        return x;
    }

    public static ResultModel OyBegendim(int? OYSayisi, int? KitapID)
    {
        ResultModel x = new ResultModel();
        try
        {
            using (SqlConnection con = new SqlConnection(Guvenlik.ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("kl_Oyver", con))
                {
                    cmd.CommandTimeout = (60 * 60);
                    cmd.CommandType = CommandType.StoredProcedure;

                    OYSayisi++;
                    cmd.Parameters.AddWithValue("@OySayisi", (OYSayisi == null || OYSayisi == 0) ? (object)DBNull.Value : OYSayisi);
                    cmd.Parameters.AddWithValue("@KitapID", (KitapID == null || KitapID == 0) ? (object)DBNull.Value : KitapID);

                    if (con.State != ConnectionState.Open)
                        con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        if (dr.Read())
                        {
                            if (dr["Result"].ToString() == "1")
                            {
                                x.Code = 1;
                                x.Tanim = "Oy Kullanılmıştır.";
                            }
                            else
                            {
                                x.Code = 0;
                                x.Tanim = "İşlem sırasında bir hata ile karşılaşılmıştır.";
                            }
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            x.Code = 57;
            x.Tanim = ex.Message;
        }
        return x;
    }

    public static ResultModel OyBegenmedim(int? OYSayisi, int? KitapID)
    {
        ResultModel x = new ResultModel();
        try
        {
            using (SqlConnection con = new SqlConnection(Guvenlik.ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("kl_Oyver", con))
                {
                    cmd.CommandTimeout = (60 * 60);
                    cmd.CommandType = CommandType.StoredProcedure;

                    OYSayisi--;
                    cmd.Parameters.AddWithValue("@OySayisi", (OYSayisi == null || OYSayisi == 0) ? (object)DBNull.Value : OYSayisi);
                    cmd.Parameters.AddWithValue("@KitapID", (KitapID == null || KitapID == 0) ? (object)DBNull.Value : KitapID);

                    if (con.State != ConnectionState.Open)
                        con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        if (dr.Read())
                        {
                            if (dr["Result"].ToString() == "1")
                            {
                                x.Code = 1;
                                x.Tanim = "Oy Kullanılmıştır.";
                            }
                            else
                            {
                                x.Code = 0;
                                x.Tanim = "İşlem sırasında bir hata ile karşılaşılmıştır.";
                            }
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            x.Code = 57;
            x.Tanim = ex.Message;
        }
        return x;
    }

    public static ResultModel OkuyacaklarimaEkle(int? KitapID, int? KullaniciID)
    {
        ResultModel x = new ResultModel();
        try
        {
            using (SqlConnection con = new SqlConnection(Guvenlik.ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("kl_OkuyacaklarimaEkle", con))
                {
                    cmd.CommandTimeout = (60 * 60);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Kullanici_ID", (KullaniciID == null || KullaniciID == 0) ? (object)DBNull.Value : KullaniciID);
                    cmd.Parameters.AddWithValue("@KitapID", (KitapID == null || KitapID == 0) ? (object)DBNull.Value : KitapID);


                    if (con.State != ConnectionState.Open)
                        con.Open();
                    string queryResult = cmd.ExecuteScalar().ToString();

                    if (queryResult == "1")
                    {
                        x.Code = 1;
                        x.Tanim = "İşleminiz başarıyla gerçekleştirildi.";
                    }
                    else
                    {
                        x.Code = 0;
                        x.Tanim = "Bu kitap Okunacaklar listesinde mevcuttur.";

                    }
                }
            }
        }
        catch (Exception ex)
        {
            x.Code = 57;
            x.Tanim = ex.Message;
        }
        return x;
    }

    public static ResultModel OkumaktaOlduklarimaEkle(int? KitapID, int? KullaniciID)
    {
        ResultModel x = new ResultModel();
        try
        {
            using (SqlConnection con = new SqlConnection(Guvenlik.ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("kl_OkumaktaOlduklarimaEkle", con))
                {
                    cmd.CommandTimeout = (60 * 60);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Kullanici_ID", (KullaniciID == null || KullaniciID == 0) ? (object)DBNull.Value : KullaniciID);
                    cmd.Parameters.AddWithValue("@KitapID", (KitapID == null || KitapID == 0) ? (object)DBNull.Value : KitapID);


                    if (con.State != ConnectionState.Open)
                        con.Open();
                    string queryResult = cmd.ExecuteScalar().ToString();

                    if (queryResult == "1")
                    {
                        x.Code = 1;
                        x.Tanim = "İşleminiz başarıyla gerçekleştirildi.";
                    }
                    else
                    {
                        x.Code = 0;
                        x.Tanim = "Bu kitap Okumakta olduğunuz kitaplar listesinde mevcuttur.";

                    }
                }
            }
        }
        catch (Exception ex)
        {
            x.Code = 57;
            x.Tanim = ex.Message;
        }
        return x;
    }

    public static ResultModel OkuduklarimaEkle(int? KitapID, int? KullaniciID)
    {
        ResultModel x = new ResultModel();
        try
        {
            using (SqlConnection con = new SqlConnection(Guvenlik.ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("kl_OkuduklarimaEkle", con))
                {
                    cmd.CommandTimeout = (60 * 60);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Kullanici_ID", (KullaniciID == null || KullaniciID == 0) ? (object)DBNull.Value : KullaniciID);
                    cmd.Parameters.AddWithValue("@KitapID", (KitapID == null || KitapID == 0) ? (object)DBNull.Value : KitapID);


                    if (con.State != ConnectionState.Open)
                        con.Open();
                    string queryResult = cmd.ExecuteScalar().ToString();

                    if (queryResult == "1")
                    {
                        x.Code = 1;
                        x.Tanim = "İşleminiz başarıyla gerçekleştirildi.";
                    }
                    else
                    {
                        x.Code = 0;
                        x.Tanim = "Bu kitap okunanlar listesinde mevcuttur.";

                    }
                }
            }
        }
        catch (Exception ex)
        {
            x.Code = 57;
            x.Tanim = ex.Message;
        }
        return x;
    }

    public static ResultModel KutuphanemeEkle(int? KitapID, int? KullaniciID)
    {
        ResultModel x = new ResultModel();
        try
        {
            using (SqlConnection con = new SqlConnection(Guvenlik.ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("kl_KutuphanemeEkle", con))
                {
                    cmd.CommandTimeout = (60 * 60);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Kullanici_ID", (KullaniciID == null || KullaniciID == 0) ? (object)DBNull.Value : KullaniciID);
                    cmd.Parameters.AddWithValue("@KitapID", (KitapID == null || KitapID == 0) ? (object)DBNull.Value : KitapID);


                    if (con.State != ConnectionState.Open)
                        con.Open();
                    string queryResult = cmd.ExecuteScalar().ToString();

                    if (queryResult == "1")
                    {
                        x.Code = 1;
                        x.Tanim = "İşleminiz başarıyla gerçekleştirildi.";
                    }
                    else
                    {
                        x.Code = 0;
                        x.Tanim = "Bu kitap okunanlar listesinde mevcuttur.";

                    }
                }
            }
        }
        catch (Exception ex)
        {
            x.Code = 57;
            x.Tanim = ex.Message;
        }
        return x;
    }

    public static ResultModel KitapSil(int? KitapID, int? KullaniciID)
    {
        ResultModel x = new ResultModel();
        try
        {
            using (SqlConnection con = new SqlConnection(Guvenlik.ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("kl_KitapSil", con))
                {
                    cmd.CommandTimeout = (60 * 60);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Kullanici_ID", (KullaniciID == null || KullaniciID == 0) ? (object)DBNull.Value : KullaniciID);
                    cmd.Parameters.AddWithValue("@KitapID", (KitapID == null || KitapID == 0) ? (object)DBNull.Value : KitapID);


                    if (con.State != ConnectionState.Open)
                        con.Open();
                    string queryResult = cmd.ExecuteScalar().ToString();

                    if (queryResult == "1")
                    {
                        x.Code = 1;
                        x.Tanim = "İşleminiz başarıyla gerçekleştirildi.";
                    }
                    else
                    {
                        x.Code = 0;
                        x.Tanim = "Bu kitap okunanlar listesinde mevcuttur.";

                    }
                }
            }
        }
        catch (Exception ex)
        {
            x.Code = 57;
            x.Tanim = ex.Message;
        }
        return x;
    }

    public static void ResimKaydet(string resimadi, int? KullaniciID)
    {
        ResultModel x = new ResultModel();
        try
        {
            using (SqlConnection con = new SqlConnection(Guvenlik.ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("kl_ProfilResmiGuncelle", con))
                {
                    cmd.CommandTimeout = (60 * 60);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID", KullaniciID);
                    cmd.Parameters.AddWithValue("@Resim", string.IsNullOrEmpty(resimadi) ? (object)DBNull.Value : resimadi);

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                        //SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            string queryResult = dr["Sonuc"].ToString();

                            if (queryResult == "1")
                            {
                                x.Code = 56;
                                x.Tanim = "İşleminiz başarıyla gerçekleştirildi.";
                            }
                            else
                            {
                                x.Code = 57;
                                x.Tanim = queryResult;
                            }
                        }
                }
            }
        }
        catch (Exception ex)
        {
            x.Code = 57;
            x.Tanim = ex.Message;
        }
    }
    public static void KapakResimKaydet(string resimadi, int? KullaniciID)
    {
        ResultModel x = new ResultModel();
        try
        {
            using (SqlConnection con = new SqlConnection(Guvenlik.ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("kl_ArkaPlanResmiGuncelle", con))
                {
                    cmd.CommandTimeout = (60 * 60);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID", KullaniciID);
                    cmd.Parameters.AddWithValue("@Resim", string.IsNullOrEmpty(resimadi) ? (object)DBNull.Value : resimadi);

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                        //SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            string queryResult = dr["Sonuc"].ToString();

                            if (queryResult == "1")
                            {
                                x.Code = 56;
                                x.Tanim = "İşleminiz başarıyla gerçekleştirildi.";
                            }
                            else
                            {
                                x.Code = 57;
                                x.Tanim = queryResult;
                            }
                        }
                }
            }
        }
        catch (Exception ex)
        {
            x.Code = 57;
            x.Tanim = ex.Message;
        }
    }

    public static ResultModel DuvarınaYaz(Yorumlar yorumModel)
    {
        ResultModel x = new ResultModel();
        try
        {
            using (SqlConnection con = new SqlConnection(Guvenlik.ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("kl_YeniYorumEkle", con))
                {
                    cmd.CommandTimeout = (60 * 60);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@KullaniciID", (yorumModel.Kullanici_ID == null || yorumModel.Kullanici_ID == 0) ? (object)DBNull.Value : yorumModel.Kullanici_ID);
                    cmd.Parameters.AddWithValue("@Yorum", string.IsNullOrEmpty(yorumModel.Yorum) ? (object)DBNull.Value : yorumModel.Yorum);


                    if (con.State != ConnectionState.Open)
                        con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            string queryResult = dr["Result"].ToString();

                            if (queryResult == "1")
                            {
                                x.Code = 1;
                                x.Tanim = "İşleminiz başarıyla gerçekleştirildi.";
                            }
                            else
                            {
                                x.Code = 0;
                                x.Tanim = "Bu E-Mail adresinde kayıt mevcuttur.Lütfen farklı bir e-mail adresi giriniz!";
                            }
                        }
                    }
                }
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