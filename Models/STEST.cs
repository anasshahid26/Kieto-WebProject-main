using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace WebProject.Models
{
    public class STEST
    {

        public string tid {get; set; }
        public string testtype {get; set; }
        public string question { get; set; }
        public string time { get; set; }
        public string q1 { get; set; }
        public string aa { get; set; }
        public string ab { get; set; }
        public string ac { get; set; }
        public string ad { get; set; }
        public string anscount { get; set; }

       public string rows  {get;set;}

        public void minid(string tname)
        {


            SqlCommand cm1 = new SqlCommand("getminid", connections.connect());
            cm1.CommandType = CommandType.StoredProcedure;
            cm1.Parameters.AddWithValue("@tname", tname);


            SqlDataReader sdr = cm1.ExecuteReader();

            while (sdr.Read())
            {
                tid = sdr["id"].ToString();
             
            }

            sdr.Close();



        }


        public void quest1(string tname)
        {


            SqlCommand cm2 = new SqlCommand("question1", connections.connect());
            cm2.CommandType = CommandType.StoredProcedure;
            cm2.Parameters.AddWithValue("@tname", tname);


            SqlDataReader sdra = cm2.ExecuteReader();

            while (sdra.Read())
            {
                q1 = sdra["questions"].ToString();
                aa = sdra["ansa"].ToString();
                ab = sdra["ansb"].ToString();
                ac = sdra["ansc"].ToString();
                ad = sdra["ansd"].ToString();

            }

            sdra.Close();
            



        }
        public void addanswers(string tname, string sname, string question, string answer)
        {

            SqlCommand cmd3 = new SqlCommand("insertanswers", connections.connect());
            cmd3.CommandType = CommandType.StoredProcedure;
            cmd3.Parameters.AddWithValue("@tname", tname);
            cmd3.Parameters.AddWithValue("@sname", sname);
            cmd3.Parameters.AddWithValue("@question", question);
            cmd3.Parameters.AddWithValue("@answer", answer);
         
            cmd3.ExecuteNonQuery();
        
        }
        public void ques_count(string tname,string sname)
        {


            SqlCommand cm4 = new SqlCommand("getcount", connections.connect());
            cm4.CommandType = CommandType.StoredProcedure;
            cm4.Parameters.AddWithValue("@tname", tname);
            cm4.Parameters.AddWithValue("@sname", sname);


            SqlDataReader sdrs = cm4.ExecuteReader();

            while (sdrs.Read())
            {
                //int count = (int)cm4.ExecuteScalar();
               // anscount = sdrs["count"].ToString();

            
                    rows = sdrs["count"].ToString();
             

            }

            sdrs.Close();



        }


        public void getquestion()
        {
            int a = Convert.ToInt16(tid);
            int b = Convert.ToInt16(rows);
            int counter = a + b;

            SqlCommand cm5 = new SqlCommand("questionnext", connections.connect());
            cm5.CommandType = CommandType.StoredProcedure;
            cm5.Parameters.AddWithValue("@counter", counter);


            SqlDataReader sdrq = cm5.ExecuteReader();

            while (sdrq.Read())
            {
                q1 = sdrq["questions"].ToString();
                aa = sdrq["ansa"].ToString();
                ab = sdrq["ansb"].ToString();
                ac = sdrq["ansc"].ToString();
                ad = sdrq["ansd"].ToString();

            }

            sdrq.Close();



        }





    }
}