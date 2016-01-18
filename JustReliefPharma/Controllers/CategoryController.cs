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
    public class CategoryController : ApiController
    {
        // GET: api/Category
        public List<category> Get()
        {
  
          List<category> ojj = new DA_Category().GetCategoryList();

            return ojj;
        }

        // GET: api/Category/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Category
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Category/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Category/5
        public void Delete(int id)
        {
        }
    }
}
