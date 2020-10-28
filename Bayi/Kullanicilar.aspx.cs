using KitapBilgileriModel;
using KitaplarModel;
using KullaniciModel;
using SonucModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

public partial class Bayi_Kullanicilar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                BayiYetkili kullaniciObject = Session["bayiObject"] as BayiYetkili;

                if (kullaniciObject == null)
                    Response.Redirect("Login.aspx");

            }
            catch
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
    [WebMethod]
    [ScriptMethod]
    public static Tuple<ResultModel, int, ICollection<Kitaplar>> KitaplariGetir()
    {
        return KullaniciBLL.Admin.KitaplariGetir();
    }


    [WebMethod]
    [ScriptMethod]
    public static Tuple<ResultModel, int, string> Listele(AramaKriterleri aramaKriterleri)
    {
        Tuple<ResultModel, int, ICollection<KitapBilgileri>> result = KullaniciBLL.Admin.Listele(aramaKriterleri);

        StringBuilder str = new StringBuilder();
        //int x = 1;
        if (result.Item1.Code == 56)
        {
            BayiYetkili bayiObject = new BayiYetkili();
            bayiObject = HttpContext.Current.Session["bayiObject"] as BayiYetkili;

            foreach (KitapBilgileri item in result.Item3)
            {
                string DRDurum = "";
                if (item.Durum == true)
                    DRDurum = "<span class=\"fa fa-check-circle   btn btn-success\"></span>";
                else
                    DRDurum = "<span class=\"fa fa-times-circle btn btn-danger\"></span>";
                str.Append("<tr>" +
                    "<td>" + item.ID + "</td>" +

                     "<td class=\"yauto\">" + item.kitaplar.KitapTürü
                     + "</td><td class=\"yauto\">" + item.KitapAdi
                     + "</td><td class=\"yauto\">" + item.KitapYazari
                     + "</td><td class=\"yauto\">" + item.ISBN
                     + "</td><td class=\"yauto\">" + item.BasimTarihi
                     + "</td><td class=\"yauto\">" + item.SayfaSayisi
                     + "</td><td class=\"yauto\">" + item.Dil
                     + "</td><td class=\"yauto\">" + item.Ulke
                     + "</td><td class=\"yauto\">" + item.YayınEvi
                     + "</td>" +
                     "<td>");

                str.Append("<span ><a title=\"KİTAP DUZENLE\" href=\"AltKullaniciDuzenle.aspx?a=" + item.ID + /*"&ktid=" + item.kitaplar.ID +*/ "\" class=\"pop_box\">"
             + "<span class=\"btn btn-primary fa fa-pencil-alt\"></span></a></span>");
          
                str.Append("</td></tr>");
            }
        }

        return new Tuple<ResultModel, int, string>(result.Item1, result.Item2, str.ToString());
    }



}