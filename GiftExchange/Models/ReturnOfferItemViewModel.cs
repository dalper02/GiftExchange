using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GiftExchange.Models
{
    public class ReturnOfferItemViewModel
    {
        public int id { get; set; }
        public int ReturnItemId { get; set; }
        public bool isOffered { get; set; }
        public decimal price { get; set; }

        public string CreateDate { get; set; }
        public string AlterDate { get; set; }
    }
}