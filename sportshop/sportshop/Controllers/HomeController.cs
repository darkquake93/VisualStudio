using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sportshop.Models;

namespace sportshop.Controllers
{
    public class HomeController : Controller
    {

		SportsDB db = new SportsDB();

		public ActionResult Index()
		{
			var model = db.Products.LastOrDefault();
			return View(model);
		}

		private Product myProduct = new Product
		{
			ProductID = 1,
			Name = "Kayak",
			Description = "A boat for one person, pretty cool",
			Category = "Watersports",
			Price = 9999M
		};

		[HttpGet]
		public ViewResult AddProduct()
		{
			return View();
		}

		[HttpPost]

		public ActionResult Edit(Product product)
		{
			var _product = db.Products.Single(x => x.ProductID == product.ProductID);
			if (TryUpdateModel(_product))
			{
				return RedirectToAction("ProductList");
			}
			else
			{
				return View(product);
			}
		}

		public ActionResult AddProduct(Product product)
		{
			if (ModelState.IsValid)
			{
				db.Products.Add(product);
				return RedirectToAction("ProductList");
			}
			else
			{
				return View();
			}
		}

		public ViewResult ProductList()
		{
			var model = db.Products.ToList();
			return View(model);
		}

        public ActionResult About()
        {
            ViewBag.Message = "This app is about a sports store";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Somewhere in Kingston";

            return View();
        }
    }
}