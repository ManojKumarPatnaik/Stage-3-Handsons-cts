using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AttributesDemo.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Trainer { get; set; }
        public float Fees { get; set; }
        public string CourseDescription { get; set; }



        static List<Course> courses = new List<Course>()
        {
            new Course() {CourseId = 1, CourseName = "Android", Trainer = "Shawn", Fees = 12000,
                CourseDescription = "Android is a mobile OS development" },

            new Course() {CourseId = 2, CourseName = "ASP.NET", Trainer = "Kevin", Fees = 10000,
                CourseDescription = "ASP.NET is a open source web developemt framework" },

            new Course() {CourseId = 3, CourseName = "JSP", Trainer = "Debaratha", Fees = 10000,
                CourseDescription = "Java server pages is a technology used for web page creations" },

            new Course() {CourseId = 4, CourseName = "Xamarin.forms", Trainer = "Mark John", Fees = 15000,
                CourseDescription = "Xamarin forms are cross platform UI tools" }
        };

        public List<Course> GetList()
        {
            return courses;
        }

    }
}