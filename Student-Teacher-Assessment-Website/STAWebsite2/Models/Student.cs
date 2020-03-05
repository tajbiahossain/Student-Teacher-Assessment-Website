using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace STAWebsite2.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentID { get; set; }

        [Required(ErrorMessage = "*Enter valid name")]
        [Display(Name = "Student Name")]

        public string Name { get; set; }
        public int Year { get; set; }
        public int Semester { get; set; }

        [Required(ErrorMessage = "*Enter valid password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]

        public string Password { get; set; }
        public int WarningNo { get; set; }
        public string LoginStatus { get; set; }

        public virtual ICollection<Student_Course> Student_Courses { get; set; }
        public virtual ICollection<IRating> IRatings { get; set; }
    }
    
}