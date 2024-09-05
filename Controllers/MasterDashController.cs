using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProject.Models;

namespace WebProject.Controllers
{
    public class MasterDashController : Controller
    {
        //
        // GET: /MasterDash/
       
        public ActionResult MasterDash()
        {
            return View("MasterDash");
        }
         [HttpPost]
        public ActionResult giverights(FormCollection f)
        {
            string userss = f["user"].ToString();
            string right = f["rights"].ToString();

            addrights ad = new addrights();
            ad.users = userss;
            ad.rights = right;
            ad.insertright();
            return View("MasterDash");
        }
    }
}