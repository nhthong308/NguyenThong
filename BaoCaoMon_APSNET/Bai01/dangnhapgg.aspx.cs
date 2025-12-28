using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASPSnippets.GoogleAPI;
using System.Web.Script.Serialization;

namespace Bai01
{
    public partial class dangnhapgg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GoogleConnect.ClientId = "122924362316-8mf97205qelp1lfqk714h6sg2l6mr57i.apps.googleusercontent.com"; //google; console; tạo project. URI,address => clientId, Clientsecret
            GoogleConnect.ClientSecret = "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";
            GoogleConnect.RedirectUri = Request.Url.AbsoluteUri.Split('?')[0];

            if (!this.IsPostBack)
            {
                if (!string.IsNullOrEmpty(Request.QueryString["code"]))
                {
                    string code = Request.QueryString["code"];
                    string json = GoogleConnect.Fetch("me", code);
                    GoogleProfile profile = new JavaScriptSerializer().Deserialize<GoogleProfile>(json);

                    lblName.Text = profile.Name;
                    lblEmail.Text = profile.Email;

                    ProfileImage.ImageUrl = profile.Picture;
                    pnlProfile.Visible = true;
                    btnLogin.Enabled = false;
                    btnLogin.Visible = false;
                    Session["email"] = lblEmail.Text;
                    // session..
                }
                if (Request.QueryString["error"] == "access_denied")
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('Access denied.')", true);
                }
            }
        }
        protected void Login(object sender, EventArgs e)
        {
            GoogleConnect.Authorize("profile", "email");
        }
        protected void Clear(object sender, EventArgs e)
        {
            GoogleConnect.Clear(Request.QueryString["code"]);
            Session["email"] = null;
        }

        public class GoogleProfile
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Picture { get; set; }
            public string Email { get; set; }
            public string Verified_Email { get; set; }
        }
    }
}