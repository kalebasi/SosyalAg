﻿<%@ WebHandler Language="C#" Class="KapakResmi" %>

using System;
using System.Web;
using System.IO;
using KullanicilarModel;

public class KapakResmi : IHttpHandler,System.Web.SessionState.IRequiresSessionState
{
    public void ProcessRequest (HttpContext context)
    {
        Kullanicilar kullaniciObject = new Kullanicilar();
        kullaniciObject = HttpContext.Current.Session["kullaniciObject"] as Kullanicilar;
        int kullaniciid = kullaniciObject.ID;
        context.Response.ContentType = "text/plain";
        try
        {
            string dirFullPath = HttpContext.Current.Server.MapPath("~/images/");
            string[] files;
            int numFiles;
            files = System.IO.Directory.GetFiles(dirFullPath);
            numFiles = files.Length;
            numFiles = numFiles + 1;
            string str_image = "";

            foreach (string s in context.Request.Files)
            {
                HttpPostedFile file = context.Request.Files[s];
                string fileName = file.FileName;
                string fileExtension = file.ContentType;

                if (!string.IsNullOrEmpty(fileName))
                {
                    fileExtension = Path.GetExtension(fileName);
                    str_image = "MyPHOTO_" + numFiles.ToString() + fileExtension;
                    string pathToSave_100 = HttpContext.Current.Server.MapPath("~/images/") + str_image;
                    file.SaveAs(pathToSave_100);
                }
            }
            //  database record update logic here  ()
            KullaniciBLL.KapakResimKaydet(str_image,kullaniciid);
            context.Response.Write(str_image);
        }
        catch (Exception ac)
        {

        }
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}