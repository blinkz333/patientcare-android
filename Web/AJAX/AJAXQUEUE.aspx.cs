using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AJAX_AJAXQUEUE : StandardPage
{
    string action, appoint_id, patient_id,doctor_id, appointdate, status,raiseby, appoint_ide,statuse;
    protected void Page_Load(object sender, EventArgs e)
    {
        action = ReplaceNull(Request.QueryString["action"]);
        appoint_id = ReplaceNull(Request.QueryString["appoint_id"]);
        appoint_ide = ReplaceNull(Request.QueryString["appoint_ide"]);
        patient_id = ReplaceNull(Request.QueryString["patient_id"]);
        doctor_id = ReplaceNull(Request.QueryString["doctor_id"]);
        appointdate = (Request.QueryString["appointdate"]);

        status = (Request.QueryString["status"]);
        raiseby = ("" + Session["Username"]);


        try
        {
            if (action.Equals("Show"))
            {

                Response.Write(Showappoint());
            }
            else if (action.Equals("AddAppoint"))
            {
                Response.Write(AddAppoint(patient_id, doctor_id, appointdate, status, raiseby));
            }
            else if (action.Equals("Edit"))
            {
                Response.Write(Select_Edit(appoint_id));
            }
            else if (action.Equals("Update"))
            {
                Response.Write(Update(appoint_ide, status,raiseby));
                //Response.Write(Update(appoint_ide, patient_id, doctor_id, appointdate, status));
            }
        }
        catch (Exception ex)
        {

        }
    }
    public string Showappoint()
    {
        try
        {
            string ret_data = "";
            string tbname = "APPOINTMENT a,PATIENT p,DOCTOR d";
            string field = "a.Appoint_id,p.Firstname,p.Lastname, d.DFirstname,d.DLastname, a.AppointDate,a.Status,a.Raiseby";
            string condition = "a.Patient_id = p.Patient_id AND a.Doctor_id = d.Doctor_id AND (a.Status = 'รอตรวจ' OR a.Status = 'รอยืนยัน' )";
            Utilities manage = new Utilities();
            DataTable dt = manage.SelectData(tbname, field, condition);
            Utilities utilities = new Utilities();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ret_data += ",{\"Appoint_id\":\"" + dt.Rows[i]["Appoint_id"].ToString() + "\",\"PFirstname\":\"" + dt.Rows[i]["Firstname"].ToString() +"   "+ dt.Rows[i]["Lastname"].ToString() + "\",\"DFirstname\":\"" + dt.Rows[i]["DFirstname"].ToString() +"   "+ dt.Rows[i]["DLastname"].ToString() + "\"";
                    ret_data += ",\"AppointDate\":\"" + Convert.ToDateTime(dt.Rows[i]["AppointDate"]).ToString("dd/MM/yyyy H:mm", new CultureInfo("en-EN")) + "\",\"Status\":\"" + dt.Rows[i]["Status"].ToString() + "\",\"Raiseby\":\"" + dt.Rows[i]["Raiseby"].ToString() + "\"";
                    ret_data += ",\"BBUTTON1\":\"<center><button type='button' data-toggle='modal' data-target='#myModalE' onclick='fn_view(" + dt.Rows[i]["Appoint_id"].ToString() + ")' class='btn-info glyphicon glyphicon-pencil'></button></center> \"}";
                    //ret_data += ",\"BBUTTON2\":\"<center><button type='button' data-toggle='modal' data-target='#myModalD' onclick='fn_view(" + dt.Rows[i]["Appoint_id"].ToString() + ")' class='btn-warning glyphicon glyphicon-remove'></button></center> \"}";

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
    protected bool AddAppoint(string patient_id, string doctor_id,string  appointdate, string status, string raiseby)
    {
        try
        {
            MANAGE_PATIENT m_patient = new MANAGE_PATIENT();

            m_patient.Patient_id = Convert.ToInt32(patient_id);
            m_patient.Doctor_id = Convert.ToInt32(doctor_id);
            m_patient.AppointDate = appointdate;
            m_patient.Status = "รอตรวจ";
            m_patient.Raiseby = raiseby;
           

            C_PATIENT c_patient = new C_PATIENT();
            c_patient.AddAppoint(m_patient.Patient_id, m_patient.Doctor_id, m_patient.AppointDate, m_patient.Status, m_patient.Raiseby);
            return true;
        }
        catch (Exception ex)
        {

        }
        return false;
    }

    public string Select_Edit(string id)
    {
        try
        {
            string ret_data = "";
            string tbname = "APPOINTMENT a, PATIENT p, DOCTOR d";
            string field = "a.Appoint_id, p.Firstname, d.DFirstname, a.AppointDate, a.Status";
            string condition = "a.Patient_id = p.Patient_id AND a.Doctor_id = d.Doctor_id AND a.Appoint_id = @id";
            Dictionary<String, Object> map = new Dictionary<String, object>();
            map.Add("@id", id);
            Utilities manage = new Utilities();
            DataTable dt = manage.SelectData(tbname, field, condition, map);
            Utilities utilities = new Utilities();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ret_data += ",{\"Appoint_id\":\"" + dt.Rows[i]["Appoint_id"].ToString() + "\",\"PFirstname\":\"" + dt.Rows[i]["Firstname"].ToString() + "\",\"DFirstname\":\"" + dt.Rows[i]["DFirstname"].ToString() + "\"";
                    ret_data += ",\"AppointDate\":\"" + dt.Rows[i]["AppointDate"].ToString() + "\",\"Status\":\"" + dt.Rows[i]["Status"].ToString() +  "\"}";
                    


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
    protected bool Update(string appoint_id, string status, string raiseby)
    {
        try
        {
            MANAGE_PATIENT m_patient = new MANAGE_PATIENT();
            m_patient.Appoint_id = Convert.ToInt32(appoint_id);
            // m_patient.Patient_id = Convert.ToInt32(patient_id);
            // m_patient.Doctor_id = Convert.ToInt32(doctor_id);
            //  m_patient.AppointDate = appointdate;
            m_patient.Raiseby = raiseby;
            m_patient.Status = status;
            



            C_PATIENT c_patient = new C_PATIENT();
            c_patient.Updateappoint(m_patient.Appoint_id, m_patient.Status, m_patient.Raiseby);
            //c_patient.Updateappoint(m_patient.Appoint_id, m_patient.Patient_id, m_patient.Doctor_id, m_patient.AppointDate, m_patient.Status);
            return true;
        }
        catch (Exception ex)
        {

        }
        return false;
    }
}