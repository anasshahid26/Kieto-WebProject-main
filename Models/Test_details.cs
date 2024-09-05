using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System;
using System.IO;

namespace WebProject.Models
{
    public class Test_details
    {

        public string tname { get; set; }
        public string ttype { get; set; }
       
        public string student { get; set; }
        public string time { get; set; }
        public string numques { get; set; }

        public string radio1 { get; set; }

        public void insert()
        {
            SqlCommand cmd = new SqlCommand("testdetails", connections.connect());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tname", tname);
            cmd.Parameters.AddWithValue("@ttype", ttype);
            cmd.Parameters.AddWithValue("@student", student);
            cmd.Parameters.AddWithValue("@time", time);
            cmd.Parameters.AddWithValue("@numques", numques);
            cmd.Parameters.AddWithValue("@hint", radio1);
            cmd.ExecuteNonQuery();

        }

        public void inserstudent()
        {
            int stu = Convert.ToInt16(student);

          

            for (int i = 0; i <=stu; i++)
            {
                SqlCommand cmd = new SqlCommand("insertstudent", connections.connect());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@tname", tname);
                cmd.Parameters.AddWithValue("@username", tname+"stud"+i);
                cmd.Parameters.AddWithValue("@password", RandomUtil.GetRandomString());

             
                cmd.ExecuteNonQuery(); 
            }
          
        
        
        }
    }

    static class RandomUtil
    {
        /// <summary>
        /// Get random string of 11 characters.
        /// </summary>
        /// <returns>Random string.</returns>
        public static string GetRandomString()
        {
            string path = Path.GetRandomFileName();
            path = path.Replace(".", ""); // Remove period.
            return path;
        }
    }

}