using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApplication1.Controllers
{
    public class PriceScopeController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage index()
        {
            string data = "[{'from':'0','to':'50'},{'from':'50','to':'100'},{'from':'100','to':'150'},{'from':'150','to':'200'}]";
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
