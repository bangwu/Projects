using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApplication1.Controllers
{
    public class FoodTypeController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage index()
        {
            string data = "[{'name':'川菜'},{'name':'香菜'},{'name':'鲁菜'},{'name':'粤菜'}]";
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
