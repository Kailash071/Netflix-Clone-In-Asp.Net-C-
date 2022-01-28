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
    public partial class editMovies : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            if (Session["admin-email"] == null)
            {
                Response.Redirect("login.aspx");
            }
            if (id == null)
            {
                Response.Redirect("moviesList.aspx");
            }
            if (!Page.IsPostBack)
            {
              //  Response.Write("page not postback");
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Asp.Net   Project\Netflix-clone\App_Data\mainDb.mdf;Integrated Security=True");

                try
                {
                    conn.Open();

                    string select_q = "SELECT * FROM movies WHERE id=@id";
                    SqlCommand cmd = new SqlCommand(select_q, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader dr = cmd.ExecuteReader();

                    int flag = 0;
                    while (dr.Read())
                    {


                        txtTitle.Text = dr["title"].ToString();
                      
                        DropDownCategory.SelectedValue = dr["category"].ToString();
                        txtDirector.Text = dr["director"].ToString();
                        txtActors.Text = dr["actors"].ToString();
                        txtProducer.Text = dr["producer"].ToString();
                        txtWatchTime.Text = dr["watchTime"].ToString();
                        txtReleaseDate.Text = dr["releaseDate"].ToString();
                        txtVideoLink.Text = dr["videoLink"].ToString();
                        flag = 1;
                    }
                    if (flag == 0)
                    {
                        Response.Write("No Record to show...");
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
           // else
            //{
            //    Response.Write("page is postback");
            //}
           
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Asp.Net   Project\Netflix-clone\App_Data\mainDb.mdf;Integrated Security=True");


                try
                {
                    conn.Open();

                    string update_q = "UPDATE movies SET " +
                    "title=@title," +
                    "category=@category," +
                    "director=@director," +
                    "actors=@actors," +
                    "producer=@producer," +
                    "watchTime=@watchTime," +
                    "releaseDate=@releaseDate," +
                    "videoLink=@videoLink" +
                    " WHERE id=@id";
                    SqlCommand cmd = new SqlCommand(update_q, conn);

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                  
                    cmd.Parameters.AddWithValue("@category", DropDownCategory.SelectedItem.Text);
                    cmd.Parameters.AddWithValue("@director", txtDirector.Text);
                    cmd.Parameters.AddWithValue("@actors", txtActors.Text);
                    cmd.Parameters.AddWithValue("@producer", txtProducer.Text);
                    cmd.Parameters.AddWithValue("@watchTime", txtWatchTime.Text);
                    cmd.Parameters.AddWithValue("@releaseDate", txtReleaseDate.Text);
                    cmd.Parameters.AddWithValue("@videoLink", txtVideoLink.Text);

                    cmd.ExecuteNonQuery();
                //Response.Write("id:" + id);
                //Response.Write("title:"+txtTitle.Text);
                //Response.Write("Desc:" + txtDescription.Text);
                //Response.Write("category:" + DropDownCategory.SelectedItem.Text);
                //Response.Write("Dire:" + txtDirector.Text);
                //Response.Write("actor:" + txtActors.Text);
                //Response.Write("produ:" + txtProducer.Text);
                //Response.Write("watch:" + txtWatchTime.Text);
                //Response.Write("release:" + txtReleaseDate.Text);
                //Response.Write("link:" + txtVideoLink.Text);
                 Response.Redirect("moviesList.aspx");

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

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
           
            DropDownCategory.SelectedIndex=0;
            txtDirector.Text = "";
           txtActors.Text = "";
           txtProducer.Text = "";
           txtWatchTime.Text = "";
           txtReleaseDate.Text = "";
           txtVideoLink.Text = "";
        }
    }
}