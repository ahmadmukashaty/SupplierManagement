using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class JsonResponse
    {
        public int result { get; set; }

        public string errorMessage { get; set; }

        public object data { get; set; }

        public JsonResponse(int result, string errorMessage, object data)
        {
            this.result = result;
            this.errorMessage = errorMessage;
            this.data = data;
        }
    }
}