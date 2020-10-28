using KitapBilgileriModel;
using KullanicilarModel;
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

public partial class anasayfa : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    [WebMethod]
    [ScriptMethod]
    public static Tuple<ResultModel, int, string> AnasayfaKitapListele()
    {
        Tuple<ResultModel, int, ICollection<KitapBilgileri>> result =
        KullaniciBLL.AnasayfaKitapListele();


        StringBuilder str = new StringBuilder();

        if (result.Item1.Code == 56)
        {
            foreach (KitapBilgileri item in result.Item3)
            {
                str.Append(
                     "<div class=\"col-lg-4\">" +
 /*KİTAP RESMİ*/       "<img class=\"\" src =\"images/" + item.KitapResmi + "\" style=\"width: 96px; height:131px; \"/>" +
          "<h3>" + item.KitapAdi + "</h2>" +
            //"<p>Donec sed odio dui. Etiam porta sem malesuada magna mollis euismod.Nullam id dolor id nibh ultricies vehicula ut id elit. Morbi leo risus, porta ac consectetur ac, vestibulum at eros.Praesent commodo cursus magna.</p>"+
            "<p>" +
            "<a class=\"btn btn-default\" href=\"kitap.aspx?id="+item.ID+"\" role=\"button\">Kitabı İncele &raquo;</a>" +
            "</p>" +
        "</div>");
            }
        }
        return new Tuple<ResultModel, int, string>(result.Item1, result.Item2, str.ToString());
    }

    [WebMethod]
    [ScriptMethod]
    public static Tuple<ResultModel, int, string> AnasayfaOkuyucuListele()
    {
        Tuple<ResultModel, int, ICollection<Kullanicilar>> result =
        KullaniciBLL.AnasayfaOkuyucuListele();


        StringBuilder str = new StringBuilder();

        if (result.Item1.Code == 56)
        {
            foreach (Kullanicilar item in result.Item3)
            {
                str.Append(
                      "<div class=\"okuyucu-bilgileri\">" +
               "<a href=\"profil.aspx?i=" + item.ID + "\">" +
               "<img class=\"img-circle\" src =\"images/" + item.profil.ProfilResmi + "\" width=\"100\" height=\"100\">" +
               "</a>" +
               "<span>" + item.Ad_Soyad + "</span>" +
            //"<span>""</span>"+
            "</div>");
            }
        }
        return new Tuple<ResultModel, int, string>(result.Item1, result.Item2, str.ToString());
    }
}