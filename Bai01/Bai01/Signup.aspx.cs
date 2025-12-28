using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;

namespace Bai01
{
    public partial class Signup : System.Web.UI.Page
    {
        Ketnoi kn = new Ketnoi(); // gọi kết csdl 

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                
            }
        }

        [Obsolete]
        protected void btndangky_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text;
            string password = kn.mahoa(txtpassword.Text);
            if(Page.IsValid && FileUpload1.HasFile && Kiemtrafile(FileUpload1.FileName))
            {
                string fileName = "images/" + DateTime.Now.ToString("ddMMyyyy_hhmmss_tt_") + FileUpload1.FileName;
                string filePath = MapPath(fileName);
                FileUpload1.SaveAs(filePath); // 
                string sql = "insert into tbluser(Username,Password,Avatar,Role,Status) values('"+username+"','"+password+"','"+fileName+"',0,0)";
                SqlCommand cmd = new SqlCommand(sql,kn.con);
                kn.con.Open();
                cmd.ExecuteNonQuery();  // 
                kn.con.Close();
                Response.Write("<script>alert('Dang ky thanh cong');</script>");
            }

        }
        bool Kiemtrafile(string filename)
        {
            string ext = Path.GetExtension(filename); // JPG --> jpg JpG, jPG jpg 
            switch (ext.ToLower()) {
                case ".gif":
                    return true;
                case ".png":
                    return true;
                case ".jpg":
                    return true;
                case ".jpeg":
                    return true;
                default:
                    return false;
            }

          
        }
}
}