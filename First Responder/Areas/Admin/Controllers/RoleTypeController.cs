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
    public class RoleTypeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Admin/RoleType
        public ActionResult Index()
        {
            return View(db.RoleTypes.ToList());
        }

        // GET: Admin/RoleType/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RoleType roleType = db.RoleTypes.Find(id);
            if (roleType == null)
            {
                return HttpNotFound();
            }
            return View(roleType);
        }

        // GET: Admin/RoleType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/RoleType/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RoleTypeID,RoleTypeName")] RoleType roleType)
        {
            if (ModelState.IsValid)
            {
                db.RoleTypes.Add(roleType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(roleType);
        }

        // GET: Admin/RoleType/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RoleType roleType = db.RoleTypes.Find(id);
            if (roleType == null)
            {
                return HttpNotFound();
            }
            return View(roleType);
        }

        // POST: Admin/RoleType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RoleTypeID,RoleTypeName")] RoleType roleType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(roleType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(roleType);
        }

        // GET: Admin/RoleType/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RoleType roleType = db.RoleTypes.Find(id);
            if (roleType == null)
            {
                return HttpNotFound();
            }
            return View(roleType);
        }

        // POST: Admin/RoleType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RoleType roleType = db.RoleTypes.Find(id);
            db.RoleTypes.Remove(roleType);
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
