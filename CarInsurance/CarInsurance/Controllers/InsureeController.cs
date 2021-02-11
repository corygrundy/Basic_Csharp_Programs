using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        public decimal v = 100;
        public decimal c = 25;
        // public decimal z = 50;    /* Unneeded decimal that I am leaving here for personal note that I don't need to make new variables if I need to
        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                decimal quoteCalc;
                var age = DateTime.Now.Year - insuree.DateOfBirth.Year;
                // insuree.Quote = 50;
                if ( age < 18 )
                {
                    decimal x = 50;
                    quoteCalc = x + v;
                }
                else if (age < 19 || age >25)
                {
                    decimal x = 50;
                    quoteCalc = x + x;
                }
                else
                {
                    decimal x = 50;
                    quoteCalc = x + c;
                }
                int carYear = insuree.CarYear;
                decimal yearPrice;
                if (carYear < 2000 || carYear > 2015)
                {
                    yearPrice = 25;
                }
                else
                {
                    yearPrice = 0;
                }
                string carMake = insuree.CarMake;
                decimal makePrice;
                if (carMake == "Porsche" || carMake == "porsche")
                {
                    makePrice = 25;
                }
                else
                {
                    makePrice = 0;
                }
                string carModel = insuree.CarModel;
                decimal modelPrice;
                if (carModel == "911 Carrera" || carModel == "911 carrera")
                {
                    modelPrice = 25;
                }
                else
                {
                    modelPrice = 0;
                }
                int speedFine = insuree.SpeedingTickets;
                decimal speedPrice;
                if (speedFine > 1)
                {
                    speedPrice = speedFine * 10;
                }
                else
                {
                    speedPrice = 0;
                }
                decimal quoteSum;
                decimal quoteSum1;
                bool dui = insuree.DUI;
                decimal perc1 = 25;
                if (dui == true)
                {
                    quoteSum1 = 50 + quoteCalc + yearPrice + makePrice + modelPrice + speedPrice;
                    quoteSum = quoteSum1 * perc1 / 100;
                }
                else
                {
                    quoteSum1 = 50 + quoteCalc + yearPrice + makePrice + modelPrice + speedPrice;
                    quoteSum = quoteSum1;
                }
                //bool fullCoverage = insuree.CoverageType
                //if ()
                insuree.Quote = quoteSum;
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
