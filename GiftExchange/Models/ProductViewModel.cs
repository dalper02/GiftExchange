using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GiftExchange.Models
{
    public class ProductViewModel
    {

        public ProductViewModel()
        {
        }

        public ProductViewModel(string pUPC, string pDescription)
        {
            UPC = pUPC;
            description = pDescription;
        }

        public int id { get; set; }
        public int Quantity { get; set; }
        public string UPC { get; set; }
        public string description { get; set; }
    }
}