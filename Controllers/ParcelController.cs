using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmazingDeliveries.Models;

namespace AmazingDeliveries.Controllers
{
    public class ParcelController : Controller
    {
        private CustomerEntities db = new CustomerEntities();

        // GET: Parcel
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ParcelDetails(int id)
        {
            var model = new Parcel();
            model.CustomID = id;
            return View(model);
        }

        [HttpPost]
        public ActionResult ParcelDetails([Bind(Exclude = "ParcelID")]Parcel parcel)
        {
            if (ModelState.IsValid)
            {
                db.Parcels.Add(parcel);
                db.SaveChanges();
                return RedirectToAction("ThankYou" , new { id = parcel.CustomID});
            }
            return View(parcel);
        }

        public ActionResult ShowParcelsDetails(int customerID)
        {
            ViewBag.id = customerID;
            var parcels = from p in db.Parcels
                          where p.CustomID.Equals(customerID)
                          select p;

            if (parcels.Count() == 0)
            {
                return RedirectToAction("NoParcel");
            }
            return View(parcels);
        }

        public ActionResult ThankYou(int id)
        {
            ViewBag.custId = id;
            return View();
        }

        public ActionResult NoParcel()
        {
            return View();
        }
    }
}