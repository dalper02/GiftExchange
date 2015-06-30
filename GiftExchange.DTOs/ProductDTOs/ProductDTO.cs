using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftExchange.DTOs.ProductDTOs
{
    public class ProductDTO
    {
        public ProductDTO()
        {
        }

        public ProductDTO(string pUPC, string pDescription)
        {
            UPC = pUPC;
            description = pDescription;
        }

        public string UPC { get; set; }
        public string description { get; set; }
    }
}
