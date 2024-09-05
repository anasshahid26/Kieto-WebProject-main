using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProject.Models;
using System.Web.Security;
using System.Web.Routing;

namespace WebProject.Controllers
{
    public class userloginController : Controller
    {
        //
        // GET: /userlogin/

        public ActionResult userlogins()
        {
            return View("userlogin");
        }

        [HttpPost]
        public ActionResult user_log(FormCollection f)
        {
            string users = f["email"].ToString();
            string pass = f["password"].ToString();

            RouteValueDictionary rvd = new RouteValueDictionary();
            rvd.Add("usernaem", users);


            if (ModelState.IsValid)
            {
                //if (model.Username == "jed" && model.Password == "albao") // Simulate data store call where Username/Password
                if (userlogin.UserIsValid(users, pass))
                {

                    FormsAuthentication.SetAuthCookie(users, true);
                    FormsAuthentication.SetAuthCookie(pass, true);
                    return RedirectToAction("UserDashboard", "UserDashboard",rvd);
                }
                else
                {
                    return RedirectToAction("userlogin", "userlogin");
                }
            }
            return View();
 
        }

    }
}
