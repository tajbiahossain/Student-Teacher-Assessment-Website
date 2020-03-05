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
    public class SCRatingController : Controller
    {
        private STAContext db = new STAContext();

        // GET: SCRating
        public ActionResult Index()
        {
            var sCRatings = db.SCRatings.Include(s => s.Course).Include(s => s.Instructor);
            return View(sCRatings.ToList());
        }

        // GET: SCRating/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SCRating sCRating = db.SCRatings.Find(id);
            if (sCRating == null)
            {
                return HttpNotFound();
            }
            return View(sCRating);
        }

        // GET: SCRating/Create
        public ActionResult Create()
        {
            ViewBag.CourseID = new SelectList(db.Courses, "CourseID", "Title");
            ViewBag.InstructorID = new SelectList(db.Instructors, "InstructorID", "Name");
            return View();
        }

        // POST: SCRating/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SCRatingID,SubCriteria1,SubCriteria2,SubCriteria3,SubCriteria4,SubCriteria5,SubCriteria6,SubCriteria7,Review,CourseID,InstructorID")] SCRating sCRating)
        {
            if (ModelState.IsValid)
            {
                db.SCRatings.Add(sCRating);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CourseID = new SelectList(db.Courses, "CourseID", "Title", sCRating.CourseID);
            ViewBag.InstructorID = new SelectList(db.Instructors, "InstructorID", "Name", sCRating.InstructorID);
            return View(sCRating);
        }

        // GET: SCRating/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SCRating sCRating = db.SCRatings.Find(id);
            if (sCRating == null)
            {
                return HttpNotFound();
            }
            ViewBag.CourseID = new SelectList(db.Courses, "CourseID", "Title", sCRating.CourseID);
            ViewBag.InstructorID = new SelectList(db.Instructors, "InstructorID", "Name", sCRating.InstructorID);
            return View(sCRating);
        }

        // POST: SCRating/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SCRatingID,SubCriteria1,SubCriteria2,SubCriteria3,SubCriteria4,SubCriteria5,SubCriteria6,SubCriteria7,Review,CourseID,InstructorID")] SCRating sCRating)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sCRating).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CourseID = new SelectList(db.Courses, "CourseID", "Title", sCRating.CourseID);
            ViewBag.InstructorID = new SelectList(db.Instructors, "InstructorID", "Name", sCRating.InstructorID);
            return View(sCRating);
        }

        // GET: SCRating/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SCRating sCRating = db.SCRatings.Find(id);
            if (sCRating == null)
            {
                return HttpNotFound();
            }
            return View(sCRating);
        }

        // POST: SCRating/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SCRating sCRating = db.SCRatings.Find(id);
            db.SCRatings.Remove(sCRating);
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
