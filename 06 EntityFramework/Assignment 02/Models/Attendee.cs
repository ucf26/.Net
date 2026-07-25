using Assignment_02.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Assignment_02.Models
{
    [Table("Attendees")]
    internal class Attendee
    {
        [Key]
        public int AttendeeId { get; set; }
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string EmailAddress { get; set; }
        public string? HomeAddress { get; set; }

        // =================================================
        // Relations
        // =================================================

        /* One to One: Attendee Badge */

        [InverseProperty(nameof(Badge.Owner))]
        public Badge Badge { get; set; } = default!;

        ///* One to Many: Attendee Events */
        public ICollection<Registration> Registrations { get; set; } = new List<Registration>();
    }
}
