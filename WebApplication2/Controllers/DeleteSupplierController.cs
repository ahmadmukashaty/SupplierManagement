﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class DeleteSupplierController : ApiController
    {
        private MongoContext _context = new MongoContext();

        [HttpDelete]
        public JsonResponse Delete(int id)
        {
            try
            {
                _context.DeleteSupplier(id.ToString());
                return new JsonResponse(1, "", null);
            }
            catch (Exception ex)
            {
                return new JsonResponse(-1, ex.Message, null);
            }
        }
    }
}