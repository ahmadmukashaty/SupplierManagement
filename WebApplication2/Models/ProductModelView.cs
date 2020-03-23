using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebApplication2.Models
{
    [BsonIgnoreExtraElements]
    [BsonNoId]
    public class ProductModelView
    {
        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        [DataMember]
        [BsonElement("﻿ProductID")]
        public string ProductID { get; set; }

        [DataMember]
        [BsonElement("ProductName")]
        public string ProductName { get; set; }

        [DataMember]
        [BsonElement("SupplierID")]
        public string SupplierID { get; set; }

        [DataMember]
        [BsonElement("CategoryID")]
        public string CategoryID { get; set; }

        [DataMember]
        [BsonElement("QuantityPerUnit")]
        public string QuantityPerUnit { get; set; }

        [DataMember]
        [BsonElement("UnitPrice")]
        public string UnitPrice { get; set; }

        [DataMember]
        [BsonElement("UnitsInStock")]
        public string UnitsInStock { get; set; }

        [DataMember]
        [BsonElement("UnitsOnOrder")]
        public string UnitsOnOrder { get; set; }

        [DataMember]
        [BsonElement("ReorderLevel")]
        public string ReorderLevel { get; set; }

        [DataMember]
        [BsonElement("Discontinued")]
        public string Discontinued { get; set; }
    }
}