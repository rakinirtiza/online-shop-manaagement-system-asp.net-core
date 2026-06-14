using DAL.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BLL.DTOs
{
    public class PaymentDTO
    {
        public int Id { get; set; }
        public int OId { get; set; }
        public string PaymentMethod { get; set; } = null!;
        public decimal Amount { get; set; }
        public string PaymentStatus { get; set; } = "Pending";
        public string? TransactionId { get; set; }
        public DateTime? PaidAt { get; set; }
    }
}
