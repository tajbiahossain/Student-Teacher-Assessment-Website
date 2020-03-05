using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STAWebsite2.Models
{
    public class SCRating
    {
        public int SCRatingID { get; set; }
        public int SubCriteria1 { get; set; }
        public int SubCriteria2 { get; set; }
        public int SubCriteria3 { get; set; }
        public int SubCriteria4 { get; set; }
        public int SubCriteria5 { get; set; }
        public int SubCriteria6 { get; set; }
        public int SubCriteria7 { get; set; }
        public string Review { get; set; }

        public virtual Instructor Instructor { get; set; }
        public virtual Course Course { get; set; }
        public int? CourseID { get; set; }
        public int? InstructorID { get; set; }
    }
}