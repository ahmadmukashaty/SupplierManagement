using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class ProductManagement
    {
        public ProductModelView GetProductDetails(int productId, string token)
        {
            var client = new RestClient("https://northwind-products-api-ss.appspot.com/");
            var request = new RestRequest("product/" + productId.ToString(), Method.GET);

            request.AddHeader("Accept", "application/json");
            request.AddHeader("token", token);

            request.Parameters.Clear();
            request.AddParameter("token", token, ParameterType.HttpHeader);

            var response = client.Execute(request);

            ProductModelView value = JsonConvert.DeserializeObject<ProductModelView>(response.Content);
            Console.WriteLine(value);
            return value;
        }

        public string UpdateProduct(ProductModelView product, string token)
        {
            var client = new RestClient("https://northwind-products-api-ss.appspot.com/");
            var request = new RestRequest("updatepro/" + product.ProductID.ToString(), Method.PUT);

            UpdateProductModelView updateProduct = new UpdateProductModelView(product);
            var output = JsonConvert.SerializeObject(updateProduct);

            request.AddHeader("Accept", "application/json");
            request.AddHeader("token", token);

            request.Parameters.Clear();
            request.AddParameter("token", token, ParameterType.HttpHeader);
            request.AddJsonBody(output);

            var response = client.Execute(request);

            string value = JsonConvert.DeserializeObject<string>(response.Content);
            Console.WriteLine(value);
            return value;
        }

        public List<ProductModelView> GetProductBySupplierId(string SupplierId, string token)
        {
            var client = new RestClient("https://northwind-products-api-ss.appspot.com/");
            var request = new RestRequest("productbysupplier/" + SupplierId, Method.GET);

            request.AddHeader("Accept", "application/json");
            request.AddHeader("token", token);

            request.Parameters.Clear();
            request.AddParameter("token", token, ParameterType.HttpHeader);

            var response = client.Execute(request);

            List<ProductModelView> value = JsonConvert.DeserializeObject<List<ProductModelView>>(response.Content);
            Console.WriteLine(value);
            return value;
        }

    }
}