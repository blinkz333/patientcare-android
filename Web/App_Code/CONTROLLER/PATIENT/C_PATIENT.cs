using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for C_PATIENT
/// </summary>
public class C_PATIENT
{
	public C_PATIENT()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public bool AddPatient(string username, string password, string firstname, string lastname, string nickname, string birth, string gender, string address, string email, string tel, Int64 id_card, string chronicd, string bloodtype, string rh, string allergydrug, string cousin, string cousintell)
    {
       
       
                try
                {

                    string tbnameAdd = "PATIENT";
                    Utilities manage = new Utilities();

                    MANAGE_PATIENT m_patient = new MANAGE_PATIENT();


                    Dictionary<String, object> data = new Dictionary<string, object>();
                    data.Add("username", username);
                    data.Add("password", password);
                    data.Add("Firstname", firstname);
                    data.Add("Lastname", lastname);
                    data.Add("Nickname", nickname);
                    data.Add("Birth", birth);
                    data.Add("Gender", gender);
                    data.Add("Address", address);
                    data.Add("Email", email);
                    data.Add("Tel", tel);
                    data.Add("Id_card", id_card);
                    data.Add("ChronicD", chronicd);
                    data.Add("Bloodtype", bloodtype);
                    data.Add("Rh", rh);
                    data.Add("Allergydrug", allergydrug);
                    data.Add("Cousin", cousin);
                    data.Add("Cousintell", cousintell);

            manage.InsertData(tbnameAdd, data);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            
        
        }
    public bool AddAppoint(int patient_id, int doctor_id, string appointdate, string status, string raiseby)
    {
        try
        {

            string tbnameAdd = "APPOINTMENT";
            Utilities manage = new Utilities();

            MANAGE_PATIENT m_patient = new MANAGE_PATIENT();


            Dictionary<String, object> data = new Dictionary<string, object>();

            data.Add("Patient_id", patient_id);
            data.Add("Doctor_id", doctor_id);
            data.Add("AppointDate", appointdate);
            data.Add("Status", status);
            data.Add("Raiseby", raiseby);
           

            manage.InsertData(tbnameAdd, data);
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
    public bool AddMedic(int patient_id, string treatdate,Double weight,Double height,int pulse,int respiratory,string bloodpressure,string condition, string treatdetail, int doctor_id)
    {
        try
        {

            string tbnameAdd = "TREATMENT";
            Utilities manage = new Utilities();

            MANAGE_PATIENT m_patient = new MANAGE_PATIENT();


            Dictionary<String, object> data = new Dictionary<string, object>();

            data.Add("Patient_id", patient_id);
            data.Add("Treatdate", treatdate);
            data.Add("Weight", weight);
            data.Add("Height", height);
            data.Add("Pulse", pulse);
            data.Add("Respiratory_rate", respiratory);
            data.Add("Bloodpressure", bloodpressure);
            data.Add("Condition", condition);
            data.Add("Treatdetail", treatdetail);
            data.Add("Doctor_id", doctor_id);
            



            manage.InsertData(tbnameAdd, data);
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
    public void Updatepatient(int patient_id, string username, string password, string firstname, string lastname, string nickname, string birth, string gender, string address, string email, string tel, Int64 id_card, string chronicd, string bloodtype, string rh, string allergydrug, string cousin, string cousintell)
    {
        try
        {
            Utilities manage = new Utilities();
            String tbname = "PATIENT";
            String condition = "Patient_id = @id";
            Dictionary<String, object> data = new Dictionary<String, object>();
            Dictionary<String, object> map = new Dictionary<String, object>();
            map.Add("@id", patient_id);
            data.Add("username", username);
            data.Add("password", password);
            data.Add("Firstname", firstname);
            data.Add("Lastname", lastname);
            data.Add("Nickname", nickname);
            data.Add("Birth", birth);
            data.Add("Gender", gender);
            data.Add("Address", address);
            data.Add("Email", email);
            data.Add("Tel", tel);
            data.Add("Id_card", id_card);
            data.Add("ChronicD", chronicd);
            data.Add("Bloodtype", bloodtype);
            data.Add("Rh", rh);
            data.Add("Allergydrug", allergydrug);
            data.Add("Cousin", cousin);
            data.Add("Cousintell", cousintell);
            manage.UpdateData(tbname, condition, map, data);

        }
        catch (Exception ex)
        {

        }

    }
    public void deletepatient(int patient_id)
    {
        try
        {
            Utilities manage = new Utilities();
            String tbname = "PATIENT";
            String condition = "Patient_id = @id";
            Dictionary<String, object> data = new Dictionary<String, object>();
            Dictionary<String, object> map = new Dictionary<String, object>();
            map.Add("@id", patient_id);


            manage.DeleteData(tbname, condition, map);

        }
        catch (Exception ex)
        {

        }

    }
    //public void Updatequeue(int queue_id, int patient_id, int doctor_id, string queuedate, string status)
        public void Updateappoint(int appoint_id, string status,string raiseby)
    {
        try
        {
            Utilities manage = new Utilities();
            String tbname = "APPOINTMENT";
            String condition = "Appoint_id = @id";
            Dictionary<String, object> data = new Dictionary<String, object>();
            Dictionary<String, object> map = new Dictionary<String, object>();
            map.Add("@id", appoint_id);
            //   data.Add("Patient_id", patient_id);
            //  data.Add("Doctor_id", doctor_id);
            //  data.Add("AppointDate", appointdate);
            data.Add("Status", status);
            data.Add("Raiseby", raiseby);

            manage.UpdateData(tbname, condition, map, data);

        }
        catch (Exception ex)
        {

        }

    }
}
