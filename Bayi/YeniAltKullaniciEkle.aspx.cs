using KitapBilgileriModel;
using KullaniciModel;
using SonucModel;
using System;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

public partial class Bayi_YeniAltKullaniciEkle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            try
            {
                Kullanici bayiObject = new Kullanici();
                bayiObject = HttpContext.Current.Session["bayiObject"] as Kullanici;
              
            }
            catch
            {
                Response.Redirect("Default.aspx");
            }
        }
    }

    [WebMethod]
    [ScriptMethod]
    public static Tuple<ResultModel> YeniKitapEkle(KitapBilgileri kitapModel)
    {
        return KullaniciBLL.Admin.YeniKitapEkle(kitapModel);
    }

}