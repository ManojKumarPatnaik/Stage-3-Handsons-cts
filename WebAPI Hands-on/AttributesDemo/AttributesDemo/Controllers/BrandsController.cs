using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AttributesDemo.Models;

namespace AttributesDemo.Controllers
{
    public class BrandsController : ApiController
    {

        public HttpResponseMessage Post([FromUri] Brand brand)
        {
            Brand b = new Brand();
            List<Brand> list = b.GetList();
            list.Add(brand);
            var msg = Request.CreateResponse(HttpStatusCode.Created, brand);
            return msg;
        }
    }
}
