using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace WebProject.Models
{
    public class model_user_dash
    {

        public string username { get; set; }
        public string right_name { get; set; }

        public string rights { get; set; }

        public void Getuserrights()
        {


            SqlCommand cm = new SqlCommand("selectusers", connections.connect());
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@username", username);


            SqlDataReader sdr = cm.ExecuteReader();

            while (sdr.Read())
            {
                right_name = sdr["userright"].ToString();
                
            }

            sdr.Close();



        }

        public void Getrights()
        {
            SqlCommand cm = new SqlCommand("rightss", connections.connect());
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@userright", right_name);


            SqlDataReader sdr = cm.ExecuteReader();

            while (sdr.Read())
            {
                rights = sdr["rights"].ToString();

            }

            sdr.Close();

        }


    }
}