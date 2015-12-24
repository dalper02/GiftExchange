using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftExchange.DataLayer.ExchangeContext
{
    public class ReturnOffer
    {
        public Guid? id { get; set; }
        public Guid? ReturnId { get; set; }
        public Guid? VendorUserID { get; set; }

        public string CreateDate { get; set; }
        public string AlterDate { get; set; }

        public virtual ICollection<ReturnOfferItems> ReturnOfferItems { get; set; }
    }
}
