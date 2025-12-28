using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai01
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["name"] = null;
            Session["allow"] = null;
            Session["email"] = null;
            Response.Redirect("Default.aspx");
        }
    }
}