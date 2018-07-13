using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _00_basic_web_api.Controllers
{
    public class TravelController : ApiController
    {
        // GET: api/Travel
        public IEnumerable<string> Get()
        {
            return new string[] { "Travel1", "Travel2" };
        }

        // GET: api/Travel/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Travel
        public string Post([FromBody]string value)
        {
            return $"server got {value}";
        }

        // PUT: api/Travel/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Travel/5
        public void Delete(int id)
        {
        }
    }
}
