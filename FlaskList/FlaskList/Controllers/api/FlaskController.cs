using System;
using System.Linq;
using System.Web.Http;
using System.Collections.Generic;

namespace FlaskList.Controllers.api
{
    public class FlaskController : ApiController
    {
        private static List<KeyValuePair<int, string>> _data = new List<KeyValuePair<int, string>>();

        static FlaskController()
        {
            _data.Add(new KeyValuePair<int, string>(1, "Thermos"));
            _data.Add(new KeyValuePair<int, string>(2, "Schlenk"));
        }

        // GET api/flaskapi
        public IEnumerable<string> Get()
        {
            return _data.Select(x => x.Value);
        }

        // GET api/flaskapi/5
        public string Get(int id)
        {
            return _data.Where(x => x.Key == id).Select(x => x.Value).FirstOrDefault();
        }

        // POST api/flaskapi
        public void Post([FromBody]string value)
        {
            _data.Add(new KeyValuePair<int, string>(_data.Select(x => x.Key).Max() + 1, value));
        }

        // PUT api/flaskapi/5
        public void Put(int id, [FromBody]string value)
        {
            _data.RemoveAll(x => x.Key == id);
            _data.Add(new KeyValuePair<int, string>(id, value));
        }

        // DELETE api/flaskapi/5
        public void Delete(int id)
        {
            _data.RemoveAll(x => x.Key == id);
        }
    }
}
