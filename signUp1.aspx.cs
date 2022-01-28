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
    public partial class signUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["email"] != null)
            {
                Response.Redirect("signUp3.aspx");
            }
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Asp.Net   Project\Netflix-clone\App_Data\mainDb.mdf;Integrated Security=True");

            try
            {
                conn.Open();
                try
                {
                    string select_q = "SELECT email FROM users WHERE email =@email";
                    SqlCommand cmd = new SqlCommand(select_q, conn);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        Response.Write("<script>alert('User Already Exists..')</script>");
                    }
                    else
                    {
                        conn.Close();
                        conn.Open();

                        string Insert_q = "INSERT INTO users (name,email,password) VALUES (@name,@email,@password)";
                        SqlCommand cmd1 = new SqlCommand(Insert_q, conn);
                        cmd1.Parameters.AddWithValue("@name", txtName.Text);
                        cmd1.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd1.Parameters.AddWithValue("@password", txtPassword.Text);
                       if(txtName.Text == "" && txtEmail.Text == "" && txtPassword.Text == "")
                        {
                            Response.Write("<script>alert('Fill up the form')</script>");
                        }
                        else
                        {

                        cmd1.ExecuteNonQuery();
                        //Response.Write("<script>alert('Successfully Signed Up')</script>");
                        Session["email"] = txtEmail.Text;
                        Response.Redirect("signUp3.aspx");
                            txtEmail.Text = "";
                            txtName.Text = "";
                            txtPassword.Text = "";
                        }

                    }
                }catch(Exception ex)
                {
                    Response.Write(ex.Message);
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
            //  Response.Redirect("signUp2.aspx");
            /*
             if(pswrd_textbox.Text== " ") //pswrd.textbox is a password textbox
                {
            MessageBox.Show("This field cannot left empty!");
                }
             */

            /*
            if(pswrd_textbox.Text.Trim() == string.Empty)
            {
            MessageBox.Show("This Field cannot left empty!");
            }
            */

            /*
            if( string.IsNullOrEmpty(pswrd_textbox.Text))
            {
            MessageBox.Show("Don't left this field Empty!");
            }
            */
        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            Response.Redirect("signIn.aspx");
        }
    }
}