using Movie_Ticket_Booking_System.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Movie_Ticket_Booking_System
{
    internal class Ticket:IPrintable, IBookable, IClonable
    {
        private string? _movieName;
        private decimal _price;
        private static int _counter;
        private int _ticketId;
        private BookingStatus _status;


        public BookingStatus Status
        {
            get { return _status; }
        }

        public bool Book()
        {
            if(_status == BookingStatus.Available)
            {
                _status = BookingStatus.Booked;
                _counter++;
                return true;
            }
            return false;
        }

        public bool Cancel()
        {
            if(_status == BookingStatus.Booked)
            {
                _status = BookingStatus.Cancelled;
                return true;
            }
            return false;
        }

        public object Clone()
        {
            Ticket Cloned = (Ticket)this.MemberwiseClone();

            _counter++;
            Cloned._ticketId = _counter;


            return Cloned;
        }
        public string? MovieName
        {
            get { return _movieName; }
            set { _movieName = value; }
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
            _status = BookingStatus.Available;
        }

        public void Print()
        {
            Console.WriteLine($"Ticket ID : {_ticketId}, Movie:{_movieName}, Price: {_price:C}, Price after tax: {PriceAfterTax:C}");
        }

        public override string ToString() 
        {
            return $"Ticket ID: {_ticketId}, Movie: {_movieName}, Price: {_price:C}, Price after tax: {PriceAfterTax:C}";
        }

        public void SetPrice(decimal price)
        {
            if (price > 0)
            {
                _price = price;
            }
        }

        public void SetPrice(decimal _basePrice, decimal multiplier)
        {
            if (_basePrice > 0 && multiplier > 0)
            {
                _price = _basePrice * multiplier;
            }
        }


        static int GetTotalTickets()
        {
            return _counter;
        }

    }

}
