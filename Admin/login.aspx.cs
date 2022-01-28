using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Netflix_clone.Admin
{
    public partial class signIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["admin-email"] != null)
            {
                Response.Redirect("movieList.aspx");
            }
        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            string password = txtpassword.Text;

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Asp.Net   Project\Netflix-clone\App_Data\mainDb.mdf;Integrated Security=True"); 

            try
            {
                conn.Open();
                string select_q = "SELECT * FROM admin";
                SqlCommand cmd = new SqlCommand(select_q,conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if(dr["email"].ToString() == txtemail.Text && dr["password"].ToString() == txtpassword.Text)
                    {
                        Session["admin-email"] = txtemail.Text;
                        Response.Redirect("moviesList.aspx");
                    }
                    else
                    {
                    
                        Response.Write("<script>alert('Unknown Admin..')</script>");
                    }
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