using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Medication : StandardPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Selectpt();
        Selectdt();
        

    }
    protected bool Selectpt()
    {
        string tbname = "PATIENT p";
        string field = "p.Patient_id,p.Firstname,p.Lastname";

        Utilities manage = new Utilities();
        DataTable dt = manage.SelectData(tbname, field);
        foreach (DataRow dr in dt.Rows)
        {
            select_ptid.Items.Add(new ListItem(ReplaceNull(dr["Firstname"])+"\n\n"+ ReplaceNull(dr["Lastname"]), ReplaceNull(dr["Patient_id"])));
        }
        select_ptid.Items.Insert(0, new ListItem("กรุณาเลือกชื่อผู้ป่วย", ""));
        return true;

    }

    protected bool Selectdt()
    {
        string tbname = "DOCTOR d";
        string field = "d.Doctor_id,d.DFirstname,d.DLastname";

        Utilities manage = new Utilities();
        DataTable dt = manage.SelectData(tbname, field);
        foreach (DataRow dr in dt.Rows)
        {
            select_dtid.Items.Add(new ListItem(ReplaceNull(dr["DFirstname"])+"\n\n"+ ReplaceNull(dr["DLastname"]), ReplaceNull(dr["Doctor_id"])));
        }
        select_dtid.Items.Insert(0, new ListItem("กรุณาเลือกชื่อแพทย์", ""));
        return true;

    }
   
   
    
}