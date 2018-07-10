# Basic application with rest api (c#)

## steps to create the project:
* Create a new `web api 2` project
* Add a `web api controller with read and write options` and name it `DefaultController`
* As result see in rhe following path `\01_Basic api\Basic api\Controllers` this content:
```csharp
using System.Collections.Generic;
using System.Web.Http;

namespace Basic_api.Controllers
{
    public class DefaultController : ApiController
    {
        // GET: api/Default
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Default/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Default
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Default/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Default/5
        public void Delete(int id)
        {
        }
    }
}


```