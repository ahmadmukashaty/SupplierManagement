using MongoDB.Bson;
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
    public class SupplierModelView
    {
        [DataMember]
        [BsonElement("﻿SupplierID")]
        public string SupplierID { get; set; }

        [DataMember]
        [BsonElement("CompanyName")]
        public string CompanyName { get; set; }

        [DataMember]
        [BsonElement("ContactName")]
        public string ContactName { get; set; }

        [DataMember]
        [BsonElement("ContactTitle")]
        public string ContactTitle { get; set; }

        [DataMember]
        [BsonElement("Address")]
        public string Address { get; set; }

        [DataMember]
        [BsonElement("City")]
        public string City { get; set; }

        [DataMember]
        [BsonElement("Region")]
        public string Region { get; set; }

        [DataMember]
        [BsonElement("PostalCode")]
        public string PostalCode { get; set; }

        [DataMember]
        [BsonElement("Country")]
        public string Country { get; set; }

        [DataMember]
        [BsonElement("Phone")]
        public string Phone { get; set; }

        [DataMember]
        [BsonElement("Fax")]
        public string Fax { get; set; }

        [DataMember]
        [BsonElement("HomePage")]
        public string HomePage { get; set; }
    }
}