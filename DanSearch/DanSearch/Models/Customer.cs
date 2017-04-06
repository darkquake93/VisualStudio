using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DanSearch.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "Please enter the Customer's Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter the Customer's Date of Birth")]
        public int DOB { get; set; }
        [Required(ErrorMessage = "Please enter the Customer's Gender")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Please enter the Customer's First Line of Address")]
        public string Address1 { get; set; }
        [Required(ErrorMessage = "Please enter the Customer's Second Line of Address")]
        public string Address2 { get; set; }
        [Required(ErrorMessage = "Please enter the Customer's Postcode")]
        public string Postcode { get; set; }
        [Required(ErrorMessage = "Please enter the Customer's Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter the Customer's Home Phone Number")]
        public long Phone { get; set; }
        [Required(ErrorMessage = "Please enter the Customer's Mobile Number")]
        public long Mobile { get; set; }
        [Required(ErrorMessage = "Please enter the Customer's Work Location")]
        public string WorkLoc { get; set; }
    }
}