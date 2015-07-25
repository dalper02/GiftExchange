using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftExchange.DataLayer.ExchangeContext
{
    public class Return
    {

        public Return()
        {
            CreateDate = DateTime.Now;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid? id { get; private set; }
        public Guid userID { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Computed), CreatedDate]
        public DateTime CreateDate { get; private set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime AlterDate { get; set; }

        public virtual ICollection<ReturnItem> ReturnItems { get; set; }

    }
}
