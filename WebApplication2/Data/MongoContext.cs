using MongoDB.Bson;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class MongoContext
    {
        private MongoClient client { get; set; }
        private IMongoDatabase database { get; set; }

        public MongoContext()
        {
            client = new MongoClient("mongodb+srv://test:test@cluster0-shcof.azure.mongodb.net/test?connect=replicaSet");
            database = client.GetDatabase("SupplierDB");
        }

        public object getSuppliers()
        {
            var collection = database.GetCollection<SupplierModelView>("Supplier");

            List<SupplierModelView> suppliers = collection.Find(new BsonDocument()).ToList();
            return suppliers;
        }

        public object getSuppliers(string id)
        {
            var collection = database.GetCollection<SupplierModelView>("Supplier");
            var filter = Builders<SupplierModelView>.Filter.Eq("SupplierID", id);

            return collection.Find(filter).First();
        }

        //public object getProducts()
        //{
        //    var collection = database.GetCollection<ProductModelView>("Products");

        //    List<ProductModelView> products = collection.Find(new BsonDocument()).ToList();
        //    return products;
        //}

        public void CreateSupplier(SupplierModelView supplier)
        {
            var collection = database.GetCollection<SupplierModelView>("Supplier");
            collection.InsertOne(supplier);
        }

        public void DeleteSupplier(String SupplierID)
        {
            var collection = database.GetCollection<SupplierModelView>("Supplier");
            var filter = Builders<SupplierModelView>.Filter.Eq("SupplierID", SupplierID);
            collection.DeleteOne(filter);
        }

        public void UpdateSupplier(UpdateSupplierModel updatedSupplier)
        {
            var collection = database.GetCollection<SupplierModelView>("Supplier");
            var filter = Builders<SupplierModelView>.Filter.Eq("SupplierID", updatedSupplier.SupplierID);
            var result = collection.ReplaceOne(filter, updatedSupplier.updatedRecord);
        }

        public object GetSupplierProducts(string SupplierID)
        {
            UserManagement userManagement = new UserManagement();
            ProductManagement productManagement = new ProductManagement();
            string token = userManagement.GetToken();
            List<ProductModelView> products = productManagement.GetProductBySupplierId(SupplierID, token);

            return products;
        }

        public void SupplyProduct(SupplyProductModelView supplyProduct)
        {
            UserManagement userManagement = new UserManagement();
            ProductManagement productManagement = new ProductManagement();
            string token = userManagement.GetToken();
            ProductModelView product = productManagement.GetProductDetails(supplyProduct.ProductId, token);
            product.UnitsInStock = (int.Parse(product.UnitsInStock) + supplyProduct.Quantity).ToString();
            productManagement.UpdateProduct(product, token);
            
        }

    }
}