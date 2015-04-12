using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using First_Responder.Areas.Admin.Models;
using First_Responder.Models;

namespace First_Responder.Areas.Admin.Controllers
{
    public class DriverTypeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Admin/DriverType
        public ActionResult Index()
        {
            return View(db.DriverTypes.ToList());
        }

        // GET: Admin/DriverType/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DriverType driverType = db.DriverTypes.Find(id);
            if (driverType == null)
            {
                return HttpNotFound();
            }
            return View(driverType);
        }

        // GET: Admin/DriverType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/DriverType/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DriverTypeID,DriverTypeName")] DriverType driverType)
        {
            if (ModelState.IsValid)
            {
                db.DriverTypes.Add(driverType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(driverType);
        }

        // GET: Admin/DriverType/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DriverType driverType = db.DriverTypes.Find(id);
            if (driverType == null)
            {
                return HttpNotFound();
            }
            return View(driverType);
        }

        // POST: Admin/DriverType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DriverTypeID,DriverTypeName")] DriverType driverType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(driverType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(driverType);
        }

        // GET: Admin/DriverType/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DriverType driverType = db.DriverTypes.Find(id);
            if (driverType == null)
            {
                return HttpNotFound();
            }
            return View(driverType);
        }

        // POST: Admin/DriverType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DriverType driverType = db.DriverTypes.Find(id);
            db.DriverTypes.Remove(driverType);
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
