using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Netflix_clone
{
    public partial class privacy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user-email"] == null)
            {
                Response.Redirect("signIn.aspx");
            }
        }
    }
}