using STAWebsite2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace STAWebsite2.DAL
{
    public class STAContext :DbContext
    {
        public STAContext() : base("STAContext")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<SCRating> SCRatings { get; set; }
        public DbSet<IRating> IRatings { get; set; }
        public DbSet<Student_Course> Student_Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}