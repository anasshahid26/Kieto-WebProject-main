using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebProject.Models;


namespace WebProject.Controllers
{
    public class SingleSectionTestController : Controller
    {
        //
        // GET: /SingleSectionTest/

        public ActionResult SingleSectionTest()
        {
            return View("SingleSectionTest");
        }
        public ActionResult testadd(FormCollection f)
        {
            string tname = f["req"].ToString();
            string ttype = f["select2"].ToString();
            string radio1 = f["radio1"].ToString();
            string student = f["minValid"].ToString();
            string time = f["time"].ToString();
            string numques = f["noquestion"].ToString();

            RouteValueDictionary rvd = new RouteValueDictionary();
            rvd.Add("testname", tname);
            rvd.Add("studentnum", numques);

            Test_details tt = new Test_details();
            tt.tname = tname;
            tt.ttype = ttype;
            tt.student = student;
            tt.time = time;
            tt.numques = numques;
            tt.radio1 = radio1;
            tt.insert();

            //make entry in students table

            tt.inserstudent();

            
            return RedirectToAction("TestMcq", "TestMcq", rvd);
        }

    }
}
