using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL;

namespace TamarProject.Controllers
{
    public class CustomerController : ApiController
    {
        public IEnumerable<customers> Get()
        {
            return new customers[] { };
        }

        public customers Get(String userName)
        {
            return new customers();
        }

        public void Post([FromBody]customers value)
        {
        }

        public void Put(int id, [FromBody]customers value)
        {
        }

        public void Delete(int id)
        {
        }
    }
}
