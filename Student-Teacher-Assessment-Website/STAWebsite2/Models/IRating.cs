using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STAWebsite2.Models
{
    public class IRating
    {
        public int IRatingID { get; set; }
        public int SubCriteria1 { get; set; }
        public int SubCriteria2 { get; set; }
        public int SubCriteria3 { get; set; }
        public int SubCriteria4 { get; set; }
        public int SubCriteria5 { get; set; }
        public int SubCriteria6 { get; set; }
        public int SubCriteria7 { get; set; }
        public int SubCriteria8 { get; set; }
        public int SubCriteria9 { get; set; }
        public int SubCriteria10 { get; set; }
        public int SubCriteria11 { get; set; }
        public int SubCriteria12 { get; set; }
        public int SubCriteria13 { get; set; }
        public int SubCriteria14 { get; set; }
        public int SubCriteria15 { get; set; }
        public int SubCriteria16 { get; set; }
        public int SubCriteria17 { get; set; }
        public int SubCriteria18 { get; set; }
        public int SubCriteria19 { get; set; }
        public int SubCriteria20 { get; set; }
        public string Review { get; set; }

        public virtual Student Student { get; set; }
        public virtual Instructor Instructor { get; set; }
        public int? StudentID { get; set; }
        public int? InstructorID { get; set; }
    }
}