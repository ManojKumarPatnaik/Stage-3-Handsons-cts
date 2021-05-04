using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StudentService.Models;

namespace StudentService.Controllers
{
    public class StudentsController : ApiController
    {
        StudentDBContext db = new StudentDBContext();
        //public IEnumerable<Student> Get()
        //{
        //    return db.Students.ToList();
        //}
        //public Student Get(int id)
        //{
        //    return db.Students.FirstOrDefault(s => s.ID == id);
        //}
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, db.Students.ToList());
        }
        public HttpResponseMessage Get(int id)
        {
            var entity = db.Students.FirstOrDefault(s => s.ID == id);
            if (entity != null)
                return Request.CreateResponse(HttpStatusCode.OK, entity);
            else
                return Request.CreateResponse(HttpStatusCode.NotFound, $"Student with Id {id} not found");
        }
        public HttpResponseMessage Put(int id,[FromBody] Student student)
        {
            try
            {
                var entity = db.Students.FirstOrDefault(s => s.ID == id);
                if (entity == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, $"Student with Id {id} not found");
                }
                else
                {

                    entity.FirstName = student.FirstName;
                    entity.LastName = student.LastName;
                    entity.Gender = student.Gender;
                    entity.Address = student.Address;

                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, entity);
                }
            }
            catch(Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e);
            }
           
        }
        public HttpResponseMessage Post([FromBody] Student student)
        {
            try
            {
                db.Students.Add(student);
                db.SaveChanges();
                var msg = Request.CreateResponse(HttpStatusCode.Created, student);
                return msg;

            }
            catch(Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e);
            }
            
        }
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var entity = db.Students.FirstOrDefault(s => s.ID == id);
                if (entity == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, $"Student with Id {id} not found");
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
