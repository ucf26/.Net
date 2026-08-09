using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Assignment_03.Models
{
    internal class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string FullName { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public int NationalId { get; set; }
        [Required, MaxLength(50)]
        public string EmailAddress { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [Required, MaxLength(50)]
        public string HomeAddress { get; set; }

        // ========================================================
        // Relations
        // ========================================================


        public ICollection<CustomerAccount> CustomerAccounts { get; set; }

    }
}
