using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using WebProject.Models;
using System.Web.Security;
using System.Web.Routing;

namespace WebProject.Models
{
    public class addrights
    {

        public string users { get; set; }

        public string rights { get; set; }

        public void insertright()
        {
            SqlCommand cmd = new SqlCommand("addrights", connections.connect());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", users);
            cmd.Parameters.AddWithValue("@rights", rights);
           
            cmd.ExecuteNonQuery();

        }

    }
}