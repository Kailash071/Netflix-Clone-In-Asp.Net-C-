using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Netflix_clone
{
    public partial class signUp2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] == null)
            {
                Response.Redirect("signUp1.aspx");
            }
          

        }

        protected void btnFinish_Click(object sender, EventArgs e)
        {
            Session["email"] = null;
            Response.Redirect("signIn.aspx");
        }
    }
}