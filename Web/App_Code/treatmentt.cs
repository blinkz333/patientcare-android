using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;
using Newtonsoft.Json;
using System.Web.Script.Services;

/// <summary>
/// Summary description for treatmentt
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
[ScriptService]
public class treatmentt : System.Web.Services.WebService
{
    
    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

    public void Treatment(String patient_id)
    {
        ConnectDatabase connectBase = new ConnectDatabase();
        SqlCommand selectTreat = new SqlCommand();

        selectTreat.CommandText = "Select t.Treat_id, p.Patient_id, p.Firstname , t.Treatdate,t.Weight, t.Height, t.Pulse, t.Respiratory_rate, t.Bloodpressure, t.Condition, t.Treatdetail From PATIENT p , TREATMENT t Where p.Patient_id = t.Patient_id AND p.Patient_id = @TextBoxid";

        selectTreat.Parameters.AddWithValue("@TextBoxid", patient_id);
        

        selectTreat.Connection = connectBase.getConnectDatabase();
        connectBase.OpenDatabase();

        SqlDataReader dataUser = selectTreat.ExecuteReader();

        Model_Treatlist ModelTreatlist = new Model_Treatlist();

        if (dataUser.HasRows)
        {
            ModelTreatlist.return_code = Return.RETURN_CODE_SUCCESS;
            ModelTreatlist.return_description = Return.RETURN_DESCRIPTION_SUCCESS;

            

            while (dataUser.Read())
            {
                Model_Treat model_Treat = new Model_Treat();

                model_Treat.Treat_id = Int32.Parse(dataUser[0].ToString());
                model_Treat.Patient_id = Int32.Parse(dataUser[1].ToString());
                model_Treat.Firstname = (dataUser[2].ToString());
                model_Treat.Treatdate = (dataUser[3].ToString());
                model_Treat.Weight = Double.Parse(dataUser[4].ToString());
                model_Treat.height = Double.Parse(dataUser[5].ToString());
                model_Treat.Pulse = Int32.Parse(dataUser[6].ToString());
                model_Treat.Respiratory = Int32.Parse(dataUser[7].ToString());
                model_Treat.Bloodpressure = (dataUser[8].ToString());
                model_Treat.Condition = (dataUser[9].ToString());
                model_Treat.Treatdetail = (dataUser[10].ToString());

                ModelTreatlist.treatlist.Add(model_Treat);

            }
            dataUser.Close();

        }
        else
        {
            ModelTreatlist.return_code = Return.RETURN_CODE_ERROR;
            ModelTreatlist.return_description = Return.RETURN_DESCRIPTION_ERROR;
        }
        connectBase.CloseDatabase();

        Context.Response.Write(JsonConvert.SerializeObject(ModelTreatlist));
        Context.Response.End();

    }


}