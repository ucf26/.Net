using Movie_Ticket_Booking_System.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Ticket_Booking_System
{
    internal class Cinema
    {
        private Ticket?[] _tickets;
        private string? _cinemaName;

        public Ticket? this[int index]
        {
            get
            {
                if (index >= 0 && index < _tickets.Length)
                    return _tickets[index];
                else return null;
            }
            set
            {
                if (index >= 0 && index < _tickets.Length)
                {
                    _tickets[index] = value; 
                }
            }
        }

        public Ticket? this[string movieName]
        {
            get
            {
                for(int i = 0; i < _tickets.Length; i++)
                {
                    if (_tickets[i]?.MovieName == movieName)
                    {
                        return _tickets[i];
                    }
                }
                return null;
            }
        }
        
        
        
        public bool AddTicket(Ticket ticket)
        {
            for(int i=0; i < _tickets.Length; i++)
            {
                if (_tickets[i] == null)
                {
                    _tickets[i] = ticket; // ticket added successfully
                    return true;
                }
            }
            return false; // cinema is full
        }


        public void PrintAllTickets()
        {
            for (int i = 0; i < _tickets.Length; i++)
            {
                if (_tickets[i] != null)
                {
                    IPrintable tt = _tickets[i];
                    BookingHelper.Print(tt);
                }
            }
        }




        public Cinema()
        {
            _tickets = new Ticket[20];
        }

        public void OpenCinema()
        {
            Projector.StartProjector();
        }

        public void CloseCinema()
        {
            Projector.CloseProjector();
        }

        public static void ProcessTicket(Ticket t)
        {
            t.Print();
        }

        //static public string PrintTicket(int index)
        //{

        //    return $"Ticket #{index + 1}: {_tickets[index]}";
        //}

    }
}
