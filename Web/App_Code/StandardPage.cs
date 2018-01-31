using System;
using System.Collections.Generic;
using System.Web;


/// <summary>
/// Summary description for StandardPage
/// </summary>
public class StandardPage : System.Web.UI.Page
{
   
    public String ReplaceNull(object obj_data)
    {
        try
        {
            return obj_data == null ? "" : obj_data.ToString().Trim();
        }
        catch (Exception ex)
        {
            //WebLog.Error(ex);
        }
        return "";
    }
}