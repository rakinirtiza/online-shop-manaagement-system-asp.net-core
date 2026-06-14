using DAL.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BLL.DTOs
{
    public class CartDTO
    {
        public int Id { get; set; }

        public string Status { get; set; } = "Active";

        public int UId { get; set; }
    }
}
