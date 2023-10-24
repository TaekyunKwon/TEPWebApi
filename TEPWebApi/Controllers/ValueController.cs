using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TEPWebApi.Controllers
{
    public class ValueController : ApiController
    {
        public string Get() {
            return "API test in local sesrver.";
        }

        public void Post([FromBody] string value)
        {

        }
    }
}
