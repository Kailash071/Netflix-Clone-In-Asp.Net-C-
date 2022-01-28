using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.DynamicData;

namespace Netflix_clone
{
    public partial class home1 : System.Web.UI.Page
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

            Movie_only_netflix();
            Movies_trending();
            movies_romance();
            shows_sci_fi();
        }

        protected void Movies_trending()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Asp.Net   Project\Netflix-clone\App_Data\mainDb.mdf;Integrated Security=True");
            try
            {
                conn.Open();

                string select_q = "SELECT * FROM tvShows WHERE category='Netflix'";
                SqlCommand cmd = new SqlCommand(select_q, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                int flag = 0;
                while (dr.Read())
                {

                    DynamicHyperLink link = new DynamicHyperLink();
                    link.NavigateUrl = dr["videoLink"].ToString();
                    link.CssClass = "posterImg";
                    link.ImageUrl = dr["poster"].ToString();
                    this.posters_trending.Controls.Add(link);

                    //HyperLink playLink = new HyperLink();
                    //playLink.NavigateUrl = dr["videoLink"].ToString();
                    //playLink.ImageUrl = "images/plus.png";
                    //playLink.CssClass = "playImg";
                    //  this.posterInfo.Controls.Add(playLink);

                    //    HyperLink FavLink = new HyperLink();
                    //    FavLink.NavigateUrl = "favourite.aspx?id=" + dr["id"].ToString();
                    //    FavLink.ImageUrl = "images/plus.png";
                    //    FavLink.CssClass = "addImg";
                    ////  this.addDiv.Controls.Add(FavLink);


                    flag = 1;
                }
                if (flag == 0)
                {
                    // Response.Write("nothing to show...");
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
        protected void Movie_only_netflix()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Asp.Net   Project\Netflix-clone\App_Data\mainDb.mdf;Integrated Security=True");
            try
            {
                conn.Open();

                string select_q = "SELECT * FROM movies WHERE category='Netflix' ";
                SqlCommand cmd = new SqlCommand(select_q, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                int flag = 0;
                while (dr.Read())
                {

                    DynamicHyperLink link = new DynamicHyperLink();
                    link.NavigateUrl = dr["videoLink"].ToString();
                    link.CssClass = "posterImg";
                    link.ImageUrl = dr["poster"].ToString();
                    this.posters_only_on_netflix.Controls.Add(link);

                  

                    flag = 1;
                }
                if (flag == 0)
                {
                    // Response.Write("nothing to show...");
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
        protected void movies_romance()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Asp.Net   Project\Netflix-clone\App_Data\mainDb.mdf;Integrated Security=True");
            try
            {
                conn.Open();

                string select_q = "SELECT * FROM movies WHERE category='Romance' ";
                SqlCommand cmd = new SqlCommand(select_q, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                int flag = 0;
                while (dr.Read())
                {

                    DynamicHyperLink link = new DynamicHyperLink();
                    link.NavigateUrl = dr["videoLink"].ToString();
                    link.CssClass = "posterImg";
                    link.ImageUrl = dr["poster"].ToString();
                    this.poster_romance.Controls.Add(link);

                  
                    flag = 1;
                }
                if (flag == 0)
                {
                    // Response.Write("nothing to show...");
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
        protected void shows_sci_fi()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Asp.Net   Project\Netflix-clone\App_Data\mainDb.mdf;Integrated Security=True");
            try
            {
                conn.Open();

                string select_q = "SELECT * FROM tvShows WHERE category='Sci-Fi'";
                SqlCommand cmd = new SqlCommand(select_q, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                int flag = 0;
                while (dr.Read())
                {

                    DynamicHyperLink link = new DynamicHyperLink();
                    link.NavigateUrl = dr["videoLink"].ToString();
                    link.CssClass = "posterImg";
                    link.ImageUrl = dr["poster"].ToString();
                    this.posters_sci_fi.Controls.Add(link);

                    flag = 1;
                }
                if (flag == 0)
                {
                    // Response.Write("nothing to show...");
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
    }
}