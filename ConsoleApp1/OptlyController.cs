using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ConsoleApp1
{
    public class OptlyController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "GetList", "value1", "value2" };
        }

        public string Get(int id)
        {
            return "Get" + id;
        }

        public string Post([FromBody]string value)
        {
            return "POST" + value;
        }

        public string Put(int id, [FromBody]string value)
        {
            return "PUT" + id + value;
        }

        public string Delete(int id)
        {
            return "DELETE" + id;
        }
    }
}
