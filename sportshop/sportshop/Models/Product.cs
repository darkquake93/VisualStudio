using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sportshop.Models
{
	public class Product
	{
		public int ProductID { get; set; }
		[Required(ErrorMessage = "Please enter the product name.")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Please enter the product description.")]
		public string Description { get; set; }
		[Required(ErrorMessage = "Please enter the product price.")]
		public decimal Price { get; set; }
		[Required(ErrorMessage = "Please enter the product category.")]
		public string Category { get; set; }

	}
}