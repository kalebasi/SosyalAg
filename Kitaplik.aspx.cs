using KitapBilgileriModel;
using KitaplarModel;
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

public partial class Kitaplik : System.Web.UI.Page
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

    [WebMethod]
    [ScriptMethod]
    public static Tuple<ResultModel, int, string> KitapListele(int? KitapTürID)
    {
        Tuple<ResultModel, int, ICollection<KitapBilgileri>> result =
        KullaniciBLL.KitapListele(KitapTürID);


        StringBuilder str = new StringBuilder();

        if (result.Item1.Code == 1)
        {
            foreach (KitapBilgileri item in result.Item3)
            {
                str.Append(
                    "<a href =\"kitap.aspx?id=" + item.ID + "\">" +
              "<div class=\"card kitaplik-div\">" +
 /*Kitap Resmi*/    "<img src =\"images/" + item.KitapResmi + "\" class=\"kitaplik-resim-div\" />" +
                    "<div class=\"card-body\">" +
                     "<h4 class=\"card-title kitaplik-ad-div\">" + item.KitapAdi + "</h4>" +
                     "</div>" +
                             "</div>" +
                                "</a>");
            }
        }
        return new Tuple<ResultModel, int, string>(result.Item1, result.Item2, str.ToString());
    }

    [WebMethod]
    [ScriptMethod]
    public static Tuple<ResultModel, int, string> KitapTürleriListele()
    {
        Tuple<ResultModel, int, ICollection<Kitaplar>> result =
        KullaniciBLL.KitapTürleriListele();


        StringBuilder str = new StringBuilder();

        if (result.Item1.Code == 56)
        {
            foreach (Kitaplar item in result.Item3)
            {
                str.Append("<a href =\"?id=" + item.ID + "\" class=\"list-group-item btn\">" + item.KitapTürü + "</a>");
            }
        }
        return new Tuple<ResultModel, int, string>(result.Item1, result.Item2, str.ToString());
    }

}