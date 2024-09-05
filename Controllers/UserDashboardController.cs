using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProject.Controllers
{
    public class UserDashboardController : Controller
    {
        //
        // GET: /UserDashboard/

        public ActionResult UserDashboard()
        {
            return View("UserDashboard");
        }

    }
}
