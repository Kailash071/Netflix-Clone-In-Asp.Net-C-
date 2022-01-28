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
    public partial class uploadMovie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["admin-email"] == null)
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            string fileName = PosterUpload.FileName;
            PosterUpload.PostedFile.SaveAs(Server.MapPath("~/images/upload/poster/"+fileName));
            string imageName = "~/images/upload/poster/" + fileName.ToString();

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Asp.Net   Project\Netflix-clone\App_Data\mainDb.mdf;Integrated Security=True");

            try
            {

                conn.Open();

                string insert_q = "INSERT INTO movies (title,category,director,actors,producer,watchTime,releaseDate,poster,videoLink) VALUES (@title,@category,@director,@actors,@producer,@watchTime,@releaseDate,@poster,@videoLink)";
                SqlCommand cmd = new SqlCommand(insert_q,conn);
                cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                
                cmd.Parameters.AddWithValue("@category", DropDownCategory.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@director", txtDirector.Text);
                cmd.Parameters.AddWithValue("@actors", txtActors.Text);
                cmd.Parameters.AddWithValue("@producer", txtProducer.Text);
                cmd.Parameters.AddWithValue("@watchTime", txtWatchTime.Text);
                cmd.Parameters.AddWithValue("@releaseDate", txtReleaseDate.Text);
                //cmd.Parameters.AddWithValue("@poster", PosterUpload.FileName.ToString());
                cmd.Parameters.AddWithValue("@poster", imageName);
                cmd.Parameters.AddWithValue("@videoLink", txtVideoLink.Text);

                cmd.ExecuteNonQuery();
                Response.Redirect("moviesList.aspx");
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

        protected void btnReset_Click(object sender, EventArgs e)
        {

            txtTitle.Text = "";

            DropDownCategory.SelectedIndex = 0;
            txtDirector.Text = "";
            txtActors.Text = "";
            txtProducer.Text = "";
            txtWatchTime.Text = "";
            txtReleaseDate.Text = "";
            txtVideoLink.Text = "";
        }
    }
}