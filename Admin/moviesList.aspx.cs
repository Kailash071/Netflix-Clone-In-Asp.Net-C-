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
    public partial class moviesList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin-email"] == null)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Asp.Net   Project\Netflix-clone\App_Data\mainDb.mdf;Integrated Security=True");

                try
                {
                    conn.Open();

                    string select_q = "SELECT * FROM movies ORDER BY category";
                    SqlCommand cmd = new SqlCommand(select_q, conn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    int flag = 0;
                    while (dr.Read())
                    {
                        TableRow tr = new TableRow();

                        TableCell td_id = new TableCell();
                        td_id.ID = "id";
                        td_id.Text = dr["id"].ToString();
                        tr.Cells.Add(td_id);

                        TableCell td_title = new TableCell();
                        td_title.ID = "title";
                        td_title.Text = dr["title"].ToString();
                        tr.Cells.Add(td_title);

                        //TableCell td_desc = new TableCell();
                        //td_desc.ID = "description";
                        //td_desc.Text = dr["description"].ToString();
                        //tr.Cells.Add(td_desc);

                        TableCell td_cate = new TableCell();
                        td_cate.ID = "category";
                        td_cate.Text = dr["category"].ToString();
                        tr.Cells.Add(td_cate);

                        TableCell td_dir = new TableCell();
                        td_dir.ID = "director";
                        td_dir.Text = dr["director"].ToString();
                        tr.Cells.Add(td_dir);

                        TableCell td_act = new TableCell();
                        td_act.ID = "actors";
                        td_act.Text = dr["actors"].ToString();
                        tr.Cells.Add(td_act);

                        TableCell td_pro = new TableCell();
                        td_pro.ID = "producer";
                        td_pro.Text = dr["producer"].ToString();
                        tr.Cells.Add(td_pro);

                        TableCell td_time = new TableCell();
                        td_time.ID = "watchTime";
                        td_time.Text = dr["watchTime"].ToString();
                        tr.Cells.Add(td_time);

                        TableCell td_date = new TableCell();
                        td_date.ID = "releaseDate";
                        td_date.Text = dr["releaseDate"].ToString();
                        tr.Cells.Add(td_date);

                        TableCell td_link = new TableCell();
                        td_link.ID = "videoLink";
                        td_link.Text = dr["videoLink"].ToString();
                        tr.Cells.Add(td_link);

                        TableCell td_action = new TableCell();
                        td_action.ColumnSpan = 2;
                        td_action.ID = "btn";


                        Button btnEdit = new Button();
                        btnEdit.Text = "EDIT";
                        btnEdit.ID = "btnEdit";
                        btnEdit.PostBackUrl = "editMovies.aspx?id=" + dr["id"].ToString();


                        td_action.Controls.Add(btnEdit);

                        Button btnDelete = new Button();
                        btnDelete.Text = "DELETE";
                        btnDelete.ID = "btnDelete";
                        btnDelete.PostBackUrl = "deleteMovies.aspx?id=" + dr["id"].ToString();
                        td_action.Controls.Add(btnDelete);
                        tr.Cells.Add(td_action);

                        myTable.Rows.Add(tr);

                        //btnEdit.PostBackUrl = "editMovies.aspx?id=" + dr["id"].ToString();
                        //btnDelete.PostBackUrl = "deleteMovies.aspx?id=" + dr["id"].ToString();

                        //id.InnerText = dr["id"].ToString();
                        //title.InnerText = dr["title"].ToString();
                        //description.InnerText = dr["description"].ToString();
                        //category.InnerText = dr["category"].ToString();
                        //director.InnerText = dr["director"].ToString();
                        //actors.InnerText = dr["actors"].ToString();
                        //producer.InnerText = dr["producer"].ToString();
                        //watchTime.InnerText = dr["watchTime"].ToString();
                        //releaseDate.InnerText = dr["releaseDate"].ToString();
                        //videoLink.InnerText = dr["videoLink"].ToString();


                        flag = 1;
                    }
                    if (flag == 0)
                    {
                        txtNothing.InnerText = "No Record to show...";
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

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session["admin-email"] = null;
            Session.Clear();
            Response.Redirect("login.aspx");
        }
    }
}