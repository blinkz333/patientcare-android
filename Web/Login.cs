using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;
using Newtonsoft.Json;
using System.Web.Script.Services;

[ScriptService]
public class Login1 : System.Web.Services.WebService {

    

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public void loginUser(String username,String password)
    {
        ConnectDatabase connectBase = new ConnectDatabase();
        SqlCommand selectUser = new SqlCommand();

        selectUser.CommandText = "Select Patient_id,username,password" +
                                 "From PATIENT Where username = @TextBoxUN and password = @TextBoxPW";

        selectUser.Parameters.AddWithValue("@TextBoxUN", username);
        selectUser.Parameters.AddWithValue("@TextBoxPW", password);

        selectUser.Connection = connectBase.getConnectDatabase();
        connectBase.OpenDatabase();

        SqlDataReader dataUser = selectUser.ExecuteReader();
        Model_Login modelLogin = new Model_Login();
        if(dataUser.HasRows)
        {
            //modelLogin.return_code = Return.RETURN_CODE_SUCCESS;
            //modelLogin.return_description = Return.RETURN_DESCRIPTION_SUCCESS;

            modelLogin.user_profile = new Model_User();

            while (dataUser.Read())
            {
                modelLogin.user_profile.Patient_id = Int32.Parse(dataUser[0].ToString());
                modelLogin.user_profile.username = (dataUser[1].ToString());
                modelLogin.user_profile.password = (dataUser[2].ToString());
            }
            dataUser.Close();

        }
        else
        {
            //modelLogin.return_code = Return.RETURN.CODE_ERROR;
            //modelLogin.return_description = Return.RETURN_DESCRIPTION_ERROR;
        }
        connectBase.CloseDatabase();

        Context.Response.Write(JsonConvert.SerializeObject(modelLogin));
        Context.Response.End();

            }
    
    
}

