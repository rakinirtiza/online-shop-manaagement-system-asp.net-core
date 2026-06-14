using DAL.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BLL.DTOs
{
    public class CartItemDTO
    {
        public int Id { get; set; }
        public int CtId { get; set; }
        public int PId { get; set; }
        public int Quantity { get; set; }
        public decimal PriceAtTime { get; set; }
    }
}
