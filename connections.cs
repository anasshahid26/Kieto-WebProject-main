using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Web.Security;

namespace WebProject
{
    public class connections
    {
       public static SqlConnection sql;
        public static SqlConnection connect()
        {
            if (sql==null)
            {
                sql = new SqlConnection();
                sql.ConnectionString = @"Data Source = MUHAMMADANAS\SQLEXPRESS; Initial Catalog = KIETEO_Recovered; Integrated Security = SSPI";
                sql.Open();
            }
            return sql;
        }
    }
}
