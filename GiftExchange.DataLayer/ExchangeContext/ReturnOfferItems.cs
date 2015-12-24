using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftExchange.DataLayer.ExchangeContext
{
    public class ReturnOfferItems
    {
        public int id { get; set; }
        public int ReturnItemId { get; set; }
        public int isOffered { get; set; }
        public decimal price { get; set; }


        public Guid ReturnOfferId { get; set; }

        [ForeignKey("ReturnOfferId")]
        public virtual ReturnOffer ReturnOffer { get; set; }

        public string CreateDate { get; set; }
        public string AlterDate { get; set; }
    }
}
