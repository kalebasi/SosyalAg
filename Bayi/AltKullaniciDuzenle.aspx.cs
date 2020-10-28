using KitapBilgileriModel;
using KullaniciModel;
using SonucModel;
using System;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

public partial class Bayi_AltKullaniciDuzenle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

             lblKitapDetayID.InnerText = Convert.ToInt32(Request.QueryString["a"]).ToString();
    }
   
    [WebMethod]
    [ScriptMethod]
    public static Tuple<ResultModel, KitapBilgileri> KitapBilgileriniGetir(string KitapID)
    {
        BayiYetkili bayiObject = new BayiYetkili();
        bayiObject = HttpContext.Current.Session["bayiObject"] as BayiYetkili;

        Tuple<ResultModel, KitapBilgileri> KitapBilgileri = KullaniciBLL.Admin.KitapBilgileriniGetir(KitapID);

        return new Tuple<ResultModel, KitapBilgileri>(KitapBilgileri.Item1, KitapBilgileri.Item2);
    }

    [WebMethod]
    [ScriptMethod]
    public static ResultModel KitapBilgileriniGuncelle(KitapBilgileri kitapModel)
    {
        return KullaniciBLL.Admin.KitapBilgileriniGuncelle(kitapModel);
    }
}


