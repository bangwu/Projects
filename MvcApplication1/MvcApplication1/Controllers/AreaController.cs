using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApplication1.Controllers
{
    public class AreaController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage index() 
        {
            string data = "[{'name':'武汉'},{'name':'北京'},{'name':'西安'},{'name':'成都'}]";
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
