using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Bai01
{
    public partial class Login : System.Web.UI.Page
    {
        Ketnoi kn = new Ketnoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }

        }

        [Obsolete]
        protected void btndangnhap_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text;
            string password = kn.mahoa(txtpassword.Text);
            string sql = "select * from tblUser where Username='"+username+"' and Password='"+password+"'";
            SqlDataAdapter da = new SqlDataAdapter(sql, kn.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Session["name"] = txtuser.Text; 
                Session["allow"] = true;
                Session["email"] = dt.Rows[0]["Email"].ToString();
                Response.Redirect("Default.aspx");
            }
            else Response.Write("<script>alert('Username/Password chưa đúng')</script>");


        }
    }
}