using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftExchange.DTOs.ReturnOfferDTOs
{
    public class ReturnOfferDTO
    {
        public Guid? id { get; set; }
        public Guid? ReturnId { get; set; }
        public Guid? VendorUserID { get; set; }

        public string CreateDate { get; set; }
        public string AlterDate { get; set; }

        public virtual ICollection<ReturnOfferItemDTO> ReturnOfferItems { get; set; }
    }
}
