using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace WebProject.Models
{
    public class DAL
    {
        public static bool UserIsValid(string tname,string email, string password)
        {
            bool authenticated = false;

            SqlCommand cmd = new SqlCommand("Slogin", connections.connect());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tname", tname);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@pass", password);
            cmd.ExecuteNonQuery();
            SqlDataReader sdr = cmd.ExecuteReader();
            authenticated = sdr.HasRows;
            sdr.Close();
            return (authenticated);
        }
    }
}