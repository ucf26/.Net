using Assignment_02.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Assignment_02.Models
{
    [Table("Badges")]
    internal class Badge
    {
        [Key]
        public int BadgeId { get; set; }
        [Required]
        public DateTime DateIssued { get; set; } = default!;
        [Required]
        public BadgeTier Tier { get; set; } = default!;

        // ===============================================
        // Relations
        // ===============================================

        /* One to One: Badge - Attendee */
        [ForeignKey(nameof(OwnerId))]
        public int OwnerId { get; set; } = default!;
        [InverseProperty(nameof(Attendee.Badge))]
        public Attendee Owner { get; set; } = default!;


    }
    
}
