using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace sportshop.Models
{
	public class SportsDB
	{
		static List<Product> _Products;

		static SportsDB()
		{
			_Products = new List<Product>();
			_Products.Add(new Product
			{
				ProductID = 1,
				Name = "Kayak",
				Description = "A boat for one person",
				Category = "Watersports",
				Price = 275M
			});
		}

		public IList<Product> Products
		{
			get { return _Products; }
		}
	}
}