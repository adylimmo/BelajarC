using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class CrudController : Controller
    {
        // GET: Crud
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CrudCon()
        {
            ViewBag.Message = "Your Crud page.";
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }
    }
}