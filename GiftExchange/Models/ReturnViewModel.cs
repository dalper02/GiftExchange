using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GiftExchange.Models
{
    public class ReturnViewModel
    {
        public Guid? id { get; set; }
        public Guid? userID { get; set; }

        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public string CreateDate { get; set; }
        public string AlterDate { get; set; }

        public virtual IEnumerable<ProductViewModel> ReturnItems { get; set; }
    }
}