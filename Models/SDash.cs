using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace WebProject.Models
{
    public   class SDash
    {
       public string testname;
       public string testtype;
       public string question;
       public string time;

        public   void  GetDetails(string tname)
        {

            
            SqlCommand cm = new SqlCommand("GetDetails", connections.connect());
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@testname", tname);


            SqlDataReader sdr = cm.ExecuteReader();
            
            while (sdr.Read())
            {
                testname = sdr["testname"].ToString();
                testtype = sdr["testtype"].ToString();
                question = sdr["quesnum"].ToString();
                time = sdr["time"].ToString();
            }

            sdr.Close();
           


        }

       
    }
}