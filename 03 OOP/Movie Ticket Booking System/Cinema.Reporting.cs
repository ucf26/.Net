using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Ticket_Booking_System
{
    internal partial class Cinema
    {
        public bool AddTicket(Ticket ticket)
        {
            for (int i = 0; i < _tickets.Length; i++)
            {
                if (_tickets[i] == null)
                {
                    _tickets[i] = ticket; // ticket added successfully
                    return true;
                }
            }
            return false; // cinema is full
        }
    }
}
