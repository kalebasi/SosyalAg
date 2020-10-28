using KullaniciModel;
using SonucModel;
using System;
using System.Web;
using System.Web.Services;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    [WebMethod]
    public static ResultModel LoginSystem(string Username, string Password)
    {
        ResultModel x = new ResultModel();
        x = KullaniciBLL.Admin.OturumAc(Username, Password);
        if (x.Code == 56)
        {
            BayiYetkili bayiObject = new BayiYetkili();
            bayiObject = HttpContext.Current.Session["bayiObject"] as BayiYetkili;
            //KullaniciTurID = bayiObject.KullaniciTurID;
        }
        return x;
    }



}