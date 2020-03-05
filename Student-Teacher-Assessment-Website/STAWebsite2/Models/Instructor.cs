using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace STAWebsite2.Models
{
    public class Instructor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InstructorID { get; set; }

        [Required(ErrorMessage = "*Enter valid name")]
        [Display(Name = "Instructor Name")]
        public string Name { get; set; }
        public string Department { get; set; }
        [Required(ErrorMessage = "*Enter valid password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        public float avgIRating { get; set; }
        public int WarningNo { get; set; }
        public string LoginStatus { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<IRating> IRatings { get; set; }
        public virtual ICollection<SCRating> SCRatings { get; set; }
    }
}