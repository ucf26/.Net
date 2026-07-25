using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Assignment_02.Entities
{
    [Table("Profiles")]
    internal class Profile
    {
        [Key]
        public int ProfileId { get; set; }
        [Required]
        [MaxLength(150)]
        public string Biography { get; set; }
        [Required]
        [MaxLength(150)]
        public string Link { get; set; }
        
        public string? Logo { get; set; }

        // ==================================================
        // Relations
        // ==================================================

        /* One to One: Organizer - Profile */
        [ForeignKey(nameof(OrganizerId))]
        public int OrganizerId { get; set; }
        [InverseProperty(nameof(Organizer.Profile))]
        public Organizer Organizer { get; set; }

    }
}
