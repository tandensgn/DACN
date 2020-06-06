using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DACN_SalePhone.Models
{
    public class Orders
    {
        public int orID { set; get; }
        public string cus_ID { set; get; }
        public DateTime orDate { set; get; }   
        public string orNumber { set; get; }
        public string orStatus { set; get; }
        public int cusTotal { set; get; }
    }
}