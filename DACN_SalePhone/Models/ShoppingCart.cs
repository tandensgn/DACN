using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DACN_SalePhone.Models
{
    public class ShoppingCart
    {
        public int scproductID { set; get; }
        public int orID { set; get; }
        public int scQuantity { set; get; }
        public string scproductName { set; get; }
        public int scUnitPrice { set; get; }
        public int scTotal { set; get; }
        public string scIcon { set; get; }
    }
}