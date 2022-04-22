using DMS.DAL.DatabaseContext;
using DMS.DAL.Interfaces;
using DMS.DAL.StaticHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DMS.Controllers
{
    [AllowAnonymous]
    public class adminController : Controller
    {

        private MainEntities db;
        private SystemInfoForSession _ActiveSession;
        private IBranchesRepo _BranchesRepo;

        public adminController(MainEntities _db, IBranchesRepo BranchesRepo)
        {
            _ActiveSession = SessionHelper.GetSession();
            db = _db;
            _BranchesRepo = BranchesRepo;
        }
        public ActionResult index()
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
 