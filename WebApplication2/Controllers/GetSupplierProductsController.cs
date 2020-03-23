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
    public class GetSupplierProductsController : ApiController
    {
        private MongoContext _context = new MongoContext();
        // GET api/<controller>/5
        public JsonResponse Get(string id)
        {
            try
            {
                return new JsonResponse(1, "", _context.GetSupplierProducts(id));
            }
            catch (Exception ex)
            {
                return new JsonResponse(-1, ex.Message, null);
            }
        }
    }
}