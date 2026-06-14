using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entities.Models
{
    public class Payment
    {
        public int Id { get; set; }

        [ForeignKey("Order")]
        public int OId { get; set; }
        public virtual Order Order { get; set; }

        [Required, MaxLength(30)]
        public string PaymentMethod { get; set; } = null!;

        [Range(0, 999999)]
        public decimal Amount { get; set; }

        [Required, MaxLength(20)]
        public string PaymentStatus { get; set; } = "Pending";

        [MaxLength(100)]
        public string? TransactionId { get; set; }

        public DateTime? PaidAt { get; set; }
    }
}
