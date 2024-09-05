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
    public class masteradminController : Controller
    {
        //
        // GET: /masteradmin/

        public ActionResult masteradmin()
        {
            return View("masteradmin");
        }
        public ActionResult master_log(FormCollection f)
        {
            string email = f["email"].ToString();
            string pass = f["password"].ToString();

            if (ModelState.IsValid)
            {
                //if (model.Username == "jed" && model.Password == "albao") // Simulate data store call where Username/Password
                if (masterlogin.UserIsValid( email, pass))
                {
                  
                    FormsAuthentication.SetAuthCookie(email, true);
                    FormsAuthentication.SetAuthCookie(pass, true);
                    return RedirectToAction("MasterDash", "MasterDash");
                }
                else
                {
                    return RedirectToAction("masteradmin", "masteradmin");
                }
            }
            return View();

        }
    }
}
