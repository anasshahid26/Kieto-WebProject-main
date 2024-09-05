using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace WebProject.Models
{
    public class questions
    {

        public string question { get; set; }

        public string tname { get; set; }
        public string ans_a { get; set; }
        public string ans_b { get; set; }
        public string ans_c { get; set; }
        public string ans_d { get; set; }
        public string Correct { get; set; }
        public string file_path { get; set; }

        public string rows { get; set; }

        
  
        public void insert()
        {
            SqlCommand cmd = new SqlCommand("Question", connections.connect());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@question ", question);
            cmd.Parameters.AddWithValue("@tname", tname);
            cmd.Parameters.AddWithValue("@ansa", ans_a);
            cmd.Parameters.AddWithValue("@ansb", ans_b);
            cmd.Parameters.AddWithValue("@ansc", ans_c);
            cmd.Parameters.AddWithValue("@ansd", ans_d);
            cmd.Parameters.AddWithValue("@correct", Correct);
            cmd.Parameters.AddWithValue("@file", "asd");

            cmd.ExecuteNonQuery();
        }

        public void getcount()
        {

            SqlCommand cm4 = new SqlCommand("getno", connections.connect());
            cm4.CommandType = CommandType.StoredProcedure;
            cm4.Parameters.AddWithValue("@tname", tname);
          


            SqlDataReader sdrs = cm4.ExecuteReader();

            while (sdrs.Read())
            {
                //int count = (int)cm4.ExecuteScalar();
                // anscount = sdrs["count"].ToString();


                rows = sdrs["count"].ToString();


            }

            sdrs.Close();

        
        
        
        }


    }
}