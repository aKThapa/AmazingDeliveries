using AmazingDeliveries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace AmazingDeliveries.Controllers
{
    public class CustomerController : Controller
    {
        private CustomerEntities db = new CustomerEntities();

        public ActionResult CustomerDetails()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CustomerDetails([Bind(Exclude = "CustomerID")]Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToAction("ParcelDetails", "Parcel", new { id = customer.CustomerID });
            }
            else
            {
                return View(customer);
            }
        }




    }
}