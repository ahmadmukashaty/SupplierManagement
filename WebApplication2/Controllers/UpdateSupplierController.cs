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
    public class UpdateSupplierController : ApiController
    {
        private MongoContext _context = new MongoContext();

        [HttpPut]
        // Put api/<controller>
        public JsonResponse Put([FromBody]UpdateSupplierModel updatedSupplier)
        {
            try
            {
                _context.UpdateSupplier(updatedSupplier);
                return new JsonResponse(1, "", null);
            }
            catch (Exception ex)
            {
                return new JsonResponse(-1, ex.Message, null);
            }
        }
    }
}