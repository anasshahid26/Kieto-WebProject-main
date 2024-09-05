using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProject.Models;
using System.Web.Security;


namespace WebProject.Controllers
{
    public class TloginController : Controller
    {
        //
        // GET: /Tlogin/

        public ActionResult Tlogin()
        {
            return View("Tlogin");
        }

        [HttpPost]
        public ActionResult Teacher_log(FormCollection f)
        {
            string email = f["email"].ToString();
            string pass = f["password"].ToString();


            if (ModelState.IsValid)
            {
                //if (model.Username == "jed" && model.Password == "albao") // Simulate data store call where Username/Password
                if (userlog.UserIsValid(email, pass))
                {
                    FormsAuthentication.SetAuthCookie(email, true);
                    FormsAuthentication.SetAuthCookie(pass, true);
                    return RedirectToAction("Tdash", "Tdash");
                }
                else
                {
                    return RedirectToAction("Tlogin", "Tlogin");
                }
            }

            return View();
        }


    }
}
