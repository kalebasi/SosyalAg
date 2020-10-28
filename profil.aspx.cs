using KitapBilgileriModel;
using KullanicilarModel;
using ProfilModel;
using SonucModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using YorumlarModel;

public partial class profil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                Kullanicilar kullaniciObject = Session["kullaniciObject"] as Kullanicilar;
                if (kullaniciObject == null)
                    Response.Redirect("login.aspx");
            }
            catch
            {
                Response.Redirect("login.aspx");
            }
        }
    }

    [ScriptMethod]
    [WebMethod]
    public static Tuple<ResultModel, string, string> ProfilBilgileri(int? KullaniciID)
    {
        Tuple<ResultModel, List<Profil>> result = KullaniciBLL.ProfilBilgileri(KullaniciID);

        StringBuilder str = new StringBuilder();
        StringBuilder str1 = new StringBuilder();
        if (result.Item1.Code == 1)
        {
            foreach (Profil item in result.Item2)
            {
                str.Append(
              "<div class=\"kullanici-adi\">" +
                      "<h1>" + item.kullanici.Ad_Soyad + "</h1>" +
                  "</div>" +
                  "<div class=\"kisisel-bilgiler\">" +
                         "<div class=\"bilgiler\">" +
                             "<div class=\"ikon\">" +
                                 "<span class=\"fas fa-map-marker-alt\"></span>" +
                             "</div>" +
                             "<div class=\"bilgi\">" +
                                 "<h4>" + item.YasadigiYer + "'da yaşıyor.</h4>" +
                             "</div>" +
                         "</div>" +
                         "<div class=\"bilgiler\">" +
                             "<div class=\"ikon\">" +
                                 "<span class=\"fas fa-home blue\"></span>" +
                             "</div>" +
                             "<div class=\"bilgi\">" +
                                 "<h4>Memleketi " + item.Memleket + "</h4>" +
                             "</div>" +
                         "</div>" +
                         "<div class=\"bilgiler\">" +
                             "<div class=\"ikon\">" +
                                 "<span class=\"fas fa-birthday-cake\"></span>" +
                             "</div>" +
                             "<div class=\"bilgi\">" +
                                 "<h4>" + item.DogumTarihi + "</h4>" +
                             "</div>" +
                         "</div>" +
                         "<div class=\"bilgiler\">" +
                             "<div class=\"ikon\">" +
                                 "<span class=\"fas fa-transgender\"></span>" +
                             "</div>" +
                             "<div class=\"bilgi\">" +
                                 "<h4>" + item.Cinsiyet + "</h4>" +
                           "</div>" +
                         "</div>" +
                    //  "<div class=\"profil-btn\">" +
                    //      "<div class=\"btn-group\" role=\"group\">" +
                    //"<a href=\"#\" id=\"profilduzenle\" onclick=\"btnclick()\" class=\"btn btn-danger\" data-toggle=\"modal\" data-target=\"#exampleModal\" data-whatever=\"@getbootstrap\">PROFİLİMİ DÜZENLE</a>" +
                    //      "</div>" +
                    //      "<div class=\"btn-group\" role=\"group\">" +
                    //         "<button class=\"fas fa-camera camera-profil\" type=\"button\"  data-toggle=\"modal\" data-target=\"#exampleModalProfil\" data-whatever=\"@getbootstrap\">" +
                    //         "</button>" +
                    //      "</div>" +
                    //  "</div>" +
                    "</div>");
            }
            foreach (Profil item in result.Item2)
            {
                str1.Append(
                    "<div class=\"kapak\">" +
/*KAPAK FOTOĞRAFI*/ "<img src = \"images/" + item.ArkaPlanResmi + "\" />" +
               "</div>" +
               //"<div class=\"camera\">" +
               //    "<button class=\"fas fa-camera camera-kapak\" data-toggle=\"modal\" data-target=\"#exampleModalKapak\" data-whatever=\"@getbootstrap\"></button>" +
               //"</div>" +
               "<div class=\"ust\">" +
                   "<div class=\"container\">" +
                       "<div class=\"resim\">" +
    /*Profil Resmi*/    "<img src = \"images/" + item.ProfilResmi + "\" />" +
                       "</div>" +
                           "<div class=\"menu\">" +
                          "<div class=\"menu-1k sayili\">" +
                          "<div>" +
                          "<a id=\"MenuDuvarim\" onclick=\"ProfilYorumlari()\"> Duvar </a >" +
                          "</div >" +
                              "<div>" +
                              "<a id=\"MenuOkuyacaklarim\" onclick=\"MenuOkuyacaklarimiGetir()\"> Okuyacakları</a>" +
                              "</div>" +
                              "<div>" +
                          "<a id=\"MenuOkumaktaOlduklarim\" onclick=\"MenuOkumaktaOlduklarimiGetir()\"> Okumakta Oldukları </a>" +
                              "</div>" +
                              "<div>" +
                              "<a id=\"MenuOkuduklarim\" onclick=\"MenuOkuduklarimiGetir()\">Okudukları</a>" +
                              "</div>" +
                            //"<div>" +
                            //"<a id=\"MenuKutuphanem\" onclick=\"MenuKutuphanemiGetir()\"> Kütüphanem </a>" +
                            //"</div >" +
                            " </div >" +
                      "</div>" +
                      "</div>" +
               "</div>");
            }
        }
        return new Tuple<ResultModel, string, string>(result.Item1, str.ToString(), str1.ToString());
    }
    [WebMethod]
    [ScriptMethod]
    public static Tuple<ResultModel, string> ProfilYorumlari(int? KullaniciID)
    {
        Tuple<ResultModel, int, List<Yorumlar>> result = KullaniciBLL.ProfilYorumlari(KullaniciID);

        StringBuilder str = new StringBuilder();

        if (result.Item1.Code == 1)
        {
            foreach (Yorumlar item in result.Item3)
            {
                str.Append(
                     "<div class=\"yorum\">" +
                        "<div class=\"ust-baslik\">" +
                           "<div class=\"resim\">" +
          /*Profil Resmi*/   "<img src = \"images/" + item.profil.ProfilResmi + "\" style=\"width: 100%; height: 100%;\" />" +
                             "</div>" +
                            "<div class=\"yazi\">" +
                              "<h3 class=\"okur-adi\">" + item.kullanici.Ad_Soyad + "</h3>" +
                               "</div>" +
                             "</div>" +
                           "<div class=\"icerik\">" +
                              "<div>" + item.Yorum + "</div>" +
                             "</div>" +
                           "<div class=\"kitap-yorum\">" +
                              "<div class=\"resim\">" +
                                "<a href = \"kitap.aspx?id=" + item.kitapBilgileri.ID + "\">" +
                /*Kitap Resmi*/  "<img src=\"images/" + item.kitapBilgileri.KitapResmi + "\" style=\"width: 100%; height: 100%;\"/>" +
                               "</a>" +
                                   "</div>" +
                                "<div class=\"kitap-hakkinda\">" +
                                    "<div class=\"adi\">" +
                                      "<span class=\"kitap_yazar_adi\">" + item.kitapBilgileri.KitapAdi + "," + item.kitapBilgileri.KitapYazari + "</span>" +
                                   "</div>" +
                                "</div>" +
                              "</div>" +
                           "<div style = \"margin-bottom: 10px; margin-top: 0px;\" ></ div >" +
                            "</div></div>");
            }
        }
        return new Tuple<ResultModel, string>(result.Item1, str.ToString());
    }

    [WebMethod]
    [ScriptMethod]
    public static Tuple<ResultModel, Profil> ProfilBilgilerimiGetirPopUp(int? KullaniciID)
    {
        Tuple<ResultModel, Profil> result = KullaniciBLL.ProfilBilgilerimiGetirPopUp(KullaniciID);

        return new Tuple<ResultModel, Profil>(result.Item1, result.Item2);
    }

    [WebMethod]
    [ScriptMethod]
    public static ResultModel ProfilBilgilerimiGuncelle(Profil profilModel)
    {
        ResultModel x = new ResultModel();
        return x = KullaniciBLL.ProfilBilgilerimiGuncelle(profilModel);
    }

    [WebMethod]
    [ScriptMethod]
    public static Tuple<ResultModel, string> MenuOkuyacaklarimiGetir(int? KullaniciID)
    {
        Tuple<ResultModel, int, List<KitapBilgileri>> result = KullaniciBLL.MenuOkuyacaklarimiGetir(KullaniciID);

        StringBuilder str = new StringBuilder();

        if (result.Item1.Code == 1)
        {
            int sira = 1;
            foreach (KitapBilgileri item in result.Item3)
            {
                str.Append(
                          "<div class=\"kutu\" style=\"width: 540px;\">" +
                                "<ul class=\"kitaplar sirali lg altAlta liste\">" +
                                 //"<div class=\"btn btnSil\" id=\"" + item.ID + "\" onclick=\"KitapSil()\"> X</div>" +
                                 "<li class=\"kitap butonlu\">" +
                                        "<div class=\"resim\">" +
                                             "<img src = \"images/" + item.KitapResmi + "\" />" +
                                        "</div>" +
                                        "<div class=\"sira\">" + sira++ + "</div>" +
                                        //"<div id =\"lblKitapID\" style=\"display:none;\">" + item.ID+"</div>"+
                                        "<div class=\"kitap-adi\">" + item.KitapAdi + "</div>" +
                                        "<div class=\"bilgi\">" + item.KitapYazari + "</div>" +
                                        "<div class=\"bilgi ekBilgi\">" +
                                            "<div class=\"btn-group\">" +
                                                "<button type =\"button\" class=\"btn btn-danger dropdown-toggle\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\" style=\"width: 120px; border-radius: 5px;\">" +
                                                "<span class=\"durum\"> OKUYACAĞIM</span>" +
                                                //"<span class=\"caret\"></span>" +
                                                "</button>" +
                                            //                            "<ul class=\"dropdown-menu\">" +
                                            //                                "<li>" +
                                            //"<a id =\"" + item.ID + "\" onclick=\"DropdownOkuyacaklarimaEkle()\">Okuyacağım</a>" +
                                            //                                "</li>" +
                                            //                                "<li>" +
                                            //"<a  id =\"" + item.ID + "\" onclick=\"DropdownOkumaktaOlduklarimaEkle()\"> Okuyorum </a>" +
                                            //                                "</li>" +
                                            //                                "<li>" +
                                            //"<a  id =\"" + item.ID + "\" onclick=\"DropdownOkuduklarimaEkle()\"> Okudum </a>" +
                                            //                                "</li>" +
                                            //                                "<li role =\"separator\" class=\"divider\"></li>" +
                                            //                                "<li>" +
                                            //"<a id=\"" + item.ID + "\" onclick=\"DropdownKutuphanemeEkle()\"> Kütüphaneye Ekle</a>" +
                                            //                                 "</li>" +
                                            //                            "</ul>" +
                                            "</div>" +
                                        "</div>" +
                                    "</li>" +
                                "</ul>" +
                            "</div>");

            }
        }
        return new Tuple<ResultModel, string>(result.Item1, str.ToString());
    }

    [WebMethod]
    [ScriptMethod]
    public static Tuple<ResultModel, string> MenuOkumaktaOlduklarimiGetir(int? KullaniciID)
    {
        Tuple<ResultModel, int, List<KitapBilgileri>> result = KullaniciBLL.MenuOkumaktaOlduklarimiGetir(KullaniciID);

        StringBuilder str = new StringBuilder();

        if (result.Item1.Code == 1)
        {
            int sira = 1;
            foreach (KitapBilgileri item in result.Item3)
            {
                str.Append(
                          "<div class=\"kutu\" style=\"width: 540px;\">" +
                                "<ul class=\"kitaplar sirali lg altAlta liste\">" +
                                    //"<div class=\"btn btnSil\" id=\"" + item.ID + "\" onclick=\"KitapSil()\"> X</div>" +
                                    "<li class=\"kitap butonlu\">" +
                                        "<div class=\"resim\">" +
                                             "<img src = \"images/" + item.KitapResmi + "\" />" +
                                        "</div>" +
                                        "<div class=\"sira\">" + sira++ + "</div>" +
                                        //"<div id =\"lblKitapID\" style=\"display:none;\">" + item.ID + "</div>" +
                                        "<div class=\"kitap-adi\">" + item.KitapAdi + "</div>" +
                                        "<div class=\"bilgi\">" + item.KitapYazari + "</div>" +
                                        "<div class=\"bilgi ekBilgi\">" +
                                            "<div class=\"btn-group\">" +
                                                "<button type =\"button\" class=\"btn btn-danger dropdown-toggle\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\" style=\"width: 120px; border-radius: 5px;\">" +
                                                "<span class=\"durum\"> OKUYORUM</span>" +
                                                //"<span class=\"caret\"></span>" +
                                                "</button>" +
                                                      //                              "<ul class=\"dropdown-menu\">" +
                                                      //                                  "<li>" +
                                                      //"<a  id =\"" + item.ID + "\" onclick=\"DropdownOkuyacaklarimaEkle()\">Okuyacağım</a>" +
                                                      //                                  "</li>" +
                                                      //                                  "<li>" +
                                                      //"<a  id =\"" + item.ID + "\" onclick=\"DropdownOkumaktaOlduklarimaEkle()\"> Okuyorum </a>" +
                                                      //                                  "</li>" +
                                                      //                                  "<li>" +
                                                      //"<a  id =\"" + item.ID + "\" onclick=\"DropdownOkuduklarimaEkle()\"> Okudum </a>" +
                                                      //                                  "</li>" +
                                                      //                                  "<li role =\"separator\" class=\"divider\"></li>" +
                                                      //                                  "<li>" +
                                                      //"<a id=\"" + item.ID + "\" onclick=\"DropdownKutuphanemeEkle()\"> Kütüphaneye Ekle</a>" +
                                                      //                                   "</li>" +
                                                      //                              "</ul>" +
                                                      "</div>" +
                                                  "</div>" +
                                              "</li>" +
                                          "</ul>" +
                            "</div>");

            }
        }
        return new Tuple<ResultModel, string>(result.Item1, str.ToString());
    }

    [WebMethod]
    [ScriptMethod]
    public static Tuple<ResultModel, string> MenuOkuduklarimiGetir(int? KullaniciID)
    {


        Tuple<ResultModel, int, List<KitapBilgileri>> result = KullaniciBLL.MenuOkuduklarimiGetir(KullaniciID);

        StringBuilder str = new StringBuilder();

        if (result.Item1.Code == 1)
        {
            int sira = 1;
            foreach (KitapBilgileri item in result.Item3)
            {
                str.Append(
                          "<div class=\"kutu\" style=\"width: 540px;\">" +
                                "<ul class=\"kitaplar sirali lg altAlta liste\">" +
                                    //"<div class=\"btn btnSil\" id=\"" + item.ID + "\" onclick=\"KitapSil()\"> X</div>" +
                                    "<li class=\"kitap butonlu\">" +
                                        "<div class=\"resim\">" +
                                             "<img src = \"images/" + item.KitapResmi + "\" />" +
                                        "</div>" +
                                        "<div class=\"sira\">" + sira++ + "</div>" +
                                        //"<div id =\"lblKitapID\" style=\"display:none;\">" + item.ID + "</div>" +
                                        "<div class=\"kitap-adi\">" + item.KitapAdi + "</div>" +
                                        "<div class=\"bilgi\">" + item.KitapYazari + "</div>" +
                                        "<div class=\"bilgi ekBilgi\">" +
                                            "<div class=\"btn-group\">" +
                                                "<button type =\"button\" class=\"btn btn-danger dropdown-toggle\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\" style=\"width: 120px; border-radius: 5px;\">" +
                                                "<span class=\"durum\"> OKUDUM</span>" +
                                                //"<span class=\"caret\"></span>" +
                                                "</button>" +
                                                      //                              "<ul class=\"dropdown-menu\">" +
                                                      //                                  "<li>" +
                                                      //"<a  id =\"" + item.ID + "\" onclick=\"DropdownOkuyacaklarimaEkle()\">Okuyacağım</a>" +
                                                      //                                  "</li>" +
                                                      //                                  "<li>" +
                                                      //"<a  id =\"" + item.ID + "\" onclick=\"DropdownOkumaktaOlduklarimaEkle()\"> Okuyorum </a>" +
                                                      //                                  "</li>" +
                                                      //                                  "<li>" +
                                                      //"<a  id =\"" + item.ID + "\" onclick=\"DropdownOkuduklarimaEkle()\"> Okudum </a>" +
                                                      //                                  "</li>" +
                                                      //                                  "<li role =\"separator\" class=\"divider\"></li>" +
                                                      //                                  "<li>" +
                                                      //"<a id=\"" + item.ID + "\" onclick=\"DropdownKutuphanemeEkle()\"> Kütüphaneye Ekle</a>" +
                                                      //                                   "</li>" +
                                                      //                              "</ul>" +
                                                      "</div>" +
                                                  "</div>" +
                                              "</li>" +
                                          "</ul>" +
                            "</div>");

            }
        }
        return new Tuple<ResultModel, string>(result.Item1, str.ToString());
    }

    [WebMethod]
    [ScriptMethod]
    public static ResultModel DuvarınaYaz(Yorumlar yorumModel)
    {
        ResultModel x = new ResultModel();
        return x = KullaniciBLL.DuvarınaYaz(yorumModel);
    }
}