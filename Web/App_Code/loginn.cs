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
/// Summary description for loginn
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
[ScriptService]
public class loginn : System.Web.Services.WebService
{

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public void loginUser(String username, String password)
    {
        ConnectDatabase connectBase = new ConnectDatabase();
        SqlCommand selectUser = new SqlCommand();

        selectUser.CommandText = "Select p.Patient_id, p.Firstname, p.Lastname, p.Nickname, p.Birth, p.Gender, p.Address, p.Email, p.Tel, p.Id_card," +
            "p.ChronicD, p.Bloodtype, p.Rh, p.Allergydrug, p.Cousin, p.Cousintell, p.username, p.password From PATIENT p " +
            "Where username = @TextBoxUN and password = @TextBoxPW";

        selectUser.Parameters.AddWithValue("@TextBoxUN", username);
        selectUser.Parameters.AddWithValue("@TextBoxPW", password);

        selectUser.Connection = connectBase.getConnectDatabase();
        connectBase.OpenDatabase();

        SqlDataReader dataUser = selectUser.ExecuteReader();
        Model_Login modelLogin = new Model_Login();
        if (dataUser.HasRows)
        {
            modelLogin.return_code = Return.RETURN_CODE_SUCCESS;
            modelLogin.return_description = Return.RETURN_DESCRIPTION_SUCCESS;

            modelLogin.user_profile = new Model_User();

            while (dataUser.Read())
            {
                modelLogin.user_profile.Patient_id = Int32.Parse(dataUser[0].ToString());
                modelLogin.user_profile.Firstname = (dataUser[1].ToString());
                modelLogin.user_profile.Lastname = (dataUser[2].ToString());
                modelLogin.user_profile.Nickname = (dataUser[3].ToString());
                modelLogin.user_profile.Birth = (dataUser[4].ToString());
                modelLogin.user_profile.Gender = (dataUser[5].ToString());
                modelLogin.user_profile.Address = (dataUser[6].ToString());
                modelLogin.user_profile.Email = (dataUser[7].ToString());
                modelLogin.user_profile.Tel = (dataUser[8].ToString());
                modelLogin.user_profile.Id_card = Int64.Parse(dataUser[9].ToString());
                modelLogin.user_profile.ChronicD = (dataUser[10].ToString());
                modelLogin.user_profile.Bloodtype = (dataUser[11].ToString());
                modelLogin.user_profile.Rh = (dataUser[12].ToString());
                modelLogin.user_profile.Allergydrug = (dataUser[13].ToString());
                modelLogin.user_profile.Cousin = (dataUser[14].ToString());
                modelLogin.user_profile.Cousintell = (dataUser[15].ToString());
                modelLogin.user_profile.username = (dataUser[16].ToString());
                modelLogin.user_profile.password = (dataUser[17].ToString());
                
            }
            dataUser.Close();

        }
        else
        {
            modelLogin.return_code = Return.RETURN_CODE_ERROR;
            modelLogin.return_description = Return.RETURN_DESCRIPTION_ERROR;
        }
        connectBase.CloseDatabase();

        Context.Response.Write(JsonConvert.SerializeObject(modelLogin));
        Context.Response.End();

    }


}