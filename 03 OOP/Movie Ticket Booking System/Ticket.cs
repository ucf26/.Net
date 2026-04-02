using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Movie_Ticket_Booking_System
{
    internal class Ticket
    {
        private string? _movieName;
        private decimal _price;
        private static int _counter;
        private int _ticketId;


        public string? MovieName
        {
            get { return MovieName; }
            set { MovieName = value; }
        }

        public decimal Price
        {
            get 
            { 
                return _price; 
            }
            set 
            { 
                if(value > 0) _price = value; 
            }
        }

        public int TicketId
        {
            get { return _ticketId; }
        }

        public decimal PriceAfterTax => _price * (decimal)1.14;

        public Ticket(string movieName, decimal price)
        {
            _counter++;
            _ticketId = _counter;
            _movieName = movieName;
            _price = price;
        }

        public override string ToString() 
        {
            return $"Ticket ID: {_ticketId}, Movie: {_movieName}, Price: {_price:C}, Price after tax: {PriceAfterTax:C}";
        }
        
        static int GetTotalTickets()
        {
            return _counter;
        }


    }

}
