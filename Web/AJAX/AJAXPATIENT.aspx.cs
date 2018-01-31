using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Data.SqlClient;

using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AJAX_AJAXPATIENT : StandardPage
{
    string action, patient_id, patient_ide, firstname, lastname, nickname, birth, gender, address, email, tel, chronicd, bloodtype, allergydrug, username, password, id_card, rh, cousin, cousintell;

    protected void Page_Load(object sender, EventArgs e)
    {
        action = ReplaceNull(Request.QueryString["action"]);
        patient_id = ReplaceNull(Request.QueryString["patient_id"]);
        patient_ide = ReplaceNull(Request.QueryString["patient_ide"]);
        firstname = ReplaceNull(Request.QueryString["firstname"]);
        lastname = ReplaceNull(Request.QueryString["lastname"]);
        nickname = ReplaceNull(Request.QueryString["nickname"]);
        birth = ReplaceNull(Request.QueryString["birth"]);
        gender = ReplaceNull(Request.QueryString["gender"]);
        address = ReplaceNull(Request.QueryString["address"]);
        email = ReplaceNull(Request.QueryString["email"]);
        tel = ReplaceNull(Request.QueryString["tel"]);
        chronicd = ReplaceNull(Request.QueryString["chronicd"]);
        bloodtype = ReplaceNull(Request.QueryString["bloodtype"]);
        allergydrug = ReplaceNull(Request.QueryString["allergydrug"]);
        username = ReplaceNull(Request.QueryString["username"]);
        password = ReplaceNull(Request.QueryString["password"]);
        id_card = ReplaceNull(Request.QueryString["id_card"]);
        rh = ReplaceNull(Request.QueryString["rh"]);
        cousin = ReplaceNull(Request.QueryString["cousin"]);
        cousintell = ReplaceNull(Request.QueryString["cousintell"]);

        try
        {
            if (action.Equals("Show"))
            {

                Response.Write(Showpatient());
            }
            else if (action.Equals("AddPatient"))
            {
                Response.Write(AddPatient(username,password,firstname, lastname, nickname, birth, gender, address, email, tel, id_card, chronicd, bloodtype,rh, allergydrug, cousin, cousintell));
            }
            else if (action.Equals("Edit"))
            {
                Response.Write(Select_Edit(patient_id));
            }
            else if (action.Equals("Update"))
            {
                Response.Write(Update(patient_ide,username, password, firstname, lastname, nickname, birth, gender, address, email, tel, id_card,  chronicd, bloodtype, rh, allergydrug, cousin, cousintell));
            }
            else if (action.Equals("Delete"))
            {
                Response.Write(Delete(patient_id));
            }

        }
        catch (Exception ex)
        {

        }
    }
    public string Showpatient()
    {
        try
        {
            string ret_data = "";
            string tbname = "PATIENT";
            string field = "Patient_id, Firstname, Lastname, Nickname, Birth, Gender, Address, Email, Tel, Id_card, ChronicD, Bloodtype, Rh, Allergydrug, Cousin, Cousintell";
            //CONVERT(VARCHAR(10), Birth, 110)
            Utilities manage = new Utilities();
            DataTable dt = manage.SelectData(tbname, field);
            Utilities utilities = new Utilities();
            string format = "dd/MM/yyyy";
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //DateTime time = Convert.ToDateTime(dt.Rows[i]["Birth"].ToString("dd/MM/yyyy",new CultureInfo("th-TH")));
                    //Convert.ToDateTime(dt.Rows[i]["Birth"]).ToString("dd/mm/yyyy", new System.Globalization.CultureInfo("th-TH"))
                    ret_data += ",{\"Patient_id\":\"" + dt.Rows[i]["Patient_id"].ToString() + "\",\"Firstname\":\"" + dt.Rows[i]["Firstname"].ToString() + "\",\"Lastname\":\"" + dt.Rows[i]["Lastname"].ToString() + "\"";
                    ret_data += ",\"Nickname\":\"" + dt.Rows[i]["Nickname"].ToString() + "\",\"Birth\":\"" + Convert.ToDateTime(dt.Rows[i]["Birth"]).ToString("dd/MM/yyyy",new CultureInfo("en-EN")) + "\",\"Gender\":\"" + dt.Rows[i]["Gender"].ToString() + "\"";
                    ret_data += ",\"Address\":\"" + dt.Rows[i]["Address"].ToString() + "\",\"Email\":\"" + dt.Rows[i]["Email"].ToString() + "\",\"Tel\":\"" + dt.Rows[i]["Tel"].ToString() + "\",\"Id_card\":\"" + dt.Rows[i]["Id_card"].ToString() + "\"";
                    ret_data += ",\"ChronicD\":\"" + dt.Rows[i]["ChronicD"].ToString() + "\",\"Bloodtype\":\"" + dt.Rows[i]["Bloodtype"].ToString() + "\",\"Rh\":\"" + dt.Rows[i]["Rh"].ToString() + "\"";
                    ret_data += ",\"Allergydrug\":\"" + dt.Rows[i]["Allergydrug"].ToString() + "\",\"Cousin\":\"" + dt.Rows[i]["Cousin"].ToString() + "\",\"Cousintell\":\"" + dt.Rows[i]["Cousintell"].ToString() + "\"";
                    ret_data += ",\"BBUTTON1\":\"<center><button type='button' data-toggle='modal' data-target='#myModalE' onclick='fn_view(" + dt.Rows[i]["Patient_id"].ToString() + ")' class='btn-info glyphicon glyphicon-pencil'></button></center> \"";
                    ret_data += ",\"BBUTTON2\":\"<center><button type='button' data-toggle='modal' data-target='#myModalD' onclick='fn_view(" + dt.Rows[i]["Patient_id"].ToString() + ")' class='btn-warning glyphicon glyphicon-remove'></button></center> \"}";

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
    protected bool AddPatient(string username, string password,string firstname, string lastname, string nickname, string birth, string gender, string address, string email, string tel, string id_card, string chronicd, string bloodtype, string rh, string allergydrug, string cousin, string cousintell)
    {
        



                try
                {
                    MANAGE_PATIENT m_patient = new MANAGE_PATIENT();
                    m_patient.username = username;
                    m_patient.password = password;
                    m_patient.Firstname = firstname;
                    m_patient.Lastname = lastname;
                    m_patient.Nickname = nickname;
                    m_patient.Birth = birth;
                    m_patient.Gender = gender;
                    m_patient.Address = address;
                    m_patient.Email = email;
                    m_patient.Tel = tel;
                    m_patient.Id_card = Convert.ToInt64(id_card);
                    m_patient.ChronicD = chronicd;
                    m_patient.Bloodtype = bloodtype;
                    m_patient.Rh = rh;
                    m_patient.Allergydrug = allergydrug;
                    m_patient.Cousin = cousin;
                    m_patient.Cousintell = cousintell;
                    

                    C_PATIENT c_patient = new C_PATIENT();
                    c_patient.AddPatient(m_patient.username, m_patient.password, m_patient.Firstname, m_patient.Lastname, m_patient.Nickname, m_patient.Birth, m_patient.Gender, m_patient.Address, m_patient.Email, m_patient.Tel, m_patient.Id_card, m_patient.ChronicD, m_patient.Bloodtype, m_patient.Rh, m_patient.Allergydrug, m_patient.Cousin, m_patient.Cousintell);
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
            string tbname = "PATIENT p";
            string field = "p.Patient_id, p.username, p.password, p.Firstname, p.Lastname, p.Nickname, p.Birth, p.Gender, p.Address, p.Email, p.Tel, p.Id_card, p.ChronicD, p.Bloodtype, p.Rh, p.Allergydrug, p.Cousin, p.Cousintell";
            string condition = "p.Patient_id = @id";
            Dictionary<String, Object> map = new Dictionary<String, object>();
            map.Add("@id", id);
            Utilities manage = new Utilities();
            DataTable dt = manage.SelectData(tbname, field, condition, map);
            Utilities utilities = new Utilities();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ret_data += ",{\"Patient_id\":\"" + dt.Rows[i]["Patient_id"].ToString() + "\",\"username\":\"" + dt.Rows[i]["username"].ToString() + "\",\"password\":\"" + dt.Rows[i]["password"].ToString() + "\",\"Firstname\":\"" + dt.Rows[i]["Firstname"].ToString() + "\",\"Lastname\":\"" + dt.Rows[i]["Lastname"].ToString() + "\"";
                    ret_data += ",\"Nickname\":\"" + dt.Rows[i]["Nickname"].ToString() + "\",\"Birth\":\"" + Convert.ToDateTime(dt.Rows[i]["Birth"]).ToString("dd/MM/yyyy", new CultureInfo("en-EN")) + "\",\"Gender\":\"" + dt.Rows[i]["Gender"].ToString() + "\"";
                    ret_data += ",\"Address\":\"" + dt.Rows[i]["Address"].ToString() + "\",\"Email\":\"" + dt.Rows[i]["Email"].ToString() + "\",\"Tel\":\"" + dt.Rows[i]["Tel"].ToString() + "\",\"Id_card\":\"" + dt.Rows[i]["Id_card"].ToString() + "\"";
                    ret_data += ",\"ChronicD\":\"" + dt.Rows[i]["ChronicD"].ToString() + "\",\"Bloodtype\":\"" + dt.Rows[i]["Bloodtype"].ToString() + "\",\"Rh\":\"" + dt.Rows[i]["Rh"].ToString() + "\",\"Allergydrug\":\"" + dt.Rows[i]["Allergydrug"].ToString() + "\",\"Cousin\":\"" + dt.Rows[i]["Cousin"].ToString() + "\",\"Cousintell\":\"" + dt.Rows[i]["Cousintell"].ToString() + "\"}";
                    

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
    protected bool Update(string patient_id,string username, string password, string firstname, string lastname, string nickname, string birth, string gender, string address, string email, string tel, string id_card, string chronicd, string bloodtype, string rh, string allergydrug, string cousin, string cousintell)
    {
        try
        {
            MANAGE_PATIENT m_patient = new MANAGE_PATIENT();
            m_patient.Patient_id = Convert.ToInt32(patient_id);
            m_patient.username = username;
            m_patient.password = password;
            m_patient.Firstname = firstname;
            m_patient.Lastname = lastname;
            m_patient.Nickname = nickname;
            m_patient.Birth = birth;
            m_patient.Gender = gender;
            m_patient.Address = address;
            m_patient.Email = email;
            m_patient.Tel = tel;
            m_patient.Id_card = Convert.ToInt64(id_card);
            m_patient.ChronicD = chronicd;
            m_patient.Bloodtype = bloodtype;
            m_patient.Rh = rh;
            m_patient.Allergydrug = allergydrug;
            m_patient.Cousin = cousin;
            m_patient.Cousintell = cousintell;



            C_PATIENT c_patient = new C_PATIENT();
            c_patient.Updatepatient(m_patient.Patient_id, m_patient.username, m_patient.password, m_patient.Firstname, m_patient.Lastname, m_patient.Nickname, m_patient.Birth, m_patient.Gender, m_patient.Address, m_patient.Email, m_patient.Tel, m_patient.Id_card, m_patient.ChronicD, m_patient.Bloodtype, m_patient.Rh, m_patient.Allergydrug, m_patient.Cousin, m_patient.Cousintell);
            return true;
        }
        catch (Exception ex)
        {

        }
        return false;
    }
    protected bool Delete(String patient_id)
    {

        try
        {
            MANAGE_PATIENT m_patient = new MANAGE_PATIENT();
            m_patient.Patient_id = Convert.ToInt32(patient_id);

            C_PATIENT c_patient = new C_PATIENT();
            c_patient.deletepatient(m_patient.Patient_id);
            return true;
        }
        catch (Exception ex)
        {
            //  this.DBLog(ex.Message, "ERROR");
            //  this.DBLog(ex.StackTrace, "ERROR");
        }

        return false;
    }
}