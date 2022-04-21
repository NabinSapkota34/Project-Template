using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DMS.Controllers
{
    public class adminController : Controller
    {
       

        public ActionResult AccessDeniedPage()
        {
            return View();
        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult lifestyle()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        

    }
}
 