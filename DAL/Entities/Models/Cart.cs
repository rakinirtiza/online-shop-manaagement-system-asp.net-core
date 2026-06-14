using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entities.Models
{
    public class Cart
    {
        public int Id { get; set; }

        [Required, MaxLength(20)]
        public string Status { get; set; } = "Active";

        [ForeignKey("User")]
        public int UId { get; set; }
        public virtual User User { get; set; }

    }
}
