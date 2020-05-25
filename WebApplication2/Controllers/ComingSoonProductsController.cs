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
    public class ComingSoonProductsController : ApiController
    {
        ComingSoonManagement _context = new ComingSoonManagement();
        // GET api/<controller>
        public JsonResponse Get()
        {
            try
            {
                return new JsonResponse(1, "", _context.GetComingSoonProducts());
            }
            catch (Exception ex)
            {
                return new JsonResponse(-1, ex.Message, null);
            }
        }
    }
}