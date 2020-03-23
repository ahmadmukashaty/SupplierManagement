using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CreateSupplierController : ApiController
    {
        private MongoContext _context = new MongoContext();

        // POST: api/CreateSupplier
        [HttpPost]
        public JsonResponse Post([FromBody]SupplierModelView supplier)
        {
            try
            {
                _context.CreateSupplier(supplier);
                return new JsonResponse(1, "", null);
            }
            catch (Exception ex)
            {
                return new JsonResponse(-1, ex.Message, null);
            }
        }

        // PUT: api/CreateSupplier/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CreateSupplier/5
        public void Delete(int id)
        {
        }
    }
}
