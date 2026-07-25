using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Assignment_02.Entities
{
    [Table("Organizers")]
    internal class Organizer
    {
        [Key]
        public int OrganizerId { get; set; }
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
        [Required]
        [MaxLength(25)]

        public string CompanyName { get; set; }
        [Required]
        public bool IsVerified { get; set; }


        // ==================================================
        // Relations
        // ==================================================

        /* One to Many: Organizer - Event */
        //[InverseProperty(nameof)]
        public ICollection<Event> Events { get; set; }


        /* One to One: Organizer - Profile*/
        [InverseProperty(nameof(Profile.Organizer))]
        public Profile Profile { get; set; }
    }
}
