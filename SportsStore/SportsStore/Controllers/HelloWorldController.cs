using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsStore.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            @ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }
        public ActionResult Page2()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is my cool application.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact me here.";

            return View();
        }
    }
}