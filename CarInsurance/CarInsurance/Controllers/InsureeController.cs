﻿using System;
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
        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }
        
        
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

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
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

        public decimal Quote(Insuree insuree)
        {
            using (var context = new InsuranceEntities())
            {
                // starting with a base of $50
                int TotalQuote = 50;

                // saving user's age as a variable
                int age = DateTime.Now.Year - insuree.DateOfBirth.Year;

                // if user is 18 or under, add $100 to monthly total
                if (age <= 18)
                {
                    TotalQuote += 100;
                }
                // if user is 19 to 25, add $50 to the monthly total
                else if (age >= 19 && age <= 25)
                {
                    TotalQuote += 50;
                }
                // If user is 26 or older, addd $25 to the monthly total
                else
                {
                    TotalQuote += 25;
                }


                // if the car's year is before 200, add $25
                if (insuree.CarYear < 2000)
                {
                    TotalQuote += 25;
                }

                // if the car's year is after 2015, add $25
                else if (insuree.CarYear > 2015)
                {
                    TotalQuote += 25;
                }


                // if that car's make is Porsche, add $25
                if (insuree.CarMake == "Porsche")
                {
                    TotalQuote += 25;
                }

                // if car's make is Porsche and model is 911 Carrera, add an additional $25
                if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera")
                {
                    TotalQuote += 25;
                }


                // add $10 for each DUI
                if (insuree.SpeedingTickets > 0)
                {
                    TotalQuote += (insuree.SpeedingTickets * 10);
                }

                // if the user has ever had a DUI, add 25% to the total
                if (insuree.DUI == true)
                {
                    TotalQuote += Convert.ToInt32(TotalQuote * .25m);
                }

                // add 50% if user has full coverage
                if (insuree.CoverageType == true)
                {
                    TotalQuote += Convert.ToInt32(TotalQuote * .50);
                }

                return TotalQuote;
            }
        }


    }
}
