using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentApplication.Models;

namespace StudentApplication.DAL
{
    public class SchoolInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
                new Student{FirstName="Charles", LastName="Montemayor", EnrollmentDate=DateTime.Parse("12-10-2018")},
                new Student{FirstName="Monica", LastName="Cabreza", EnrollmentDate=DateTime.Parse("01-02-2019")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var courses = new List<Course>
            {
                new Course{CourseID=0010, Title="Chemistry", Credits=3},
                new Course{CourseID=0150, Title="Mathematics", Credits=4},
                new Course{CourseID=0230, Title="Economics", Credits=2},
                new Course{CourseID=0305, Title="Literature", Credits=1}
            };

            courses.ForEach(c => context.Courses.Add(c));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
                new Enrollment{StudentID=1, CourseID=0010, Grade=Grade.A},
                new Enrollment{StudentID=1, CourseID=0150, Grade=Grade.C},
                new Enrollment{StudentID=2, CourseID=0230, Grade=Grade.B},
                new Enrollment{StudentID=2, CourseID=0305, Grade=Grade.D}
            };

            enrollments.ForEach(e => context.Enrollments.Add(e));
            context.SaveChanges();
        }
    }
}