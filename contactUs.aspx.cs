using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Net.Mail;
using System.Net;
using System.Web.Mail;
using MailMessage = System.Net.Mail.MailMessage;
using MailPriority = System.Net.Mail.MailPriority;

namespace Netflix_clone
{
    public partial class contactUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user-email"] == null)
            {
                Response.Redirect("signIn.aspx");
            }
            else
            {
                Response.ClearHeaders();
                Response.AddHeader("Cache-Control", "no-cache, no-store, max-age=0, must-revalidate");
                Response.AddHeader("Pragma", "no-cache");
            }

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Asp.Net   Project\Netflix-clone\App_Data\mainDb.mdf;Integrated Security=True");

            try
            {
                conn.Open();

                string select_q = "SELECT name FROM users WHERE email=@email";
                SqlCommand cmd = new SqlCommand(select_q, conn);
                cmd.Parameters.AddWithValue("@email", Session["user-email"].ToString());

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    profileName.Text = "Hi, " + dr["name"].ToString();
                }
                else
                {
                    Response.Write("INVALID_USER_NAME");
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
        protected void profileName_Click(object sender, EventArgs e)
        {
            LinkButton LbProfile = new LinkButton();
            LinkButton LbLogOut = new LinkButton();
            LinkButton helpCenter = new LinkButton();

            LbProfile.Text = "Profile";
            LbLogOut.Text = "Log Out";
            helpCenter.Text = "Help Center";
            this.profileAction.Controls.Add(LbProfile);
            this.profileAction.Controls.Add(helpCenter);
            this.profileAction.Controls.Add(LbLogOut);
            LbProfile.CssClass = "profileCss";
            LbLogOut.CssClass = "logOutCss";
            helpCenter.CssClass = "helpCenter";

            helpCenter.PostBackUrl = "helpCenter.aspx";
            LbLogOut.PostBackUrl = "logOut.aspx";

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Asp.Net   Project\Netflix-clone\App_Data\mainDb.mdf;Integrated Security=True");

            try
            {
                conn.Open();

                string select_q1 = "SELECT id FROM users WHERE email=@email";
                SqlCommand cmd1 = new SqlCommand(select_q1, conn);
                cmd1.Parameters.AddWithValue("@email", Session["user-email"].ToString());
                SqlDataReader dr = cmd1.ExecuteReader();

                if (dr.Read())
                {
                    LbProfile.PostBackUrl = "profile.aspx?id=" + dr["Id"].ToString();
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

        protected void btnSend_Click(object sender, EventArgs e)
        {

            string to = txtEmail.Text;
            string sub = txtSubject.Text;
            string desc = txtDesc.Text;

            Response.Redirect("mailto://" + to + "?subject=" + sub + "&body=" + desc);

        }
    }
}