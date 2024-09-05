using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace WebProject.Models
{
    public class modeluseradd
    {
        public string rights { get; set; }
        public string users { get; set; }

        public string password { get; set; }

        public void inseruser()
        {
            SqlCommand cmd = new SqlCommand("addusers", connections.connect());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@right", rights);
            cmd.Parameters.AddWithValue("@user", users);
            cmd.Parameters.AddWithValue("@password", password);

            cmd.ExecuteNonQuery();

        }



    }
}