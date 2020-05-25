using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class SupplyProductController : ApiController
    {
        private MongoContext _context = new MongoContext();

        [HttpPost]
        public JsonResponse Post([FromBody]SupplyProductModelView productInfo)
        {
            try
            {
                _context.SupplyProduct(productInfo);
                return new JsonResponse(1, "", null);
            }
            catch (Exception ex)
            {
                return new JsonResponse(-1, ex.Message, null);
            }
        }
    }
}
