using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Assignment_03.Models
{
    internal class Transaction
    {
        [Key]
        public int TransactionNumber { get; set; }
        [Required]
        public DateTime TransactionDate { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set; }
        [MaxLength(100)]
        public string? Description { get; set; }
        [Required]
        [MaxLength(50)]
        public string TransactionType { get; set; }

        // ========================================================
        // Relations
        // ========================================================

        public int AccountNumber { get; set; }
        public Account Account { get; set; }
    }
}
