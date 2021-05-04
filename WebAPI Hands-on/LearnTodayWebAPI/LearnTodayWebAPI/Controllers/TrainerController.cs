using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LearnTodayWebAPI.Models;

namespace LearnTodayWebAPI.Controllers
{
    public class TrainerController : ApiController
    {
        LearnTodayWebAPIContext db = new LearnTodayWebAPIContext();
       
        [HttpPost]
        public HttpResponseMessage TrainerSignUp([FromBody] Trainer trainer)
        {
            try
            {
                db.Trainers.Add(trainer);
                db.SaveChanges();
                var msg = Request.CreateResponse(HttpStatusCode.Created, trainer);
                return msg;

            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e);
            }
        }

        [HttpPut]
        public HttpResponseMessage UpdatePassword(int id, [FromBody] Trainer trainer)
        {
            try
            {
                var entity = db.Trainers.FirstOrDefault(t => t.TrainerId == id);
                if (entity == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, $"Searched Data not Found");
                }
                else
                {
                    entity.Password = trainer.Password;

                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, $"Data updated successfully");
                }
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e);
            }

        }
       


    }
}
