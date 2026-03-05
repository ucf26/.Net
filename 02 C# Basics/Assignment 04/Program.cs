using System.Diagnostics;
using System.Security.Claims;
using System.Text;

namespace Assignment_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Console.WriteLine("Question 1: \n");
            Console.WriteLine("A junior developer wrote this code to build a comma-separated list of 5,000 product IDs:n");
            Console.WriteLine("string productList = \"\";");
            Console.WriteLine("for (int i = 1; i <= 5000; i++)");
            Console.WriteLine("{");
            Console.WriteLine("    productList += \"PROD-\" + i + \",\";");
            Console.WriteLine("}");
            Console.WriteLine("");

            string productList = "";
            for (int i = 1; i <= 5000; i++)
            {
                productList += "PROD-" + i + ",";
            }

            // A
            Console.WriteLine("(a) Explain why this code is inefficient. Reference what happens in memory.");
            Console.WriteLine("since the string is immutable that you cannot change its value after creation, "+
                "every time you update the value of productList it creates a new refernce and allocates a new heap memory "+
                "which is inefficient and also it is an overload for Garbage Collector.");
            
            // B
            Console.WriteLine("(b) Rewrite this code using StringBuilder to be more efficient.");
            StringBuilder sb1 = new StringBuilder();
            //for (int i = 1; i <= 5000; i++)
            //{
            //    sb1.Append("PROD-" + i + ",");
            //}
            //string productlist1 = sb1.ToString();

            // C
            Console.WriteLine("(c) Add timing code (using Stopwatch) to both versions and report the time difference.");
            
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            string productLisTest = "";
            for (int i = 1; i <= 5000; i++)
            {
                productLisTest += "PROD-" + i + ",";
            }
            sw1.Stop();

            Stopwatch sw2 =  new Stopwatch();
            sw2.Start();
            StringBuilder sbTest = new StringBuilder();
            for (int i = 1; i <= 5000; i++)
            {
                sbTest.Append("PROD-" + i + ",");
            }
            string productListSB = sbTest.ToString();
            sw2.Stop();
           
            Console.WriteLine($"The time difference between String And String Builder: {sw1.Elapsed - sw2.Elapsed}");


            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion


            #region Q2
            Console.WriteLine("Question 2: \n");

            Console.WriteLine("Question 02: Ticket Pricing System ");
            Console.WriteLine("Write a program for a cinema ticket pricing system with these rules:");

            // A & B && C
            Console.WriteLine("(a) Implement using if-else if-else statements");
            Console.WriteLine("(b) The program should ask for: age, day of week (1-7, where 6=Fri, 7=Sat), and whether they have a student ID (yes/no)");


            int age2 = 25, price2 = 0, weekDay = 1;
            bool studenWithValidID = false;


            Console.Write("Enter your age: ");
            age2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the day of the week (1 for Monday, 7 for Sunday): ");
            weekDay = int.Parse(Console.ReadLine());
            Console.Write("Are you a student with a valid ID? (yes/no): ");
            string studentInput = Console.ReadLine();
            studenWithValidID = studentInput.ToLower() == "yes" ? true : false;

            int costDueToAge = 0, weekEndSurcharge = 0, studentDiscount = 0;


            if (age2 < 5)
            {
                costDueToAge = 0;
            }
            else if (age2 <= 12)
            {
                costDueToAge = 30;
            }
            else if (age2 <= 59)
            {
                costDueToAge = 50;
            }
            else
            {
                costDueToAge = 25;
            }
            if (weekDay == 6 || weekDay == 7)
            {
                weekEndSurcharge += 10;
            }
            if (studenWithValidID)
            {
                studentDiscount = (int)(0.2 * price2);
            }

            Console.WriteLine($"Final Price = {costDueToAge + weekEndSurcharge - studentDiscount}.");
            Console.WriteLine($"since your age is {age2} ==> +{costDueToAge}");
            Console.WriteLine($"the weekend surcharge ==> +{weekEndSurcharge}");
            Console.WriteLine($"Student Dicount ==> -{studentDiscount}");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion


            #region Q3
            Console.WriteLine("Question 3: \n");
            Console.WriteLine("Question 03: Convert the following if-else chain to:");

            //if (fileExtension == ".pdf")
            //    fileType = "PDF Document";
            //else if (fileExtension == ".docx" || fileExtension == ".doc")
            //    fileType = "Word Document";
            //else if (fileExtension == ".xlsx" || fileExtension == ".xls")
            //    fileType = "Excel Spreadsheet";
            //else if (fileExtension == ".jpg" || fileExtension == ".png" || fileExtension == ".gif")
            //    fileType = "Image File";
            //else
            //    fileType = "Unknown File Type";


            // A
            Console.WriteLine("(a) A traditional switch statement");

            string fileExtension = ".pdf";
            string fileType;

            switch (fileExtension)
            {
                case ".pdf":
                    fileType = "PDF Document";
                    break;

                case ".docx":
                case ".doc":
                    fileType = "Word Document";
                    break;

                case ".xlsx":
                case ".xlx":
                    fileType = "Excel Spread Sheet";
                    break;

                case ".png":
                case ".jpg":
                case ".gif":
                    fileType = "Image File";
                    break;

                default:
                    fileType = "unknown extension";
                    break;
            }
            Console.WriteLine(fileType);


            // B 
            Console.WriteLine("(b) A switch expression ");
            fileExtension = ".png";

            fileType = fileExtension switch
            {
                ".pdf" => "PDF Document",
                ".docx" or ".doc" => "Word Document",
                ".xlsx" or ".xlx" => "Excel Spread Sheet",
                ".png" or ".jpg" or ".gif" => "Image File",
                _ => "Unknown Extension"
            };
            Console.WriteLine(fileType);

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion


            #region Q4
            Console.WriteLine("Question 04 : Ternary Operator \n");
            Console.WriteLine("Rewrite the following using only ternary operators (no if statements):");

            int temperature = 35;
            string weatherAdvice;

            //if (temperature < 0)
            //    weatherAdvice = "Freezing! Stay indoors.";
            //else if (temperature < 15)
            //    weatherAdvice = "Cold. Wear a jacket.";
            //else if (temperature < 25)
            //    weatherAdvice = "Pleasant weather.";
            //else if (temperature < 35)
            //    weatherAdvice = "Warm. Stay hydrated.";
            //else
            //    weatherAdvice = "Hot! Avoid sun exposure.";

            weatherAdvice = temperature < 0 ? "Freezing! Stay indoors." :
                            temperature < 15 ? "Cold. Wear a jacket." :
                            temperature < 25 ? "Pleasant weather." :
                            temperature < 35 ? "Warm. Stay hydrated." : "Hot! Avoid sun exposure.";
            Console.WriteLine(weatherAdvice);
            Console.WriteLine("no, the ternary operator version is not more readable, we should use it when it is only one condition.");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion


            #region Q5
            Console.WriteLine("Question 05 : Input Validation with Loops \n");
            Console.WriteLine("Create a password validation program with these requirements:");
            Console.WriteLine("Password Rules:");
            Console.WriteLine("\tMinimum 8 characters");
            Console.WriteLine("\tAt least one uppercase letter");
            Console.WriteLine("\tAt least one digit");
            Console.WriteLine("\tNo spaces allowed");

            bool validPass = false;
            string pass = "";
            int attempts = 0;

            Console.Write("Enter a Password: ");
            while (!validPass)
            {

                if (attempts >= 5)
                {
                    Console.WriteLine("Account Locked!");
                    break;
                }

                pass = Console.ReadLine();

                bool validLen = pass.Length >= 8 ? true : false;

                bool foundUpperCase = false;
                foreach (var ch in pass)
                {
                    if (ch >= 'A' && ch <= 'Z')
                    {
                        foundUpperCase = true;
                        break;
                    }
                }

                bool foundDigit = false;
                foreach (var ch in pass)
                {
                    if (ch >= '0' && ch <= '9')
                    {
                        foundDigit = true;
                        break;
                    }
                }

                bool foundSpace = false;
                foreach (var ch in pass)
                {
                    if (ch == ' ')
                    {
                        foundSpace = true;
                        break;
                    }

                }

                if (!validLen)
                {
                    Console.WriteLine("The password must be at least 8 characters.");
                }

                if (!foundDigit)
                {
                    Console.WriteLine("The password must have at least one digit.");
                }
                if (!foundUpperCase)
                {
                    Console.WriteLine("The password must have at least on upper case letter.");
                }

                if (foundSpace)
                {
                    Console.WriteLine("The password must not have any spaces.");
                }

                validPass = validLen && foundDigit && foundUpperCase && !foundSpace;
                if (!validPass)
                {
                    Console.Write("Enter a new password: ");
                }

                attempts++;
            }


            if (validPass)
            {
                Console.WriteLine("Success!!");
                //Console.WriteLine(pass);
            }

            Console.WriteLine("");
            
            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion


            #region Q6
            Console.WriteLine("Question 06 : Array Processing  \n");
            Console.WriteLine("Given an array of exam scores: int[] scores = { 85, 42, 91, 67, 55, 78, 39, 88, 72, 95, 60, 48 };");
            Console.WriteLine("Using loops (your choice of for, foreach, while), write code to:");
            int[] scores = { 85, 42, 91, 67, 55, 78, 39, 88, 72, 95, 60, 48 };

            // A
            Console.WriteLine("(a) Find and display all failing scores (below 50) ");

            Console.WriteLine("Failed Scores:");
            for (int i = 0; i < scores.Length;i++)
            {
                if (scores[i] < 50)
                {
                    Console.WriteLine($"Scores[{i}] = {scores[i]}");
                }
            }

            // B
            Console.WriteLine("(b) Find the first score above 90 and stop searching immediately");
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] >90)
                {
                    Console.WriteLine($"the first score above 90 is {scores[i]}");
                    break;
                }
            }

            // C 
            Console.WriteLine("(c) Calculate the class average, excluding any scores below 40 ");
            double sum = 0;
            int numOfAttendees = 0;
            for(int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > 40)
                {
                    numOfAttendees++;
                    sum += scores[i];
                }
            }
            Console.WriteLine($"The average score of attendees = {sum / numOfAttendees}");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

        }
    }
}
