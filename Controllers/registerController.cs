using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProject.Models;

namespace WebProject.Controllers
{
    public class registerController : Controller
    {
        //
        // GET: /register/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult sign()
        {
            return View("signup");
        }

        [HttpPost]
        public ActionResult signu(FormCollection f)
        {
            string email = f["email"].ToString();
            string pass = f["password"].ToString();
            string fname = f["firstname"].ToString();
            string lastname = f["lastname"].ToString();
            string radio = f["radio"].ToString();
            string url = f["url"].ToString();
            string tel = f["tel"].ToString();
            string state = f["state"].ToString();
            string postcode = f["postcode"].ToString();
            string address = f["address"].ToString();
        




            userreg u = new userreg();
            u.email = email;
            u.password = pass;
            u.firstname = fname;
            u.lastname = lastname;
            u.gender = radio;
            u.website = url;
            u.mobile = tel;
            u.country = state;
            u.postcode = postcode;
            u.address = address;
            u.insert();
            return View("signup");
        }

    

    }
}
