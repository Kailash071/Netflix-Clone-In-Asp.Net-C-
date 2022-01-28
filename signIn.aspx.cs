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
    public partial class logIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user-email"] != null)
            {
                Response.Redirect("home.aspx");
            }       
             
           
        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Asp.Net   Project\Netflix-clone\App_Data\mainDb.mdf;Integrated Security=True");

            try
            {
                conn.Open();

                string select_q = "SELECT email,password FROM users WHERE email=@email AND password=@password";
                SqlCommand cmd = new SqlCommand(select_q, conn);
                cmd.Parameters.AddWithValue("@email", txtemail.Text);
                cmd.Parameters.AddWithValue("@password", txtpassword.Text);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Session["user-email"] = txtemail.Text;

                    if(Session["user-email"] != null)
                    {
                        Response.Redirect("home.aspx");
                        txtemail.Text = "";
                        txtpassword.Text = "";
                    }
                }
                else
                {
                    Response.Write("<script>alert('Invalid Information..')</script>");
                }

            }catch(Exception ex)
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
