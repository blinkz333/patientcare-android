using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;

public partial class Login : System.Web.UI.Page
{

    //SqlConnection conn = new SqlConnection(@"workstation id=nfcHospital.mssql.somee.com;packet size=4096;user id=tongtnp012_SQLLogin_1;pwd=16inyljyfb;data source=nfcHospital.mssql.somee.com;persist security info=False;initial catalog=nfcHospital" );
    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JCCCHB0;Initial Catalog=Hospital;User ID=sa;Password=1234");
    protected void Page_Load(object sender, EventArgs e)
    {


    }

    

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void btn1_Click1(object sender, EventArgs e)
    {
        if (TextBoxUN.Text == "" || TextBoxPW.Text == "")
        {
            Response.Write("<script>alert('กรุณากรอกข้อมูล');</script>");
            
        }
        else
        {

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * From ADMIN Where username LIKE '" + TextBoxUN.Text + "' AND password LIKE '" + TextBoxPW.Text + "'", conn);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Session["Username"] = dr["username"].ToString();
                    Response.Redirect("Managepatient.aspx");

                }
                conn.Close();
                Response.Write("<script>alert('ชื่อผู้ใช้หรือรหัสผ่านผิดพลาด');</script>");
                TextBoxUN.Text = "";
                TextBoxPW.Text = "";

            }
            catch (Exception)
            {

            }
        }
        }
    }
