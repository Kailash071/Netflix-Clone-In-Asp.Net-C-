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
    public partial class signUp21 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if(Session["email"]== null)
            //{
            //    Response.Redirect("signUp1.aspx");
            //}
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Asp.Net   Project\Netflix-clone\App_Data\mainDb.mdf;Integrated Security=True");
            //try
            //{
            //    conn.Open();
            //    Response.Write("connected..");
            //    string update_q = "INSERT INTO users (password) VALUES=(SELECT password from users WHERE email=@email) ";
            //    SqlCommand cmd = new SqlCommand(update_q, conn);
            //    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            //    cmd.Parameters.AddWithValue("@email", Session["email"].ToString());
            //    cmd.ExecuteNonQuery();

            //    Response.Redirect("signUp3.aspx");

            //}
            //catch(Exception ex)
            //{
            //    Response.Write(ex.Message);
            //    Response.Write("not connected");
            //}
            //finally
            //{
            //    conn.Close();
            //}
            ////Response.Redirect("signUp3.aspx");
        }
    }
}