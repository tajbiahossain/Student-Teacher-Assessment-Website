using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STAWebsite2.Models
{
    public class Student_Course
    {
        public int Student_CourseID { get; set; }
        public int? CourseID { get; set; }
        public int? StudentID { get; set; }

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}