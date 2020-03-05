using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using STAWebsite2.DAL;
using STAWebsite2.Models;

namespace STAWebsite2.Controllers
{
    public class IRatingController : Controller
    {
        private STAContext db = new STAContext();

        // GET: IRating
        public ActionResult Index()
        {
            var iRatings = db.IRatings.Include(i => i.Instructor).Include(i => i.Student);
            return View(iRatings.ToList());
        }

        // GET: IRating/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IRating iRating = db.IRatings.Find(id);
            if (iRating == null)
            {
                return HttpNotFound();
            }
            return View(iRating);
        }

        // GET: IRating/Create
        public ActionResult Create()
        {
            ViewBag.InstructorID = new SelectList(db.Instructors, "InstructorID", "Name");
            ViewBag.StudentID = new SelectList(db.Students, "StudentID", "Name");
            return View();
        }

        // POST: IRating/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IRatingID,SubCriteria1,SubCriteria2,SubCriteria3,SubCriteria4,SubCriteria5,SubCriteria6,SubCriteria7,SubCriteria8,SubCriteria9,SubCriteria10,SubCriteria11,SubCriteria12,SubCriteria13,SubCriteria14,SubCriteria15,SubCriteria16,SubCriteria17,SubCriteria18,SubCriteria19,SubCriteria20,Review,StudentID,InstructorID")] IRating iRating)
        {
            if (ModelState.IsValid)
            {
                db.IRatings.Add(iRating);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.InstructorID = new SelectList(db.Instructors, "InstructorID", "Name", iRating.InstructorID);
            ViewBag.StudentID = new SelectList(db.Students, "StudentID", "Name", iRating.StudentID);
            return View(iRating);
        }

        // GET: IRating/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IRating iRating = db.IRatings.Find(id);
            if (iRating == null)
            {
                return HttpNotFound();
            }
            ViewBag.InstructorID = new SelectList(db.Instructors, "InstructorID", "Name", iRating.InstructorID);
            ViewBag.StudentID = new SelectList(db.Students, "StudentID", "Name", iRating.StudentID);
            return View(iRating);
        }

        // POST: IRating/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IRatingID,SubCriteria1,SubCriteria2,SubCriteria3,SubCriteria4,SubCriteria5,SubCriteria6,SubCriteria7,SubCriteria8,SubCriteria9,SubCriteria10,SubCriteria11,SubCriteria12,SubCriteria13,SubCriteria14,SubCriteria15,SubCriteria16,SubCriteria17,SubCriteria18,SubCriteria19,SubCriteria20,Review,StudentID,InstructorID")] IRating iRating)
        {
            if (ModelState.IsValid)
            {
                db.Entry(iRating).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.InstructorID = new SelectList(db.Instructors, "InstructorID", "Name", iRating.InstructorID);
            ViewBag.StudentID = new SelectList(db.Students, "StudentID", "Name", iRating.StudentID);
            return View(iRating);
        }

        // GET: IRating/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IRating iRating = db.IRatings.Find(id);
            if (iRating == null)
            {
                return HttpNotFound();
            }
            return View(iRating);
        }

        // POST: IRating/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IRating iRating = db.IRatings.Find(id);
            db.IRatings.Remove(iRating);
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
