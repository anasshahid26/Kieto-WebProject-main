using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProject.Models;
using System.Threading;


namespace WebProject.Controllers
{
    public class STESTController : Controller
    {
        //
        // GET: /STEST/
        STEST st = new STEST();
        public ActionResult STEST()
        {
             string tname = Request.QueryString["testname"];
             string tques = Request.QueryString["testques"];
             string ttime = Request.QueryString["testtime"];
             
           //  st.minid(tname);
            
            return View("STEST");
        }

        [HttpPost]

        public JsonResult LongRunningDemoProcess(FormCollection f)
        {
            Thread.Sleep(1000);

            string tname = f["tname"].ToString();
            string sname = f["sname"].ToString();
            string question = f["qu1"].ToString();
            string answer = f["correct"].ToString();
            st.addanswers(tname,sname,question,answer);
            


            //next question

            st.minid(tname);
            st.ques_count(tname, sname);
            st.getquestion();

            string que = "<h4>" + st.q1 + "</h4>";
            string ans = "<h6>Option A:" + st.aa + "</h6>" + "<h6>Option B:" + st.ab + "</h6>" + "<h6>Option C:" + st.ac + "</h6>" + "<h6>Option D:" + st.ad + "</h6>";

            return Json(que+ans, "json");
            


        }


    }
}