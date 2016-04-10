using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL;

namespace TamarProject.Controllers
{
    public class DressController : ApiController
    {
        public IEnumerable<dresses> Get()
        {
            return new dresses[] { };
        }

        public dresses Get(int id)
        {
            return new dresses();
        }

        public void Post([FromBody]dresses value)
        {
        }

        public void Put(int id, [FromBody]dresses value)
        {
        }

        public void Delete(int id)
        {
        }
    }
}
