

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using STAWebsite2.Models;

namespace STAWebsite2.DAL
{
    public class STAInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<STAContext>
    {
        protected override void Seed(STAContext context)
        {
            var students = new List<Student>
            {
            new Student{Name="Nowrin Yasmin",StudentID=160104001,Semester=2,Year=3,WarningNo=0,LoginStatus="yes",Password="123456"},
            new Student{Name="Tajbia Hossain",StudentID=160104008,Semester=2,Year=3,WarningNo=0,LoginStatus="yes",Password="012345"},
            new Student{Name="Humaira Zahin Mauni",StudentID=160104012,Semester=2,Year=3,WarningNo=0,LoginStatus="yes",Password="987654"}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
            new Course{CourseID=3211,Title="Data Communication",avgSCRating=0,verificationCode="hf4ry7"},
            new Course{CourseID=3213,Title="Operating System",avgSCRating=0,verificationCode="vfd34x"},
            new Course{CourseID=3214,Title="Operating System Lab",avgSCRating=0,verificationCode="45lshf"},
            new Course{CourseID=3215,Title="Microcontroller based System Design",avgSCRating=0,verificationCode="hdf12d"},
            new Course{CourseID=3216,Title="Microcontroller based System Design Lab",avgSCRating=0,verificationCode="as5bhg"},
            new Course{CourseID=3223,Title="Information System Design & Software Engineering",avgSCRating=0,verificationCode="7tet89"},
            new Course{CourseID=3224,Title="Information System Design & Software Engineering Lab",avgSCRating=0,verificationCode="gh457r"},
            new Course{CourseID=3200,Title="Software Development V",avgSCRating=0,verificationCode="h8t5uh"},
            new Course{CourseID=3207,Title="Industrial Law & Safety Management",avgSCRating=0,verificationCode="s030ii"}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();

            var instructors = new List<Instructor>
            {
                new Instructor{InstructorID=0001,Name="Miss X",avgIRating=0,Department="CSE",LoginStatus="no",Password="asdfgh",WarningNo=0},
                new Instructor{InstructorID=0002,Name="Mr Y",avgIRating=0,Department="CSE",LoginStatus="no",Password="lkjhg",WarningNo=0},
                new Instructor{InstructorID=0003,Name="Mrs Z",avgIRating=0,Department="CSE",LoginStatus="no",Password="mnbvc",WarningNo=0}
            };
            instructors.ForEach(s => context.Instructors.Add(s));
            context.SaveChanges();

            var iratings = new List<IRating>
            {
                new IRating{SubCriteria1=5,SubCriteria2=5,SubCriteria3=5,SubCriteria4=5,SubCriteria5=5,SubCriteria6=5,
                    SubCriteria7 =5,SubCriteria8=5,SubCriteria9=5,SubCriteria10=5,SubCriteria11=5,SubCriteria12=5,
                    SubCriteria13 =5,SubCriteria14=5,SubCriteria15=5,SubCriteria16=5,SubCriteria17=5,SubCriteria18=5,
                    SubCriteria19 =5,SubCriteria20=5,Review="Today's class was very englightening.",StudentID=160104001,InstructorID=0001}
            };
            iratings.ForEach(s => context.IRatings.Add(s));
            context.SaveChanges();

            var scratings = new List<SCRating>
            {
                new SCRating{InstructorID=0001,CourseID=3213,SubCriteria1=5,SubCriteria2=5,SubCriteria3=5,SubCriteria4=5,SubCriteria5=5,SubCriteria6=5,SubCriteria7=5}
            };
            scratings.ForEach(s => context.SCRatings.Add(s));
            context.SaveChanges();

            var studentcourses = new List<Student_Course>
            {
                new Student_Course{CourseID=3213,StudentID=160104001},
                new Student_Course{CourseID=3214,StudentID=160104001},
                new Student_Course{CourseID=3213,StudentID=160104008}
            };
            studentcourses.ForEach(s => context.Student_Courses.Add(s));
            context.SaveChanges();
        }
    }
}