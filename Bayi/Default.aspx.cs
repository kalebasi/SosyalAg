using KullaniciModel;
using System;

public partial class Bayi_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            BayiYetkili kullaniciObject = Session["bayiObject"] as BayiYetkili;
            if (kullaniciObject == null)
                Response.Redirect("Login.aspx", false);
        }
        catch
        {
            Response.Redirect("Login.aspx", false);
        }
    }

}