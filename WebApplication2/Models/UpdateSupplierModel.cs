using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class UpdateSupplierModel
    {
        public SupplierModelView newRecord { get; set; }
        public string SupplierID { get; set; }
    }
}