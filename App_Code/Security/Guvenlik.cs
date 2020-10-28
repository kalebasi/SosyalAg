using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Guvenlik
/// </summary>
public class Guvenlik
{
    public static string ConnString
    {
        get
        {
            return ConfigurationManager.ConnectionStrings["Bitirme_ProjesiConnectionString"].ConnectionString;
        }
    }
    public static string Char39Replace(string i)
    {
        if (!string.IsNullOrEmpty(i))
            return i.Replace("&#039;", "'").Trim();
        else
            return i;

    }

}