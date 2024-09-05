using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProject.Models;

namespace WebProject.Controllers
{
    public class AddUserController : Controller
    {
        //
        // GET: /AddUser/

        public ActionResult AddUser()
        {
            return View("AddUser");
        }


        [HttpPost]
        public ActionResult add_user(FormCollection f)
        {
            string user = f["user"].ToString();
            string email = f["email"].ToString();
            string pass = f["password"].ToString();
            modeluseradd add = new modeluseradd();
            add.rights = user;
            add.users = email;
            add.password = pass;
            add.inseruser();

            return View("AddUser");
        }

    }
}
