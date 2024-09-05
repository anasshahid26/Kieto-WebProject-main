using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace WebProject.Models
{
    public class userreg
    {

        public string email { get; set; }
        public string password { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string gender { get; set; }
        public string website { get; set; }
        public string mobile { get; set; }
        public string country { get; set; }
        public string postcode { get; set; }
        public string address { get; set; }
        public void insert()
        {
            SqlCommand cmd = new SqlCommand("Registration", connections.connect());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email",email);
            cmd.Parameters.AddWithValue("@pass", password);
            cmd.Parameters.AddWithValue("@fname", firstname);
            cmd.Parameters.AddWithValue("@lname", lastname);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@website", website);
            cmd.Parameters.AddWithValue("@mobile", mobile);
            cmd.Parameters.AddWithValue("@country", country);
            cmd.Parameters.AddWithValue("@pcode", postcode);
            cmd.Parameters.AddWithValue("@adress", address);
            cmd.ExecuteNonQuery();


        
        }
    }
}