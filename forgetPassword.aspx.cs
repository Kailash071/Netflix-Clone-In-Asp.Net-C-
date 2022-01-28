using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Netflix_clone
{
    public partial class forgetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            Response.Redirect("signIn.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Asp.Net   Project\Netflix-clone\App_Data\mainDb.mdf;Integrated Security=True");

            try
            {
                conn.Open();
                string select_q = "SELECT email FROM users WHERE email=@email";
                SqlCommand cmd = new SqlCommand(select_q, conn);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    try
                    {
                        conn.Close();
                        conn.Open();
                        string update_q = "UPDATE users SET password=@password WHERE email=@email";
                        SqlCommand cmd1 = new SqlCommand(update_q, conn);
                        cmd1.Parameters.AddWithValue("@password", txtPassword.Text);
                        cmd1.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd1.ExecuteNonQuery();
                        Response.Redirect("signIn.aspx");
                    }
                    catch(Exception ex)
                    {
                        Response.Write(ex.Message);

                    }
                }
                else
                {
                Response.Write("<script>alert('Invalid Email..')</script>");
                }
              
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}