using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using WebProject.Models;
using System.Web.Security;
using System.Web.Routing;

namespace WebProject.Controllers
{
    public class SDashController : Controller
    {
        //
        // GET: /SDash/

        public  ActionResult SDash()
        {
            string tname = Request.QueryString["testname"];



            SDash sd = new SDash();

            sd.GetDetails(tname);
            string testname = sd.testname;
            //dynamic object we can make a property on runtime like viewBag.mytable;
           
            return View();

        }
         [HttpPost]
        public ActionResult start_test(FormCollection f)
        {
            string tname = f["tname"].ToString();
            string tques = f["tesques"].ToString();
            string ttime = f["testtime"].ToString();
            string sname = f["sname"].ToString();

            RouteValueDictionary rvd = new RouteValueDictionary();
            rvd.Add("testname", tname);
            rvd.Add("testques", tques);
            rvd.Add("testtime", ttime);
            rvd.Add("sname", sname);

            return RedirectToAction("STEST", "STEST", rvd);
        }
       

    }
}
