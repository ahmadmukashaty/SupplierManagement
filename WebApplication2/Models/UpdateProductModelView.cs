using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class UpdateProductModelView
    {
        public string ProductID { get; set; }

        public string ProductName { get; set; }

        public string SupplierID { get; set; }

        public string CategoryID { get; set; }

        public string QuantityPerUnit { get; set; }

        public string UnitPrice { get; set; }

        public string UnitsInStock { get; set; }

        public string UnitsOnOrder { get; set; }

        public string ReorderLevel { get; set; }

        public string Discontinued { get; set; }

        public UpdateProductModelView(ProductModelView product)
        {
            this.ProductID = product.ProductID;
            this.ProductName = product.ProductName;
            this.SupplierID = product.SupplierID;
            this.CategoryID = product.CategoryID;
            this.QuantityPerUnit = product.QuantityPerUnit;
            this.UnitPrice = product.UnitPrice;
            this.UnitsInStock = product.UnitsInStock;
            this.UnitsOnOrder = product.UnitsOnOrder;
            this.ReorderLevel = product.ReorderLevel;
            this.Discontinued = product.Discontinued;
        }
    }
}