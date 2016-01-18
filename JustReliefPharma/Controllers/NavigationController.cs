using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using JustReliefDataAccess.DataObject;
using JustReliefDataAccess.DataAccess;

namespace JustReliefPharma.Controllers
{
    public class NavigationController : ApiController
    {
        // GET: api/Navigation
        public List<Navigation> Get()
        {

            List<Navigation> ojj = new DA_Navigation().GetNavigationList("Home");

            return ojj;
        }

        // GET: api/Navigation/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Navigation
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Navigation/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Navigation/5
        public void Delete(int id)
        {
        }
    }
}
