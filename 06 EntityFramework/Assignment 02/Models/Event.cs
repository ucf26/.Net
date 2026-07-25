using Assignment_02.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Reflection.Metadata;
using System.Text;

namespace Assignment_02.Entities
{
    internal class Event
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int MaxAttendees { get; set; }


        // Also the CreationDate and LAst modified Date are handled internally 
        // and is  Never visible, so they are treated as shadow properties
        // in EventConfiguration 


        // ============================================================
        //  Relations
        // ============================================================

        /* One to One: Organizer - Event */
        public int OrganizerId { get; set; }
        public Organizer Organizer { get; set; }



        /* Self Referencing: One to Many */
        public int? ParentEventId { get; set; }
        public Event? ParentEvent { get; set; }
        public ICollection<Event> ChildEvents { get; set; } = new List<Event>();

        /* One to Many: Event Registerations */
        public ICollection<Registration> Registrations { get; set; } = new List<Registration>();
    }
}
