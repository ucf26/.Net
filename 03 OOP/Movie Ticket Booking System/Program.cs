namespace Movie_Ticket_Booking_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1- movie name
            Console.Write("Enter Movie Name: ");
            bool validMovieName = false;
            string movieName = "";
            while (!validMovieName)
            {
                movieName = Console.ReadLine();
                if (!string.IsNullOrEmpty(movieName))
                {
                    validMovieName = true;
                }
                else
                {
                    Console.WriteLine("Not a Valid Movie Name!");
                    Console.Write("Enter Movie Name: ");
                }
            }

            // 2- Ticket Type 
            Console.Write("Enter Ticket Type (0 = Standard , 1 = VIP , 2 = IMAX ): ");
            bool validTicktType = false;
            int type = -1;
            while (!validTicktType)
            {
                validTicktType = int.TryParse(Console.ReadLine(), out type);
                validTicktType = ((type >= 0) && (type <= 2));
                if (!validTicktType)
                {
                    Console.WriteLine("Not a Valid Ticket Type!");
                    Console.Write("Enter Ticket Type: ");
                }
            }

            // 3- seat row
            Console.Write("Enter Seat Row (A, B, C...): ");
            bool validSeatRow = false;
            char seatRow = '-';
            while (!validSeatRow)
            {
                validSeatRow = char.TryParse(Console.ReadLine(), out seatRow);
                validSeatRow = ((seatRow >= 'A') && (seatRow <= 'Z'));
                if (!validSeatRow)
                {
                    Console.WriteLine("Not a Valid Row!");
                    Console.Write("Enter Ticket Row: ");
                }
            }

            //4- seat number
            Console.Write("Enter Seat Number: ");
            bool validSeatNumber = false;
            int seatNumber = -1;
            while (!validSeatNumber)
            {
                validSeatNumber = int.TryParse(Console.ReadLine(), out seatNumber);
                if (!validSeatNumber)
                {
                    Console.WriteLine("Not a Valid Seat Numbr!");
                    Console.Write("Enter Seat Numbr: ");
                }
            }

            //5- price
            Console.Write("Enter Price: ");
            bool validPrice = false;
            double price = -1;
            while (!validPrice)
            {
                validPrice = double.TryParse(Console.ReadLine(), out price);
                if (!validPrice)
                {
                    Console.WriteLine("Not a Valid Price!");
                    Console.Write("Enter Price: ");
                }
            }

            //6-discount amount
            Console.Write("Enter Discount Amount: ");
            bool validDiscountAmount = false;
            double discountAmount = -1;
            while (!validDiscountAmount)
            {
                validDiscountAmount = double.TryParse(Console.ReadLine(), out discountAmount);
                if (!validDiscountAmount)
                {
                    Console.WriteLine("Not a Valid Dicount Amount!");
                    Console.Write("Enter Discount Amount: ");
                }
            }

            Type ticketType = type switch
            {
                0 => Type.Standard,
                1 => Type.VIP,
                2 => Type.IMAX
            };
            Ticket T1 = new Ticket(movieName, ticketType, seatRow, seatNumber, price,
                discountAmount);

            T1.PrintTicket();

            Console.WriteLine($"\t===== After Discount =====");
            Console.WriteLine($"\tDiscount Before: {discountAmount}");
            T1.ApplyDiscount(ref discountAmount);
            Console.WriteLine($"\tDiscount After:  {discountAmount}");
            Console.WriteLine($"\tMovie : {movieName}");
            Console.WriteLine($"\tType  : {ticketType}");
        }
    }
}
