using KullanicilarModel;
using SonucModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    [WebMethod]
    public static ResultModel OturumAc(Kullanicilar login)
    {

        ResultModel x = new ResultModel();
        x = KullaniciBLL.OturumAc(login);
        if (x.Code == 1)
        {
            Kullanicilar kullaniciObject = new Kullanicilar();
            kullaniciObject = HttpContext.Current.Session["kullaniciObject"] as Kullanicilar;
        }
        return x;
    }
}