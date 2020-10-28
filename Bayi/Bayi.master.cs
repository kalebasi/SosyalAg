using KullaniciModel;
using System;
public partial class Bayi_Bayi : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            BayiYetkili kullaniciObject = Session["bayiObject"] as BayiYetkili;
            if ((kullaniciObject == null))
                Response.Redirect("Login.aspx");
            DivAdiSoyadi.InnerText = kullaniciObject.AdSoyad;
            lblKullaniciTurID.InnerText = kullaniciObject.KullaniciTurID.ToString();
        }
        catch
        {
            Response.Redirect("Login.aspx");
        }
    }
}
