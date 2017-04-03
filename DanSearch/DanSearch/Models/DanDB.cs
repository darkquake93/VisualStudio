using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DanSearch.Models
{
    public class DanDB
    {
        static List<Customer> _Customers;

        static DanDB()
        {
            _Customers = new List<Customer>();

            _Customers.Add(new Customer
            {
                CustomerID = 1,
                Name = "Blardy McBlah",
                DOB = 456,
                Gender = "Male",
                Address1 = "Wherever",
                Address2 = "Whatever",
                Postcode = "WT504RY",
                Email = "blardy@gmail.com",
                Phone = 02938475896,
                Mobile = 07084938728,
                WorkLoc = "Blah Mansion"
            });
        }
        public IList<Customer> Customers
        {
            get { return _Customers; }
        }
    }
}