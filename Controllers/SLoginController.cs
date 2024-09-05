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
    public class SLoginController : Controller
    {
        //
        // GET: /SLogin/

        public ActionResult SLogin()
        {
            return View("SLogin");
        }
        [HttpPost]
        public ActionResult Student_log(FormCollection f)
        {
            string tname = f["tname"].ToString();
            string email = f["email"].ToString();
            string pass = f["password"].ToString();


            RouteValueDictionary rvd = new RouteValueDictionary();
            rvd.Add("testname", tname);
            rvd.Add("student_name", email);
            

            if (ModelState.IsValid)
            {
                //if (model.Username == "jed" && model.Password == "albao") // Simulate data store call where Username/Password
                if (DAL.UserIsValid(tname,email, pass))
                {
                    FormsAuthentication.SetAuthCookie(tname, true);
                    FormsAuthentication.SetAuthCookie(email, true);
                    FormsAuthentication.SetAuthCookie(pass, true);
                    return RedirectToAction("SDash", "SDash",rvd);
                }
                else
                {
                    return RedirectToAction("SLogin", "SLogin");
                }
            }

            return View();
        }

    }
}
