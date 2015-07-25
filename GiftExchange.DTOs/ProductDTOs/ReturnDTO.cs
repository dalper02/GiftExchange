using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftExchange.DTOs.ProductDTOs
{
    public class ReturnDTO
    {
        public Guid? id { get; set; }
        public Guid? userID { get; set; }

        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreateDate { get; set; }
        public DateTime AlterDate { get; set; }

        public virtual ICollection<ProductDTO> ReturnItems { get; set; }
    }
}
