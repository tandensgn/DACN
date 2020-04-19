using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DACN_SalePhone.Models
{
    public class Login
    {
        public int userID { set; get; }
        public string userName { set; get; }
        public string userEmail { set; get; }
        public string userPassword { set; get; }
        public int userLevel { set; get; }
    }
}