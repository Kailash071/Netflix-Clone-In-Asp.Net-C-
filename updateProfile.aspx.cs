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
    public partial class updateProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            if (id == null)
            {
                Response.Redirect("profile.aspx");
            }
            if(Session["user-email"] == null)
            {
                Response.Redirect("signIn.aspx");
            }

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Asp.Net   Project\Netflix-clone\App_Data\mainDb.mdf;Integrated Security=True");

            try
            {
                conn.Open();

                string select_q = "SELECT name,email,password FROM users WHERE id =@id";
                SqlCommand cmd = new SqlCommand(select_q, conn);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (!Page.IsPostBack)
                    {
                        txtName.Text = dr["name"].ToString();
                        
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Asp.Net   Project\Netflix-clone\App_Data\mainDb.mdf;Integrated Security=True");

            try
            {
                conn.Open();

                String update_q = "UPDATE users SET name=@name,password=@password WHERE id=@id";
                SqlCommand cmd = new SqlCommand(update_q, conn);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                Response.Write("<script>alert('Successfully Updated...')</script>");
                Response.Redirect("home.aspx");
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