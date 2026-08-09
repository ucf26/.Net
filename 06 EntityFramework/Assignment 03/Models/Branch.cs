using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Assignment_03.Models
{
    internal class Branch
    {
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Key]
        public int BranchCode { get; set; }
        
        [Required, MaxLength(50)]
        public string Address { get; set; }
        [Required]
        public int PhoneNumber { get; set; }

        // ========================================================
        // Relations
        // ========================================================

        public Manager Manager { get; set; }
        public ICollection<Account> Accounts { get; set; }
    }
}
