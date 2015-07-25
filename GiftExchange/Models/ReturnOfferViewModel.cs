using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GiftExchange.Models
{
    public class ReturnOfferViewModel
    {
        public Guid? id { get; set; }
        public Guid? ReturnId { get; set; }
        public Guid? VendorUserID { get; set; }

        public string CreateDate { get; set; }
        public string AlterDate { get; set; }

        public virtual IEnumerable<ReturnOfferItemViewModel> ReturnItems { get; set; }
    }
}