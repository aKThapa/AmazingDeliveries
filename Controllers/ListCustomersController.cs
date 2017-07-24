using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmazingDeliveries.Models;

namespace AmazingDeliveries.Controllers
{
    public class ListCustomersController : Controller
    {
        private CustomerEntities db = new CustomerEntities();

        // GET: ListCustomers
        public ActionResult CustomersList()
        {
            var customers = from c in db.Customers
                            select c;
            return View(customers);
        }

        public ActionResult IndividualInfo(int id)
        {
            Customer customer = db.Customers.Find(id);
            return View(customer);
        }




    }
}