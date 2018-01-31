using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AJAX_AJAXEXAMINE : StandardPage
{
    string action;
    protected void Page_Load(object sender, EventArgs e)
    {
        action = ReplaceNull(Request.QueryString["action"]);

        try
        {
            if (action.Equals("Show"))
            {

                Response.Write(Showexam());
            }
        }
        catch (Exception ex)
        {

        }
    
}
    public string Showexam()
    {
        try
        {
            string ret_data = "";
            string tbname = "EXAMINE e,PATIENT p,DOCTOR d,PHARMACIST ph";
            string field = "e.Exam_id, p.Firstname, e.Examdetail, e.Examdate, d.DFirstname, e.Medicdetail, ph.PHFirstname";
            string condition = "e.Patient_id = p.Patient_id AND e.Doctor_id = d.Doctor_id AND e.Pharma_id = ph.Pharma_id ";
            Utilities manage = new Utilities();
            DataTable dt = manage.SelectData(tbname, field, condition);
            Utilities utilities = new Utilities();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ret_data += ",{\"Exam_id\":\"" + dt.Rows[i]["Exam_id"].ToString() + "\",\"Firstname\":\"" + dt.Rows[i]["Firstname"].ToString() + "\",\"Examdetail\":\"" + dt.Rows[i]["Examdetail"].ToString() + "\"";
                    ret_data += ",\"Examdate\":\"" + dt.Rows[i]["Examdate"].ToString() + "\",\"DFirstname\":\"" + dt.Rows[i]["DFirstname"].ToString() + "\",\"Medicdetail\":\"" + dt.Rows[i]["Medicdetail"].ToString() + "\"";
                    ret_data += ",\"PHFirstname\":\"" + dt.Rows[i]["PHFirstname"].ToString() + "\"}";
                    // ret_data += ",\"BBUTTON1\":\"<center><button type='button' data-toggle='modal' data-target='#myModalE' onclick='fn_view(" + dt.Rows[i]["Queue_id"].ToString() + ")' class='btn-info glyphicon glyphicon-pencil'></button></center> \"}";


                }
                ret_data = ret_data.Substring(1);
                ret_data = "[" + ret_data + "]";
            }
            else
            {
                ret_data = "[]";
            }
            return ret_data;
        }
        catch (Exception ex)
        {
            //LogWriter.DBLog(ex.Message, "ERROR");
            return "";
        }
    }
}