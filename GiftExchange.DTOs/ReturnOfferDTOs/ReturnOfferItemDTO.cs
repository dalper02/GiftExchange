using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftExchange.DTOs.ReturnOfferDTOs
{
    public class ReturnOfferItemDTO
    {
        public int id { get; set; }
        public int ReturnItemId { get; set; }
        public int isOffered { get; set; }
        public decimal price { get; set; }

        public Guid ReturnOfferId { get; set; }

        //[ForeignKey("ReturnOfferId")]
        //public virtual ReturnOfferDTO ReturnOffer { get; set; }

        public string CreateDate { get; set; }
        public string AlterDate { get; set; }
    }
}
