using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Threading;
using WebProject.Models;


namespace WebProject.Controllers
{
    public class TestMcqController : Controller
    {
        //
        // GET: /TestMcq/


        public ActionResult TestMcq()
        {
            return View("TestMcq");
        }

       
        [HttpPost]

        public JsonResult LongRunningDemoProcess(FormCollection f)
        {
            Thread.Sleep(1000);

            string tname = f["tname"].ToString();
            string question = f["Question"].ToString();
            string c1 = f["c1"].ToString();
            string c2 = f["c2"].ToString();
            string c3 = f["c3"].ToString();
            string c4 = f["c4"].ToString();
            string crrect = f["correct"].ToString();
            string qno = f["qno"].ToString();


            questions que = new questions();

            que.question = question;
            que.tname = tname;
            que.ans_a = c1;
            que.ans_b = c2;
            que.ans_c = c3;
            que.ans_d = c4;
            que.Correct = crrect;

            que.insert();


           
            que.getcount();
            int count=Convert.ToInt16(que.rows);
            int queno = Convert.ToInt16(qno);
            if (count>=queno)
            {
              
              return Json("your all"+qno+"questions submitted Thanks, please check Your email for Student Id and Passwords", "json");
                //transfer();
            }
            
            
            return Json("Question Submitted success please Write next question", "json");
            

        }
        public void transfer()
        {
            RedirectToAction("TLogin","TLogin");
        
        }
    }
}
