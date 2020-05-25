using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Script.Serialization;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class UserManagement
    {
        public string GetToken()
        {
            var strJSONContent = new JavaScriptSerializer().Serialize(new UserInfo());

            var client = new RestClient("http://35.238.195.26:8080/authenticate");
            var request = new RestRequest();


            request.Method = Method.POST;
            request.AddHeader("Accept", "application/json");
            request.Parameters.Clear();
            request.AddParameter("application/json", strJSONContent, ParameterType.RequestBody);

            var response = client.Execute(request);

            var values = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
            return values["token"];
        }
    }
}