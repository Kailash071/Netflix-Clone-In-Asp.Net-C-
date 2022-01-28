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
    public partial class tvShows : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user-email"] == null)
            {
                Response.Redirect("signIn.aspx");
            }else
            {
                Response.ClearHeaders();
                Response.AddHeader("Cache-Control", "no-cache, no-store, max-age=0, must-revalidate");
                Response.AddHeader("Pragma", "no-cache");
            }

            tvShow_trending();
            tvShow_romance();
            tvShow_sciFi();
            tvShow_thriller();
            tvShow_adventure();
            tvShow_comedy();
        }
        protected void tvShow_trending()
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

        protected void tvShow_romance()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Asp.Net   Project\Netflix-clone\App_Data\mainDb.mdf;Integrated Security=True");
            try
            {
                conn.Open();

                string select_q = "SELECT * FROM tvShows WHERE category='romance'";
                SqlCommand cmd = new SqlCommand(select_q, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                int flag = 0;
                while (dr.Read())
                {

                    DynamicHyperLink link = new DynamicHyperLink();
                    link.NavigateUrl = dr["videoLink"].ToString();
                    link.CssClass = "posterImg";
                    link.ImageUrl = dr["poster"].ToString();
                    this.posters_romance.Controls.Add(link);


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
        protected void tvShow_sciFi()
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
        protected void tvShow_thriller()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Asp.Net   Project\Netflix-clone\App_Data\mainDb.mdf;Integrated Security=True");
            try
            {
                conn.Open();

                string select_q = "SELECT * FROM tvShows WHERE category='Thriller'";
                SqlCommand cmd = new SqlCommand(select_q, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                int flag = 0;
                while (dr.Read())
                {

                    DynamicHyperLink link = new DynamicHyperLink();
                    link.NavigateUrl = dr["videoLink"].ToString();
                    link.CssClass = "posterImg";
                    link.ImageUrl = dr["poster"].ToString();
                    this.posters_thriller.Controls.Add(link);


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
        protected void tvShow_adventure()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Asp.Net   Project\Netflix-clone\App_Data\mainDb.mdf;Integrated Security=True");
            try
            {
                conn.Open();

                string select_q = "SELECT * FROM tvShows WHERE category='Adventure'";
                SqlCommand cmd = new SqlCommand(select_q, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                int flag = 0;
                while (dr.Read())
                {

                    DynamicHyperLink link = new DynamicHyperLink();
                    link.NavigateUrl = dr["videoLink"].ToString();
                    link.CssClass = "posterImg";
                    link.ImageUrl = dr["poster"].ToString();
                    this.posters_adventure.Controls.Add(link);


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
        protected void tvShow_comedy()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Asp.Net   Project\Netflix-clone\App_Data\mainDb.mdf;Integrated Security=True");
            try
            {
                conn.Open();

                string select_q = "SELECT * FROM tvShows WHERE category='Comedy'";
                SqlCommand cmd = new SqlCommand(select_q, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                int flag = 0;
                while (dr.Read())
                {

                    DynamicHyperLink link = new DynamicHyperLink();
                    link.NavigateUrl = dr["videoLink"].ToString();
                    link.CssClass = "posterImg";
                    link.ImageUrl = dr["poster"].ToString();
                    this.posters_comedy.Controls.Add(link);


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