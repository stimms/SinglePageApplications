using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FlaskList.Controllers.api
{
    public class FlaskAPIController : ApiController
    {
        // GET api/flaskapi
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/flaskapi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/flaskapi
        public void Post([FromBody]string value)
        {
        }

        // PUT api/flaskapi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/flaskapi/5
        public void Delete(int id)
        {
        }
    }
}
