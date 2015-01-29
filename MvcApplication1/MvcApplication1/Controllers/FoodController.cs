using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace MvcApplication1.Controllers
{
    public class FoodController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage get()
        {
            var data = "[{'id':'0','name':'面条','price':'18￥','img':'./images/miantiao.jpg'},{'id':'1','name':'面条','price':'18￥','img':'./images/miantiao.jpg'}]";
            return Request.CreateResponse(HttpStatusCode.OK,data);
        }

    }
}
