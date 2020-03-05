using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace STAWebsite2.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public float avgSCRating { get; set; }
        public string verificationCode { get; set; }

        public int? InstructorID { get; set; }
        public virtual Instructor Instructor { get; set; }
        public virtual ICollection<Student_Course> Student_Courses { get; set; }
        public virtual ICollection<SCRating> SCRatings { get; set; }
    }
}