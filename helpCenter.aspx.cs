using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Netflix_clone
{
    public partial class helpCenter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user-email"] == null)
            {
                Response.Redirect("signIn.aspx");
            }
        }

        protected void btnEmail_Click(object sender, EventArgs e)
        {
            Response.Redirect("contactUs.aspx");
        }

        protected void btnPrivacy_Click(object sender, EventArgs e)
        {
            Response.Redirect("privacy.aspx");
        }
    }
}