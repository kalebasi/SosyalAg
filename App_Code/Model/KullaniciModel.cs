
/// <summary>
/// Summary description for KullaniciModel
/// </summary>
namespace KullaniciModel
{
    using System;

    [Serializable]
  public class BayiYetkili
  {
    public BayiYetkili()
    {

    }
    public int ID { get; set; }
    public int BayiKodu { get; set; }
    public bool Durum { get; set; }
    public int SirketID { get; set; }
    private string _AdSoyad;
    public string AdSoyad
    {
      get { return _AdSoyad; }
      set
      { _AdSoyad = Guvenlik.Char39Replace(value); }
    }
    private string _Email;
    public string Email
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
          throw new Exception("Hatalı bir email adresi girdiniz!");
        }
      }
    }
    private string _KullaniciAdi;
    public string KullaniciAdi
    {
      get { return _KullaniciAdi; }
      set
      { _KullaniciAdi = Guvenlik.Char39Replace(value); }
    }
    private string _Parola;
    public string Parola
    {
      get { return _Parola; }
      set
      { _Parola = Guvenlik.Char39Replace(value); }
    }
    private string _IpAdress;
    public string IpAdress
    {
      get { return _IpAdress; }
      set
      { _IpAdress = Guvenlik.Char39Replace(value); }
    }

    private string _SessionId;
    public string SessionId
    {
      get { return _SessionId; }
      set
      { _SessionId = Guvenlik.Char39Replace(value); }
    }
    public int KullaniciTurID { get; set; }
    public Nullable<bool> AktifMi { get; set; }
    private string _MusteriSayfasi;
    public string MusteriSayfasi
    {
      get { return _MusteriSayfasi; }
      set
      { _MusteriSayfasi = Guvenlik.Char39Replace(value); }
    }
    [Serializable]
    public class AramaKriterleri
    {
      public Nullable<int> sayfa { get; set; }
      public Nullable<int> sayfaBasiKayitSayisi { get; set; }
    }

    public virtual SonucModel.ResultModel Result { get; set; }
  }

  [Serializable]
  public partial class Kullanici
  {

    public Kullanici()
    {
      this.KullaniciTurleri = new KullaniciTurleri();
      this.KullaniciSantralAyar = new KullaniciSantralAyarlari();
    }

    public int ID { get; set; }
    public int? UstKullaniciID { get; set; }
    public bool Kilitli { get; set; }
    public bool SenaryoDurum { get; set; }

    public int? BeklemeSuresi { get; set; }
    public int BayiKodu { get; set; }
    public int SirketID { get; set; }
    private string _AdiSoyadi;
    public string AdiSoyadi
    {
      get { return _AdiSoyadi; }
      set
      { _AdiSoyadi = Guvenlik.Char39Replace(value); }
    }
    private string _Unvan;
    public string Unvan
    {
      get { return _Unvan; }
      set
      { _Unvan = Guvenlik.Char39Replace(value); }
    }
    private string _MusteriSayfasi;
    public string MusteriSayfasi
    {
      get { return _MusteriSayfasi; }
      set
      { _MusteriSayfasi = Guvenlik.Char39Replace(value); }
    }
    private string _SesKaydiAdresi;
    public string SesKaydiAdresi
    {
      get { return _SesKaydiAdresi; }
      set
      { _SesKaydiAdresi = Guvenlik.Char39Replace(value); }
    }
    private string _KullaniciAdi;
    public string KullaniciAdi
    {
      get { return _KullaniciAdi; }
      set
      { _KullaniciAdi = Guvenlik.Char39Replace(value); }
    }
    private string _Parola;
    public string Parola
    {
      get { return _Parola; }
      set
      { _Parola = Guvenlik.Char39Replace(value); }
    }


    public bool Durum { get; set; }
    public int KullaniciTurID { get; set; }

    private string _Email;
    public string Email
    {
      get { return _Email; }
      set
      {
        try
        {
          if (!string.IsNullOrEmpty(value))
          {
            System.Net.Mail.MailAddress m = new System.Net.Mail.MailAddress(value);
            _Email = value;
          }
        }
        catch
        {
          _Email = "";
        }
      }
    }
    public int GrupID { get; set; }
    public int SirketTelefonID { get; set; }

    //Login olan kullanıcılarda Ip değeri atanacak...
    private string _IpAdress;
    public string IpAdress
    {
      get { return _IpAdress; }
      set
      { _IpAdress = Guvenlik.Char39Replace(value); }
    }

    private string _SessionId;
    public string SessionId
    {
      get { return _SessionId; }
      set
      { _SessionId = Guvenlik.Char39Replace(value); }
    }
    public virtual TelefonGruplari TelefonGrubu { get; set; }


    [Serializable]
    public class AramaKriterleri
    {
      public Nullable<int> sayfa { get; set; }
      public Nullable<int> sayfaBasiKayitSayisi { get; set; }
      public Nullable<int> UstKullaniciID { get; set; }
      public int? KullaniciID { get; set; }
      public int? KullaniciTurID { get; set; }
      public string KullaniciTurFiltre { get; set; }
      public bool? durum { get; set; }
      public int? BayiKodu { get; set; }
      public string GrupID { get; set; }
      public bool? santral { get; set; }
      private string _aranacakKelime;
      public string aranacakKelime
      {
        get { return _aranacakKelime; }
        set
        { _aranacakKelime = Guvenlik.Char39Replace(value); }
      }
      public int? SirketID { get; set; }
      public string KapanmaTarih1 { get; set; }
      public string KapanmaTarih2 { get; set; }
    }

    public virtual SonucModel.ResultModel Result { get; set; }
    public virtual KullaniciTurleri KullaniciTurleri { get; set; }

    public virtual KullaniciSantralAyarlari KullaniciSantralAyar { get; set; }
    public string TcKimlikNo { get; set; }
    public string DogumTarihi { get; set; }
    public int Cinsiyet { get; set; }
    public int? EbordroDepartmanID { get; set; }
    public int? EbordroSirketID { get; set; }
    public int? ChatSirketID { get; set; }
    public string ChatDepartmanID { get; set; }
  }

  [Serializable]
  public partial class KullaniciTurleri
  {
    public KullaniciTurleri()
    {
    }

    public int ID { get; set; }
    private string _TurAdi;
    public string TurAdi
    {
      get { return _TurAdi; }
      set
      { _TurAdi = Guvenlik.Char39Replace(value); }
    }

    public bool Durum { get; set; }

    private string _SatirNo;
    public string SatirNo
    {
      get { return _SatirNo; }
      set
      { _SatirNo = Guvenlik.Char39Replace(value); }
    }


    [Serializable]
    public class AramaKriterleri
    {
      public Nullable<int> sayfa { get; set; }
      public Nullable<int> sayfaBasiKayitSayisi { get; set; }
      public Nullable<bool> durum { get; set; }
      private string _aranacakKelime;
      public string aranacakKelime
      {
        get { return _aranacakKelime; }
        set
        { _aranacakKelime = Guvenlik.Char39Replace(value); }
      }
    }

    //  public virtual ResultModel Result { get; set; }
  }

  [Serializable]
  public partial class KullaniciSistemAyarlari
  {
    public KullaniciSistemAyarlari()
    {
    }

    public int ID { get; set; }
    public int KullaniciID { get; set; }
    public Nullable<int> SmsKullaniciID { get; set; }
    public Nullable<int> SmsHesapID { get; set; }
    private string _SmsKullaniciAdi;
    public string SmsKullaniciAdi
    {
      get { return _SmsKullaniciAdi; }
      set
      { _SmsKullaniciAdi = Guvenlik.Char39Replace(value); }
    }
    private string _SmsParola;
    public string SmsParola
    {
      get { return _SmsParola; }
      set
      { _SmsParola = Guvenlik.Char39Replace(value); }
    }
    private string _SmsAlfanumerikAdi;
    public string SmsAlfanumerikAdi
    {
      get { return _SmsAlfanumerikAdi; }
      set
      { _SmsAlfanumerikAdi = Guvenlik.Char39Replace(value); }
    }
    [Serializable]
    public class AramaKriterleri
    {
      public Nullable<int> sayfa { get; set; }
      public Nullable<int> sayfaBasiKayitSayisi { get; set; }
      public Nullable<bool> durum { get; set; }
      private string _aranacakKelime;
      public string aranacakKelime
      {
        get { return _aranacakKelime; }
        set
        { _aranacakKelime = Guvenlik.Char39Replace(value); }
      }
    }
  }
  [Serializable]
  public partial class KullaniciAyarlari
  {
    public string SonAktifOlmaZamani { get; set; }
    public bool? DuraklatilmisMi { get; set; }
    public bool? AcikMi { get; set; }
    public bool? MoladaMi { get; set; }
    public int? Fark { get; set; }
    public int? BeklemeSuresi { get; set; }
  }
  [Serializable]
  public partial class KullaniciSantralAyarlari
  {
    public KullaniciSantralAyarlari()
    {
    }
    private string _Result;
    public string Result
    {
      get { return _Result; }
      set
      { _Result = Guvenlik.Char39Replace(value); }
    }
    public int ID { get; set; }
    public int KullaniciID { get; set; }
    private string _UserName;
    public string UserName
    {
      get { return _UserName; }
      set
      { _UserName = Guvenlik.Char39Replace(value); }
    }
    private string _Password;
    public string Password
    {
      get { return _Password; }
      set
      { _Password = Guvenlik.Char39Replace(value); }
    }
    private string _Domain;
    public string Domain
    {
      get { return _Domain; }
      set
      { _Domain = Guvenlik.Char39Replace(value); }
    }
    public int TotalLines { get; set; }
    private string _SesGirisID;
    public string SesGirisID
    {
      get { return _SesGirisID; }
      set
      { _SesGirisID = Guvenlik.Char39Replace(value); }
    }
    private string _SesCikisID;
    public string SesCikisID
    {
      get { return _SesCikisID; }
      set
      { _SesCikisID = Guvenlik.Char39Replace(value); }
    }
    private string _SonAktifOlmaZamani;
    public string SonAktifOlmaZamani
    {
      get { return _SonAktifOlmaZamani; }
      set
      { _SonAktifOlmaZamani = Guvenlik.Char39Replace(value); }
    }
    public int SesCikisSeviyesi { get; set; }
    public int SesGirisSeviyesi { get; set; }

    public bool? DuraklatilmisMi { get; set; }
    public bool? AcikMi { get; set; }
    public bool? MoladaMi { get; set; }
    public int Fark { get; set; }
    public int? BeklemeSuresi { get; set; }
    [Serializable]
    public class AramaKriterleri
    {
      public Nullable<int> sayfa { get; set; }
      public Nullable<int> sayfaBasiKayitSayisi { get; set; }
      private string _aranacakKelime;
      public string aranacakKelime
      {
        get { return _aranacakKelime; }
        set
        { _aranacakKelime = Guvenlik.Char39Replace(value); }
      }
    }
  }


  [Serializable]
  public class KullaniciSifreleri
  {
    public int ID { get; set; }
    public int KullaniciID { get; set; }
    public string Parola { get; set; }
    public DateTime EklenmeTarihi { get; set; }

  }

  [Serializable]
  public class TelefonGruplari
  {
    public TelefonGruplari()
    {
    }
    public int ID { get; set; }
    public string Adi { get; set; }
    public int SirketID { get; set; }
    public int ToplamTelefonSayisi { get; set; }
    public int ToplamKullaniciSayisi { get; set; }
    public string Telefon { get; set; }
    public bool Durum { get; set; }

    public class AramaKriterleri
    {
      public int? BayiKodu { get; set; }
      public int? ID { get; set; }
      public int? SirketID { get; set; }
      public int? sayfa { get; set; }
      public int? sayfaBasiKayitSayisi { get; set; }
      public string aranacakKelime { get; set; }
      public int? Durum { get; set; }
    }

  }


  [Serializable]
  public class SistemBilgisi
  {
    public int Result { get; set; }
    public int ID { get; set; }
    public int KullaniciID { get; set; }
    public double SistemSurumu { get; set; }
    public string Title { get; set; }
    public string Link { get; set; }
    public string Description { get; set; }
    public string Keywords { get; set; }
    public string GoogleAnalytics { get; set; }
    public bool Durum { get; set; }
  }


}