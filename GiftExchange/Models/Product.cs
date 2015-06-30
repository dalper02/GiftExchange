using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GiftExchange.Models
{
    public class Product
    {

        public Product()
        {
        }

        public Product(string pUPC, string pDescription)
        {
            UPC = pUPC;
            description = pDescription;
        }
        public string UPC { get; set; }
        public string description { get; set; }
    }
}