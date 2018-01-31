using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;

public partial class Changepass : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(@"workstation id=nfcHospital.mssql.somee.com;packet size=4096;user id=tongtnp012_SQLLogin_1;pwd=16inyljyfb;data source=nfcHospital.mssql.somee.com;persist security info=False;initial catalog=nfcHospital; ");
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    

    protected void bttsave_Click(object sender, EventArgs e)
    {
        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From ADMIN Where username LIKE '" + Session["Username"] + "' AND password LIKE '" + txtoldpass.Text + "'", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {

                String str = "update ADMIN set password=@pass where username=@u_name and password=@oldpass ";
                cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("oldpass", txtoldpass.Text);
                cmd.Parameters.AddWithValue("pass", txtnewpass.Text);
                cmd.Parameters.AddWithValue("u_name", Session["Username"]);



            }
            Response.Write("<script>alert('Hello');</script>");
            conn.Close();

        }
        catch (Exception)
        {

        }
    }
}