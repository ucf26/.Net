using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Assignment_03.Models
{
    internal class Manager
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FullName { get; set; }
        [Required]
        [MaxLength(60)]
        public string EmailAddress { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime HireDate { get; set; }

        // ========================================================
        // Relations
        // ========================================================


        public int BranchCode { get; set; }
        public Branch Branch { get; set; }

    }
}
