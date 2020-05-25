using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class UserInfo
    {
        public string username { get; set; }
        public string password { get; set; }

        public UserInfo()
        {
            this.username = "admin";
            this.password = "admin";
        }
    }
}