using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AttributesDemo.Models;

namespace AttributesDemo.Controllers
{
    public class CourseController : ApiController
    {
        //public HttpResponseMessage Get()
        //{
        //    Course c = new Course();
        //    List<Course> list = c.GetList();
        //    return Request.CreateResponse(HttpStatusCode.OK, list);
        //}

        public HttpResponseMessage Get(string courseName )
        {
            Course c = new Course();
            List<Course> list = c.GetList();
            foreach (var item in list)
            {
                if (item.CourseName.Equals(courseName, StringComparison.InvariantCultureIgnoreCase))
                {
                    return Request.CreateResponse(HttpStatusCode.OK, item);
                }
            }
 
            return Request.CreateResponse(HttpStatusCode.NotFound, $"Course Name - {courseName} not found");
        }

        public HttpResponseMessage Post([FromBody] Course course)
        {
            Course c = new Course();
            List<Course> list = c.GetList();
            list.Add(course);
            var msg = Request.CreateResponse(HttpStatusCode.Created, course);
            return msg;
        }
    }
}
