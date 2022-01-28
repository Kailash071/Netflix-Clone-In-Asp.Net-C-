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
    public partial class Popular : System.Web.UI.Page
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

            tvShow_netflix();
            tvShow_trending();
            movies_netflix();
            movies_trending();
        }

        protected void tvShow_netflix()
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
                    this.posters_netflixShow.Controls.Add(link);


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

        protected void tvShow_trending()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Asp.Net   Project\Netflix-clone\App_Data\mainDb.mdf;Integrated Security=True");
            try
            {
                conn.Open();

                string select_q = "SELECT * FROM tvShows WHERE category='Romance'";
                SqlCommand cmd = new SqlCommand(select_q, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                int flag = 0;
                while (dr.Read())
                {

                    DynamicHyperLink link = new DynamicHyperLink();
                    link.NavigateUrl = dr["videoLink"].ToString();
                    link.CssClass = "posterImg";
                    link.ImageUrl = dr["poster"].ToString();
                    this.posters_trendingShow.Controls.Add(link);


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

        protected void movies_netflix()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Asp.Net   Project\Netflix-clone\App_Data\mainDb.mdf;Integrated Security=True");
            try
            {
                conn.Open();

                string select_q = "SELECT * FROM movies WHERE category='Netflix'";
                SqlCommand cmd = new SqlCommand(select_q, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                int flag = 0;
                while (dr.Read())
                {

                    DynamicHyperLink link = new DynamicHyperLink();
                    link.NavigateUrl = dr["videoLink"].ToString();
                    link.CssClass = "posterImg";
                    link.ImageUrl = dr["poster"].ToString();
                    this.posters_netflixMovie.Controls.Add(link);


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

        protected void movies_trending()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Asp.Net   Project\Netflix-clone\App_Data\mainDb.mdf;Integrated Security=True");
            try
            {
                conn.Open();

                string select_q = "SELECT * FROM movies WHERE category='Romance'";
                SqlCommand cmd = new SqlCommand(select_q, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                int flag = 0;
                while (dr.Read())
                {

                    DynamicHyperLink link = new DynamicHyperLink();
                    link.NavigateUrl = dr["videoLink"].ToString();
                    link.CssClass = "posterImg";
                    link.ImageUrl = dr["poster"].ToString();
                    this.posters_trendingMovie.Controls.Add(link);


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