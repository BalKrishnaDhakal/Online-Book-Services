using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineBookServices.Models;

namespace OnlineBookServices.Controllers
{
    public class MemberShipTypeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MemberShipType
        public ActionResult Index()
        {
            return View(db.MembershipType.ToList());
        }

        // GET: MemberShipType/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MemberShipType memberShipType = db.MembershipType.Find(id);
            if (memberShipType == null)
            {
                return HttpNotFound();
            }
            return View(memberShipType);
        }

        // GET: MemberShipType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MemberShipType/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MemberShipType memberShipType)
        {
            if (ModelState.IsValid)
            {
                db.MembershipType.Add(memberShipType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(memberShipType);
        }

        // GET: MemberShipType/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MemberShipType memberShipType = db.MembershipType.Find(id);
            if (memberShipType == null)
            {
                return HttpNotFound();
            }
            return View(memberShipType);
        }

        // POST: MemberShipType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MemberShipType memberShipType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(memberShipType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(memberShipType);
        }

        // GET: MemberShipType/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MemberShipType memberShipType = db.MembershipType.Find(id);
            if (memberShipType == null)
            {
                return HttpNotFound();
            }
            return View(memberShipType);
        }

        // POST: MemberShipType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MemberShipType memberShipType = db.MembershipType.Find(id);
            db.MembershipType.Remove(memberShipType);
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
