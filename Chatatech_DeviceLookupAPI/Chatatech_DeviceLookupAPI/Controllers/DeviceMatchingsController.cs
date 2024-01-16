using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Chatatech_DeviceLookupAPI.Models;

namespace Chatatech_DeviceLookupAPI.Controllers
{
    public class DeviceMatchingsController : Controller
    {
        private DeviceContext db = new DeviceContext();

        // GET: DeviceMatchings
        public ActionResult Index()
        {
            return View(db.DeviceMatchings.ToList());
        }

        // GET: DeviceMatchings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeviceMatching deviceMatching = db.DeviceMatchings.Find(id);
            if (deviceMatching == null)
            {
                return HttpNotFound();
            }
            return View(deviceMatching);
        }

        // GET: DeviceMatchings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DeviceMatchings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,SerialMatch,Model,YearOfManufacture,OriginalCost")] DeviceMatching deviceMatching)
        {
            if (ModelState.IsValid)
            {
                db.DeviceMatchings.Add(deviceMatching);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(deviceMatching);
        }

        // GET: DeviceMatchings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeviceMatching deviceMatching = db.DeviceMatchings.Find(id);
            if (deviceMatching == null)
            {
                return HttpNotFound();
            }
            return View(deviceMatching);
        }

        // POST: DeviceMatchings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,SerialMatch,Model,YearOfManufacture,OriginalCost")] DeviceMatching deviceMatching)
        {
            if (ModelState.IsValid)
            {
                db.Entry(deviceMatching).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(deviceMatching);
        }

        // GET: DeviceMatchings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeviceMatching deviceMatching = db.DeviceMatchings.Find(id);
            if (deviceMatching == null)
            {
                return HttpNotFound();
            }
            return View(deviceMatching);
        }

        // POST: DeviceMatchings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DeviceMatching deviceMatching = db.DeviceMatchings.Find(id);
            db.DeviceMatchings.Remove(deviceMatching);
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
