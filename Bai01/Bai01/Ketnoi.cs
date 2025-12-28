using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Web.Security;

namespace Bai01
{
    public class Ketnoi
    {
      public SqlConnection con = new SqlConnection("Data Source=(local)\\SQLExpress;Initial Catalog=QLHV;Integrated Security=True");

        [Obsolete]
        public string mahoa(string str)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(str.Trim(), "SHA1");
        }
    }
}