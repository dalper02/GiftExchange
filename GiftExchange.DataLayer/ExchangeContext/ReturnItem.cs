using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftExchange.DataLayer.ExchangeContext
{
    public class ReturnItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int Quantity { get; set; }
        public string UPC { get; set; }
        public string Description { get; set; }

        public Guid? ReturnId { get; set; }
        [ForeignKey("ReturnId")]
        public virtual Return Return { get; set; }
    }
}
