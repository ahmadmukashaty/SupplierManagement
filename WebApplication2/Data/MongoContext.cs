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
            database = client.GetDatabase("Northwind");
        }

        public object getSuppliers()
        {
            var collection = database.GetCollection<SupplierModelView>("Suppliers");

            List<SupplierModelView> suppliers = collection.Find(new BsonDocument()).ToList();
            return suppliers;
        }

        public object getSuppliers(string id)
        {
            var collection = database.GetCollection<SupplierModelView>("Suppliers");
            var filter = Builders<SupplierModelView>.Filter.Eq("SupplierID", id);

            return collection.Find(filter).First();
        }

        public object getProducts()
        {
            var collection = database.GetCollection<ProductModelView>("Products");

            List<ProductModelView> products = collection.Find(new BsonDocument()).ToList();
            return products;
        }

        public void CreateSupplier(SupplierModelView supplier)
        {
            var collection = database.GetCollection<SupplierModelView>("Suppliers");
            collection.InsertOne(supplier);
        }

        public void DeleteSupplier(String SupplierID)
        {
            var collection = database.GetCollection<SupplierModelView>("Suppliers");
            var filter = Builders<SupplierModelView>.Filter.Eq("SupplierID", SupplierID);
            collection.DeleteOne(filter);
        }

        public void UpdateSupplier(UpdateSupplierModel updatedSupplier)
        {
            var collection = database.GetCollection<SupplierModelView>("Suppliers");
            var filter = Builders<SupplierModelView>.Filter.Eq("SupplierID", updatedSupplier.SupplierID);
            var result = collection.ReplaceOne(filter, updatedSupplier.newRecord);
        }

        public object GetSupplierProducts(string SupplierID)
        {
            var collection = database.GetCollection<ProductModelView>("Products");
            var filter = Builders<ProductModelView>.Filter.Eq("SupplierID", SupplierID);

            return collection.Find(filter).ToList();
        }

    }
}