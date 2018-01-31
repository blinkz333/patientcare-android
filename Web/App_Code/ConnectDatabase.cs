using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;


public class ConnectDatabase
{
    private SqlConnection connectDatabase;
    private String connectString = ConfigurationManager.ConnectionStrings["HospitalConnectionString"].ConnectionString;

    public ConnectDatabase()
    {
        connectDatabase = new SqlConnection(connectString);
    }
    public void OpenDatabase()
    {
        if (connectDatabase.State.ToString() == "Closed")
        {
            connectDatabase.Open();
        }
    }
    public void CloseDatabase()
    {
        
            connectDatabase.Close();
        
    }
    public SqlConnection getConnectDatabase()
    {
        return connectDatabase;
    }
}