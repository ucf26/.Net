using Assignment_02.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_02.Models
{
    internal class Registration
    {

        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; } = default!;

        public int EventId { get; set; }
        public Event Event { get; set; } = default!;

        public string? Note { get; set; }

        public DateTime RegistrationDate { get; set; } = DateTime.Now;
    }
}
