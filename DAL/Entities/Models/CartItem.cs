using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entities.Models
{
    public class CartItem
    {
        public int Id { get; set; }

        [ForeignKey("Card")]
        public int CtId { get; set; }
        public virtual Cart Cart { get; set; }

        [ForeignKey("Product")]
        public int PId{ get; set; }
        public virtual Product Product { get; set; }

        [Range(1, 1000)]
        public int Quantity { get; set; }

        [Range(0, 999999)]
        public decimal PriceAtTime { get; set; }
    }
}
