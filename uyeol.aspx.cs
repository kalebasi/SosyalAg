﻿using KullanicilarModel;
using SonucModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class uyeol : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    [WebMethod]
    [ScriptMethod]
    public static ResultModel UyeKayit(Kullanicilar uyekayit)
    {
        ResultModel x = new ResultModel();
        x = KullaniciBLL.UyeKayit(uyekayit);
        return x;
    }
}