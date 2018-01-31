using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

/// <summary>
/// Summary description for loginn
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
[ScriptService]
public class appoint : System.Web.Services.WebService
{

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public void appointment(String patient_id)
    {
        ConnectDatabase connectBase = new ConnectDatabase();
        SqlCommand selectAppoint = new SqlCommand();

        selectAppoint.CommandText = "Select a.Appoint_id,p.Patient_id,p.Firstname,d.Doctor_id,d.DFirstname,a.AppointDate,a.Status from PATIENT p, DOCTOR d, APPOINTMENT a where a.Patient_id = p.Patient_id AND a.Doctor_id = d.Doctor_id AND  p.Patient_id = @TextBoxid AND (a.Status = 'รอตรวจ' OR a.Status = 'รอยืนยัน' )";

        selectAppoint.Parameters.AddWithValue("@TextBoxid", patient_id);
        

        selectAppoint.Connection = connectBase.getConnectDatabase();
        connectBase.OpenDatabase();

        SqlDataReader dataUser = selectAppoint.ExecuteReader();
        Model_Appointlist ModelAppointlist = new Model_Appointlist();
       
        if (dataUser.HasRows)
        {
            ModelAppointlist.return_code = Return.RETURN_CODE_SUCCESS;
            ModelAppointlist.return_description = Return.RETURN_DESCRIPTION_SUCCESS;

            

            while (dataUser.Read())
            {

                Model_Appoint model_Appoint = new Model_Appoint();

                model_Appoint.Appoint_id = Int32.Parse(dataUser[0].ToString());
                model_Appoint.Patient_id = Int32.Parse(dataUser[1].ToString());
                model_Appoint.Firstname = (dataUser[2].ToString());
                model_Appoint.Doctor_id = Int32.Parse(dataUser[3].ToString());
                model_Appoint.DFirstname = (dataUser[4].ToString());
                model_Appoint.AppointDate = (dataUser[5].ToString());
                model_Appoint.Status = (dataUser[6].ToString());

                ModelAppointlist.appointlist.Add(model_Appoint);

            }
            dataUser.Close();

        }
        else
        {
            ModelAppointlist.return_code = Return.RETURN_CODE_ERROR;
            ModelAppointlist.return_description = Return.RETURN_DESCRIPTION_ERROR;
        }
        connectBase.CloseDatabase();

        Context.Response.Write(JsonConvert.SerializeObject(ModelAppointlist));
        Context.Response.End();

    }


}