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
    public class Student_CourseController : Controller
    {
        private STAContext db = new STAContext();

        // GET: Student_Course
        public ActionResult Index()
        {
            var student_Courses = db.Student_Courses.Include(s => s.Course).Include(s => s.Student);
            return View(student_Courses.ToList());
        }

        // GET: Student_Course/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_Course student_Course = db.Student_Courses.Find(id);
            if (student_Course == null)
            {
                return HttpNotFound();
            }
            return View(student_Course);
        }

        // GET: Student_Course/Create
        public ActionResult Create()
        {
            ViewBag.CourseID = new SelectList(db.Courses, "CourseID", "Title");
            ViewBag.StudentID = new SelectList(db.Students, "StudentID", "Name");
            return View();
        }

        // POST: Student_Course/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Student_CourseID,CourseID,StudentID")] Student_Course student_Course)
        {
            if (ModelState.IsValid)
            {
                db.Student_Courses.Add(student_Course);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CourseID = new SelectList(db.Courses, "CourseID", "Title", student_Course.CourseID);
            ViewBag.StudentID = new SelectList(db.Students, "StudentID", "Name", student_Course.StudentID);
            return View(student_Course);
        }

        // GET: Student_Course/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_Course student_Course = db.Student_Courses.Find(id);
            if (student_Course == null)
            {
                return HttpNotFound();
            }
            ViewBag.CourseID = new SelectList(db.Courses, "CourseID", "Title", student_Course.CourseID);
            ViewBag.StudentID = new SelectList(db.Students, "StudentID", "Name", student_Course.StudentID);
            return View(student_Course);
        }

        // POST: Student_Course/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Student_CourseID,CourseID,StudentID")] Student_Course student_Course)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student_Course).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CourseID = new SelectList(db.Courses, "CourseID", "Title", student_Course.CourseID);
            ViewBag.StudentID = new SelectList(db.Students, "StudentID", "Name", student_Course.StudentID);
            return View(student_Course);
        }

        // GET: Student_Course/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_Course student_Course = db.Student_Courses.Find(id);
            if (student_Course == null)
            {
                return HttpNotFound();
            }
            return View(student_Course);
        }

        // POST: Student_Course/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student_Course student_Course = db.Student_Courses.Find(id);
            db.Student_Courses.Remove(student_Course);
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
