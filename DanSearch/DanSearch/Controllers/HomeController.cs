using DanSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DanSearch.Controllers
{


    public class HomeController : Controller
    {
        DanDB db = new DanDB();
        private Customer myCust = new Customer
        {
            CustomerID = 1,
            Name = "Donald Trump",
            DOB = 123,
            Gender = "Male",
            Address1 = "Boofhead Lane",
            Address2 = "Hell",
            Postcode = "HL2017T",
            Email = "bigly@gmail.com",
            Phone = 02072034094,
            Mobile = 07033092039,
            WorkLoc = "Trumps Place"
        };

        public ActionResult Index()
        {
            var model = db.Customers.LastOrDefault();
            return View(myCust);
        }

        [HttpGet]
        public ViewResult AddCust()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddCust(Customer customer)
        {
            if (ModelState.IsValid)
            {
                return View("Index", customer);
            }
            else
            {
                return View();
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "We are a Research group, and our website helps supply information about activities you are involved in, as well as information about events, conference calls, reports and publications. Please note that administrators actively monitor this information.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "253 Develepor's Road, Kingston\n0204 930 2039";

            return View();
        }
    }
}