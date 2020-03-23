using MongoDB.Driver;
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
    public class GetSupplierController : ApiController
    {
        private MongoContext _context = new MongoContext();
        // GET: api/GetSupplier
        public JsonResponse Get()
        {
            try
            {
                return new JsonResponse(1, "", _context.getSuppliers());
            }catch(Exception ex)
            {
                return new JsonResponse(-1, ex.Message, null);
            }
        }

        // GET: api/GetSupplier/5
        public object Get(string id)
        {
            try
            {
                return new JsonResponse(1, "", _context.getSuppliers(id));
            }
            catch (Exception ex)
            {
                return new JsonResponse(-1, ex.Message, null);
            }
        }
    }
}
