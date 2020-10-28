<%@ WebHandler Language="C#" Class="CsvExporter" %>

using System;
using System.Web;

public class CsvExporter : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        try
        {
            context.Response.Clear();
            context.Response.ClearHeaders();
            context.Response.ClearContent();
            context.Response.ContentEncoding = System.Text.Encoding.GetEncoding("windows-1254");
            context.Response.AddHeader("content-disposition", "filename=" + context.Request.Form["fileName"] + ".csv");
            context.Response.ContentType = "text/csv";
            context.Response.ContentType = "application/force-download";

            context.Response.AddHeader("Pragma", "public");
            context.Response.Buffer = true;

            context.Response.Write(context.Request.Form["exportdata"]);
            context.Response.Flush();
            context.Response.End();
        }
        catch 
        { }
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}