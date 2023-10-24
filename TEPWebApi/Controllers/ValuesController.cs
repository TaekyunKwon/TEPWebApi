using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TEPWebApi.Controllers
{
    public class ValuesController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "Value1", "Value2" };
        }

        [HttpGet]
        public IEnumerable<string> TEP()
        {
            return new string[] { "Value1", "Value2" };
        }

        //Get api/values?id=
        public string Get(int id)
        {
            return "Value-ID";
        }

        //Post api/values
        public void Post([FromBody]string value)
        {

        }

        //Put api/values/5
        public void Put(int id, [FromBody]string value)
        {

        }

        //Delete api/values/5
        public void Delete(int id)
        {

        }
    }
}
