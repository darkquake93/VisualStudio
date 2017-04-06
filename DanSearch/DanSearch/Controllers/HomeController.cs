using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DanSearch.Models;

namespace DanSearch.Controllers
{


    public class HomeController : Controller
    {
        DanDB db = new DanDB();
        

        public ActionResult Index()
        {
            return View(db.Customers.ToList());
        }

        [HttpGet]
        public ViewResult AddCust()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Edit(int id)
        {
            var model = db.Customers.Single(x => x.CustomerID == id);
            return View(model);
        }
        [HttpGet]
        public ViewResult Delete(int id)
        {
            var model = db.Customers.Single(x => x.CustomerID == id);
            return View(model);
        }
        [HttpPost]
        public ActionResult AddCust(Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(customer);
                return RedirectToAction("CustList");
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            var _customer = db.Customers.Single(x => x.CustomerID == customer.CustomerID);
            if (TryUpdateModel(_customer))
            {
                return RedirectToAction("CustList");
            }
            else
            {
                return View(customer);
            }
        }
        [HttpPost]
        public ActionResult Delete(Customer customer)
        {
            var _customer = db.Customers.Single(x => x.CustomerID == customer.CustomerID);
            if (TryUpdateModel(_customer))
            {
                return RedirectToAction("CustList");
            }
            else
            {
                return View(customer);
            }
        }

        public ViewResult CustList()
        {
            var model = db.Customers.ToList();
            return View(model);
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