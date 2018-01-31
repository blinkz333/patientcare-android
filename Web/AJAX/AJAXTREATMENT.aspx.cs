using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AJAX_AJAXTREATMENT : StandardPage
{
    string action, treat_id, patient_id, doctor_id, treatdate, weight, height, pulse, bloodpressure, respiratory, condition, treatdetail, treat_ide, pharma_id;
    protected void Page_Load(object sender, EventArgs e)
    {
       
        action = ReplaceNull(Request.QueryString["action"]);
        treat_id = ReplaceNull(Request.QueryString["treat_id"]);
        patient_id = ReplaceNull(Request.QueryString["patient_id"]);
        doctor_id = ReplaceNull(Request.QueryString["doctor_id"]);
        pharma_id = ReplaceNull(Request.QueryString["pharma_id"]);
        treatdate = ReplaceNull(Request.QueryString["treatdate"]);
        treatdetail = ReplaceNull(Request.QueryString["treatdetail"]);
        weight = ReplaceNull(Request.QueryString["weight"]);
        height = ReplaceNull(Request.QueryString["height"]);
        pulse = ReplaceNull(Request.QueryString["pulse"]);
        respiratory = ReplaceNull(Request.QueryString["respiratory"]);
        bloodpressure = ReplaceNull(Request.QueryString["bloodpressure"]);
        condition = ReplaceNull(Request.QueryString["condition"]);


        try
        {
           
            if (action.Equals("Show"))
            {

                Response.Write(Showtreat());
            }
            else if (action.Equals("AddMedic"))
            {
                Response.Write(AddMedic(patient_id, treatdate, weight, height, pulse, respiratory, bloodpressure, condition, treatdetail, doctor_id));
            }
            else if (action.Equals("Edit"))
            {
                //Response.Write(Select_Edit(appoint_id));
            }
            else if (action.Equals("Update"))
            {
                // Response.Write(Update(appoint_ide, status));
                //Response.Write(Update(appoint_ide, patient_id, doctor_id, appointdate, status));
            }
        }
        catch (Exception ex)
        {

        }
    }
    public string Showtreat()
    {
        try
        {
            string ret_data = "";
            string tbname = "TREATMENT t,PATIENT p,DOCTOR d";
            string field = "t.Treat_id, p.Firstname,p.Lastname, t.Treatdate,t.Weight,t.Height,t.Pulse,t.Respiratory_rate,t.Bloodpressure,t.Condition, t.Treatdetail, d.DFirstname, d.DLastname";
            string condition = "t.Patient_id = p.Patient_id AND t.Doctor_id = d.Doctor_id";
            Utilities manage = new Utilities();
            DataTable dt = manage.SelectData(tbname, field, condition);
            Utilities utilities = new Utilities();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ret_data += ",{\"Treat_id\":\"" + dt.Rows[i]["Treat_id"].ToString() + "\",\"PFirstname\":\"" + dt.Rows[i]["Firstname"].ToString() +"  "+ dt.Rows[i]["Lastname"].ToString() + "\",\"Treatdate\":\"" + Convert.ToDateTime(dt.Rows[i]["Treatdate"]).ToString("dd/MM/yyyy H:mm", new CultureInfo("en-EN")) + "\"";
                    ret_data += ",\"Weight\":\"" + dt.Rows[i]["Weight"].ToString() + "\",\"Height\":\"" + dt.Rows[i]["Height"].ToString() + "\",\"Pulse\":\"" + dt.Rows[i]["Pulse"].ToString() + "\",\"Respiratory_rate\":\"" + dt.Rows[i]["Respiratory_rate"].ToString() + "\"";
                    ret_data += ",\"Bloodpressure\":\"" + dt.Rows[i]["Bloodpressure"].ToString() + "\",\"Condition\":\"" + dt.Rows[i]["Condition"].ToString() + "\",\"Treatdetail\":\"" + dt.Rows[i]["Treatdetail"].ToString() + "\",\"DFirstname\":\"" + dt.Rows[i]["DFirstname"].ToString() +"  "+ dt.Rows[i]["DLastname"].ToString() + "\"";
                    ret_data += ",\"BBUTTON1\":\"<center><button type='button' data-toggle='modal' data-target='#myModalE' onclick='fn_view(" + dt.Rows[i]["Treat_id"].ToString() + ")' class='btn-info glyphicon glyphicon-pencil'></button></center> \"";
                    ret_data += ",\"BBUTTON2\":\"<center><button type='button' data-toggle='modal' data-target='#myModalD' onclick='fn_view(" + dt.Rows[i]["Treat_id"].ToString() + ")' class='btn-warning glyphicon glyphicon-remove'></button></center> \"}";


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

    
    
    protected bool AddMedic(string patient_id, string treatdate, string weight, string height, string pulse, string respiratory, string bloodpressue, string condition, string treatdetail, string doctor_id)
    {
        try
        {
            MANAGE_PATIENT m_patient = new MANAGE_PATIENT();

            m_patient.Patient_id = Convert.ToInt32(patient_id);
            m_patient.Treatdate = treatdate;
            m_patient.Weight = Convert.ToDouble(weight);
            m_patient.Height = Convert.ToDouble(height);
            m_patient.Pulse = Convert.ToInt32(pulse);
            m_patient.Respiratory = Convert.ToInt32(respiratory);
            m_patient.Bloodpressure = bloodpressure;
            m_patient.Condition = condition;
            m_patient.Treatdetail = treatdetail;
            m_patient.Doctor_id = Convert.ToInt32(doctor_id);
            


            C_PATIENT c_patient = new C_PATIENT();
            c_patient.AddMedic(m_patient.Patient_id, m_patient.Treatdate, m_patient.Weight, m_patient.Height, m_patient.Pulse, m_patient.Respiratory, m_patient.Bloodpressure, m_patient.Condition, m_patient.Treatdetail, m_patient.Doctor_id);
            return true;
        }
        catch (Exception ex)
        {

        }
        return false;
    }
}