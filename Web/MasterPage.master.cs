using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Username"] == null)
        {
            Response.Redirect("/Login.aspx");
        }
        else
        {

            Label1.Text = (" " + Session["Username"]);
        }
        

        String activepage = Request.RawUrl;
        if (activepage.Contains("Managepatient.aspx"))
        {
            page1.Attributes.Add("class", "active");
        }
        else if (activepage.Contains("Reservation.aspx"))
        {
            page2.Attributes.Add("class", "active");
        }
        else if (activepage.Contains("Medication.aspx"))
        {
            page3.Attributes.Add("class", "active");
        }
       
    }
    
}
