using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LearnTodayWebAPI.Models;

namespace LearnTodayWebAPI.Controllers
{
    public class StudentController : ApiController
    {
        LearnTodayWebAPIContext db = new LearnTodayWebAPIContext();
        public IEnumerable<Course> GetAllCourses()
        {
            return db.Courses.OrderBy(c => c.Start_Date).ToList();
        }

        public HttpResponseMessage PostStudent([FromBody] Student student)
        {
            try
            {
                db.Students.Add(student);
                db.SaveChanges();
                var msg = Request.CreateResponse(HttpStatusCode.Created, student);
                return msg;

            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e);
            }

        }
        public HttpResponseMessage DeleteStudentEnrollment(int id)
        {
            try
            {
                var entity = db.Students.FirstOrDefault(s => s.EnrollmentId == id);
                if (entity == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, $"No enrollement information found");
                }
                else
                {
                    db.Students.Remove(entity);
                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, entity);
                }
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e);
            }
        }
    }
}
