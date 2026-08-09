using Assignment_03.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Assignment_03.Models
{
    internal class Account
    {
        [Key]
        public int AccountNumber { get; set; }
        [Required]
        public AccountType AccountType { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime OpeningDate { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal CurrentBalance { get; set; }

        // ========================================================
        // Relations
        // ========================================================

        public Branch Branch { get; set; }
        public int BranchCode { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
        public ICollection<CustomerAccount> CustomerAccounts { get; set; }
    }
}
