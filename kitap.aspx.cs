using KitapBilgileriModel;
using KullanicilarModel;
using KutuphaneModel;
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

public partial class kitap : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                Kullanicilar kullaniciObject = Session["kullaniciObject"] as Kullanicilar;
                lblkitaptüridpop.InnerText = Convert.ToInt32(Request.QueryString["id"]).ToString();
                lblKullaniciID.InnerText = kullaniciObject.ID.ToString();
                lblKullanici_ID.InnerText = kullaniciObject.ID.ToString();
                lblKitap_ID.InnerText = Convert.ToInt32(Request.QueryString["id"]).ToString();

                if (kullaniciObject == null)
                    Response.Redirect("anasayfa.aspx");
            }
            catch
            {
                Response.Redirect("anasayfa.aspx");
            }
        }

    }

    [WebMethod]
    [ScriptMethod]
    public static Tuple<ResultModel, int, string, string> KitapBilgileri(int? KitapID)
    {
        Tuple<ResultModel, int, List<KitapBilgileri>, ICollection<Kullanicilar>> result =
        KullaniciBLL.KitapBilgileri(KitapID);

        StringBuilder str = new StringBuilder();
        StringBuilder str1 = new StringBuilder();

        foreach (KitapBilgileri item in result.Item3)
        {
            str.Append(
                 "<div class=\"arkaPlan\">" +
                "<div class=\"arkaPlan2\">" +
      "<img src = \"images/" + item.KitapResmi + "\" style=\"width: 100%; height: 100%; background-position: center\" />" +
                "</div>" +
                "<div class=\"arkaPlan3\"></div>" +
            "</div>" +
            "<div class=\"container\">" +
                    "<div class=\"resim\">" +
                    "<img src =\"images/" + item.KitapResmi + "\" />" +
                "</div>" +
                "<div class=\"kitapadi\">" +
                    "<h1>" + item.KitapAdi + "</h1>" +
                    "<div class=\"yazar\">" +
                        "<h4>" + item.KitapYazari + "</h4>" +
                    "</div>" +
                "</div>" +
            "</div>" +
              "<div id =\"ToplamOySayisi\">" + item.BegenenKisiSayisi + "</div>");

        }
        if (result.Item1.Code == 1)
        {
            foreach (Kullanicilar item in result.Item4)
            {
                str1.Append(
                    "<div class=\"yorum\">" +
                        "<div class=\"ust-baslik\">" +
                            "<div class=\"resim\">" +
                              "<a href = \"profil.aspx?i=" + item.ID + "\" >" +
           /*Profil Resmi*/   "<img src = \"images/" + item.profil.ProfilResmi + "\" style = \"width: 100%; height: 100%; background-position: center\" />" + "</a>" +
                           "</div>" +
                            "<div class=\"yazi\">" +
                                "<h3 class=\"okur-adi\">" + item.Ad_Soyad + "</h3>" +
                            "</div>" +
                        "</div>" +
                        "<div class=\"bosluk\"></div>" +
                        "<div class=\"icerik\">" +
                            "<div>" + item.yorum.Yorum + "</div>" +
                        "</div>" +
                        "<div style = \"margin-bottom: 10px; margin-top: 0px;\" ></ div >" +
                  "</div></div>");
            }
        }
        return new Tuple<ResultModel, int, string, string>(result.Item1, result.Item2, str.ToString(), str1.ToString());
    }

    [WebMethod]
    [ScriptMethod]
    public static Tuple<ResultModel, string, string> KitapBasimBilgileri(int? KitapID)
    {
        Tuple<ResultModel,List<KitapBilgileri>, ICollection<Kullanicilar>> result =
        KullaniciBLL.KitapBasimBilgileri(KitapID);

        StringBuilder str = new StringBuilder();
        StringBuilder str1 = new StringBuilder();
       
        if (result.Item1.Code == 1)
        {
            foreach (KitapBilgileri item in result.Item2)
            {
                str.Append(
                     "<div class=\"oge onlyDesktop\">" +
                                "<div class=\"kutu-baslik\">Adı:</div>" +
                                "<div class=\"bilgi\">" + item.KitapAdi + "</div>" +
                            "</div>" +
                            "<div class=\"oge onlyDesktop\">" +
                                "<div class=\"kutu-baslik\">Yazar:</div>" +
                                "<div class=\"bilgi\">" + item.KitapYazari + "</div>" +
                            "</div>" +
                            "<div class=\"oge\">" +
                                "<div class=\"kutu-baslik\">Baskı Tarihi:</div>" +
                                "<div class=\"bilgi\">" + item.BasimTarihi + "</div>" +
                            "</div>" +
                            "<div class=\"oge\">" +
                                "<div class=\"kutu-baslik\">Sayfa Sayısı:</div>" +
                                "<div class=\"bilgi\">" + item.SayfaSayisi + "</div>" +
                            "</div>" +
                            "<div class=\"oge\">" +
                                "<div class=\"kutu-baslik\">ISBN:</div>" +
                                "<div class=\"bilgi\">" + item.ISBN + "</div>" +
                            "</div>" +
                            "<div class=\"oge\">" +
                                "<div class=\"kutu-baslik\">Kitap Türü:</div>" +
                                "<div class=\"bilgi\">" + item.kitaplar.KitapTürü + "</div>" +
                            "</div>" +
                            "<div class=\"oge\">" +
                                "<div class=\"kutu-baslik\">Dil:</div>" +
                                "<div class=\"bilgi\">" + item.Dil + "</div>" +
                            "</div>" +
                            "<div class=\"oge\">" +
                                "<div class=\"kutu-baslik\">Ülke:</div>" +
                                "<div class=\"bilgi\">" + item.Ulke + "</div>" +
                            "</div>" +
                            "<div class=\"oge\">" +
                                "<div class=\"kutu-baslik\">Yayınevi:</div>" +
                                "<div class=\"bilgi\">" + item.YayınEvi + "</div>" +
                            "</div>" +
                            "<div class=\"oge metin\">" +
                                "<div class=\"\" style=\"width: 100%;\">" +
                                    "<div class=\"\" style=\"max-height: 210px; overflow: hidden;\">" +
                                        "<div>" + item.KitapHakkinda + "</div>" +
                                    "</div>" +
                                    "<div></div>" +
                                "</div>" +
                            "</div>");

            }
            foreach (Kullanicilar item in result.Item3)
            {
                str1.Append(
                                "<li>"+
                                    "<div class=\"resim\">"+
                                        "<a href=\"profil.aspx?i="+item.ID+"\">" +
                                            "<img class=\"img-circle\" src =\"images/"+item.profil.ProfilResmi+"\" title="+item.Ad_Soyad+" />"+
                                        "</a>"+
                                    "</div>"+
                                "</li>");


            }
        }
        return new Tuple<ResultModel, string, string>(result.Item1, str.ToString(), str1.ToString());
    }

   

    [WebMethod]
    [ScriptMethod]
    public static ResultModel YeniYorumEkle(Yorumlar yorumModel)
    {

        ResultModel x = new ResultModel();
        return x = KullaniciBLL.YeniYorumEkle(yorumModel);
    }

    [WebMethod]
    [ScriptMethod]
    public static ResultModel OyBegendim(int? OySayisi, int? KitapID)
    {

        ResultModel x = new ResultModel();
        return x = KullaniciBLL.OyBegendim(OySayisi, KitapID);
    }
    [WebMethod]
    [ScriptMethod]
    public static ResultModel OyBegenmedim(int? OySayisi, int? KitapID)
    {

        ResultModel x = new ResultModel();
        return x = KullaniciBLL.OyBegenmedim(OySayisi, KitapID);
    }
    [WebMethod]
    [ScriptMethod]
    public static ResultModel OkuyacaklarimaEkle(int? KitapID)
    {
        Kullanicilar kullaniciObject = new Kullanicilar();
        kullaniciObject = HttpContext.Current.Session["kullaniciObject"] as Kullanicilar;
        int KullaniciID = kullaniciObject.ID;
        //int KullaniciID = 1;

        ResultModel x = new ResultModel();
        return x = KullaniciBLL.OkuyacaklarimaEkle(KitapID, KullaniciID);
    }
}