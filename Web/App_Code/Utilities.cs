using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;



public class Utilities
{
    String conStr = ConfigurationManager.ConnectionStrings["HospitalConnectionString"].ConnectionString;
    
	public Utilities()
	{
		
	}
    public static SqlConnection getConnection()
    {
        string str_Conn = WebConfigurationManager.ConnectionStrings["HospitalConnectionString"].ConnectionString;
        SqlConnection Conn = new SqlConnection(str_Conn);
        return Conn;
    }
   
    public int InsertData(String tablename, Dictionary<String, object> dic)
    {
        SqlConnection sqlcon = new SqlConnection(conStr);
        try
        {
            sqlcon.Open();
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO      " + tablename);
            sb.Append(" (");
            int i = 0;
            List<string> list = new List<string>(dic.Keys);
            foreach (string key in list)
            {
                if (i != 0)
                {
                    sb.Append(",");
                }
                sb.Append(key);
                i++;
            }
            sb.Append(" )");
            sb.Append(" VALUES");
            sb.Append(" (");
            i = 0;
            foreach (string key in list)
            {
                if (i != 0)
                {
                    sb.Append(",");
                }
                sb.Append("@" + i.ToString().PadLeft(2, '0'));
                i++;
            }
            sb.Append(" ); SELECT SCOPE_IDENTITY();");
            SqlCommand sqlcom = new SqlCommand(sb.ToString(), sqlcon);
            i = 0;

            foreach (string key in list)
            {
                sqlcom.Parameters.AddWithValue("@" + i.ToString().PadLeft(2, '0'), dic[key]);
                i++;
            }
            object ins_id = sqlcom.ExecuteScalar();
            
            return Convert.ToInt32(ins_id);
        }
        catch (Exception ex)
        {
            
        }
        finally
        {
            sqlcon.Close();
        }
        return -1;
    }
    public DataTable SelectData(String tablename, String field)
    {
        SqlConnection sqlcon = new SqlConnection(conStr);
        DataTable queryTable = new DataTable();
        try
        {
            sqlcon.Open();
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT      " + field);
            sb.Append(" FROM  " + tablename);
            int i = 0;
            
            
            SqlCommand sqlcom = new SqlCommand(sb.ToString(), sqlcon);
            i = 0;
            
            SqlDataReader reader = sqlcom.ExecuteReader();
            queryTable.Load(reader);
            reader.Close();
            
            return queryTable;
        }
        catch (Exception ex)
        {
            
        }
        finally
        {
            sqlcon.Close();
        }
        return new DataTable();
    }
    public DataTable SelectData(String tablename, String field, String condition, Dictionary<String, object> map)
    {
        SqlConnection sqlcon = new SqlConnection(conStr);
        DataTable queryTable = new DataTable();
        try
        {
            sqlcon.Open();
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT      " + field);
            sb.Append(" FROM  " + tablename);
            int i = 0;
            List<string> whereList = new List<string>(map.Keys);
            sb.Append(" WHERE   " + condition);
            
            SqlCommand sqlcom = new SqlCommand(sb.ToString(), sqlcon);
            i = 0;
            foreach (string key in whereList)
            {
                sqlcom.Parameters.AddWithValue(key, map[key]);
                i++;
            }
            SqlDataReader reader = sqlcom.ExecuteReader();
            queryTable.Load(reader);
            reader.Close();
            
            return queryTable;
        }
        catch (Exception ex)
        {
            
        }
        finally
        {
            sqlcon.Close();
        }
        return new DataTable();
    }
    public DataTable SelectData(String tablename, String field, String condition)
    {
        SqlConnection sqlcon = new SqlConnection(conStr);
        DataTable queryTable = new DataTable();
        
        try
        {
            sqlcon.Open();
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT      " + field);
            sb.Append(" FROM  " + tablename);
            sb.Append(" WHERE   " + condition);
            
            SqlCommand sqlcom = new SqlCommand(sb.ToString(), sqlcon);
            SqlDataReader reader = sqlcom.ExecuteReader();
            
            queryTable.Load(reader);
            reader.Close();
            
            return queryTable;
        }
        catch (Exception ex)
        {
            
        }
        finally
        {
            sqlcon.Close();
        }
        return new DataTable();
    }
    public bool UpdateData(String tablename, String condition, Dictionary<String, object> map, Dictionary<String, object> dic)
    {
        SqlConnection sqlcon = new SqlConnection(conStr);
        try
        {
            sqlcon.Open();
            StringBuilder sb = new StringBuilder();
            sb.Append("Update      " + tablename);
            sb.Append(" SET ");
            int i = 0;
            List<string> list = new List<string>(dic.Keys);
            List<string> whereList = new List<string>(map.Keys);
            foreach (string key in list)
            {
                if (i != 0)
                {
                    sb.Append(",");
                }
                sb.Append(key + " = @" + i.ToString().PadLeft(2, '0'));
                i++;
            }
            sb.Append(" WHERE   " + condition);
            SqlCommand sqlcom = new SqlCommand(sb.ToString(), sqlcon);
            i = 0;
            foreach (string key in whereList)
            {
                sqlcom.Parameters.AddWithValue(key, map[key]);
                i++;
            }
            i = 0;
            foreach (string key in list)
            {
                sqlcom.Parameters.AddWithValue("@" + i.ToString().PadLeft(2, '0'), dic[key]);
                i++;
            }
            sqlcom.ExecuteNonQuery();
            
            return true;
        }
        catch (Exception ex)
        {
            
        }
        finally
        {
            sqlcon.Close();
        }
        return false;
    }

    public bool DeleteData(String tablename, String condition, Dictionary<String, object> map)
    {
        SqlConnection sqlcon = new SqlConnection(conStr);
        try
        {
            sqlcon.Open();
            StringBuilder sb = new StringBuilder();
            sb.Append("DELETE      FROM " + tablename);
            List<string> whereList = new List<string>(map.Keys);
            sb.Append(" WHERE   " + condition);
            SqlCommand sqlcom = new SqlCommand(sb.ToString(), sqlcon);
            int i = 0;
            foreach (string key in whereList)
            {
                sqlcom.Parameters.AddWithValue(key, map[key]);
                i++;
            }
            sqlcom.ExecuteNonQuery();
            
            return true;
        }
        catch (Exception ex)
        {
          
        }
        finally
        {
            sqlcon.Close();
        }
        return false;
    
       
    }
    public String ReplaceStringNull(object text)
    {
        try
        {
            if (text == null)
            {
                return "";
            }
            String str = Convert.ToString(text);
            return str.Trim();
        }
        catch (Exception ex)
        {

        }
        return "";
    }
}