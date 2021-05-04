using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LearnTodayWebAPI.Models;

namespace LearnTodayWebAPI.Controllers
{
    public class AdminController : ApiController
    {
        LearnTodayWebAPIContext db = new LearnTodayWebAPIContext();
        public IEnumerable<Course> GetAllCourses()
        {
            return db.Courses.ToList();
        }
        public HttpResponseMessage GetCourseById(int id)
        {
            var entity = db.Courses.FirstOrDefault(c => c.CourseId == id);
            if (entity != null)
                return Request.CreateResponse(HttpStatusCode.OK, entity);
            else
                return Request.CreateResponse(HttpStatusCode.NotFound, $"Search Data not Found");
        }
    }
}
