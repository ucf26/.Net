using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 1: Enums
            #region Q1
            //Console.WriteLine("Q1 : Day of the Week\n");
            //Console.WriteLine("Create an enum called DayOfWeek with values: Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday.");

            //Console.WriteLine("Then write a program that:");
            //Console.WriteLine("\tAsks the user to enter a day number (0–6).");
            //Console.WriteLine("\tConverts it to the enum and prints the day name.");
            //Console.WriteLine("\tUses a switch statement to print whether it's a Workday or a Weekend.");

            //bool isValidDay = false;
            //DayOfWeek d1 = DayOfWeek.Sunday;
            //while (!isValidDay)
            //{
            //    Console.Write("Enter a Day number (1-7):");
            //    string input = Console.ReadLine();
            //    isValidDay = int.TryParse(input, out int d) && Enum.IsDefined(typeof(DayOfWeek), d);
            //    if (isValidDay)
            //    {
            //        d1 = (DayOfWeek)d;

            //    }
            //}
            //Console.WriteLine($"Day: {d1}");
            //switch (d1)
            //{
            //    case DayOfWeek.Friday:
            //    case DayOfWeek.Saturday:
            //        Console.WriteLine("it's a Weekend.");
            //        break;
            //    default:
            //        Console.WriteLine("it's a Workday.");
            //        break;
            //}
            //Console.WriteLine(new string('-', 70));
            #endregion

            // Part 2: Arrays
            #region Q1
            //Console.WriteLine("Q1: Array Statistics\n");
            //Console.WriteLine("Write a program that:");
            //Console.WriteLine("\tAsks the user for the size of an integer array.");
            //Console.WriteLine("\tReads the elements from the user.");
            //Console.WriteLine("\tPrints: the sum, the average, the maximum value, the minimum value, and the array in reverse order.");
            //Console.Write("Enter the array Size: ");

            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //for(int i = 0; i < size; i++)
            //{
            //    Console.Write($"Enter element [{i}]: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int Sum = 0, mx = 0, mn = int.MaxValue;
            //for(int i = 0; i < size; i++)
            //{
            //    if (mn > arr[i]) mn = arr[i];
            //    if (mx < arr[i]) mx = arr[i];
            //    Sum += arr[i];
            //}
            //Console.WriteLine($"Sum     = {Sum}");
            //Console.WriteLine($"Average = {(double)Sum / size}");
            //Console.WriteLine($"Max     = {mx}");
            //Console.WriteLine($"Min     = {mn}");

            //Console.WriteLine(new string('-', 70));
            #endregion

            #region Q2
            //Console.WriteLine("Q2 : Student Grades Matrix\n");

            //Console.WriteLine("You have 3 students, each with 4 subject grades. Store them in a 2D array.");
            //Console.WriteLine("Write a program that:");
            //Console.WriteLine("\tReads grades from the user into a [3, 4] array.");
            //Console.WriteLine("\tPrints each student's average grade.");
            //Console.WriteLine("\tPrints the overall class average");

            //int[,] grades = new int[3, 4];
            //for(int i=0;i<grades.GetLength(0);i++)
            //{
            //    for(int j=0;j<grades.GetLength(1);j++)
            //    {
            //        Console.Write($"Enteer grade {j + 1} for student {i + 1}: ");
            //        bool isValidGrade = false;
            //        int x = 0;
            //        while (!isValidGrade)
            //        {
            //            isValidGrade = int.TryParse(Console.ReadLine(), out x);
            //        }
            //        grades[i, j] = x;
            //    }
            //}
            //int totSaum = 0;
            //for(int i=0;i<grades.GetLength(0);i++)
            //{
            //    int S = 0;
            //    for(int j=0; j<grades.GetLength(1);j++)
            //    {
            //        S += grades[i, j];
            //    }
            //    totSaum += S;
            //    Console.Write($"The Avrage grade of student {i + 1} is: {(double)S/grades.GetLength(1)}\n");
            //}
            //Console.WriteLine($"The overall class average is: {totSaum / (grades.GetLength(0) * grades.GetLength(1))}");
                
            Console.WriteLine(new string('-', 70));
            #endregion

            // Part 3: Functions (Methods)
            #region Q1
            //Console.WriteLine("Q1: Basic Calculator Functions\n");
            //Console.WriteLine("Write four static methods: Add, Subtract, Multiply, Divide.");
            //Console.WriteLine("Each takes two double parameters and returns a double result.");
            //Console.WriteLine("In Main, ask the user for two numbers and an operation (+, -, *, /), then call the appropriate method and display the result.");
            //Console.WriteLine("Handle division by zero gracefully.");
            //while (true)
            //{
            //    Console.Write("Enter the first number: ");
            //    double a = double.Parse(Console.ReadLine());

            //    Console.Write("Enter the second number: ");
            //    double b = double.Parse(Console.ReadLine());

            //    Console.Write("Enter the operation: ");
            //    char op = char.Parse(Console.ReadLine());

            //    switch (op)
            //    {
            //        case '+':
            //            Console.WriteLine($"{a} + {b} = {Add(a, b)}");
            //            break;
            //        case '-':
            //            Console.WriteLine($"{a} - {b} = {Subtract(a, b)}");
            //            break;
            //        case '/':
            //        Console.WriteLine($"{a} / {b} = {Divide(a, b)}");
            //            break;
            //        case '*':
            //            Console.WriteLine($"{a} * {b} = {Multiply(a, b)}");
            //            break;
            //        default:
            //            Console.WriteLine("Unknown Operation.");
            //            break;
            //    }

            //}

            //Console.WriteLine(new string('-', 70));
            #endregion

            #region Q2
            //Console.WriteLine("Q2 : Circle Calculator with out\n");
            //Console.WriteLine("Write a method CalculateCircle that takes a double radius as input and returns both the area and circumference using out parameters.");
            //Console.WriteLine("Call the method from Main, then print both results.");

            //Console.Write("nter the Radius of th circle: ");
            //double r = double.Parse(Console.ReadLine());
            //CalculateCircle(r, out double area, out double per);
            //Console.WriteLine($"The area of the circle = {area}");
            //Console.WriteLine($"The circumference of the circle = {per}");

            //Console.WriteLine(new string('-', 70));
            #endregion

            #region Create a new Console Application project
            Console.WriteLine("Create a new Console Application project");

            Console.WriteLine("Build a mini Student Grade Manager that combines all three topics.");
            Console.WriteLine("Requirements:");
            Console.WriteLine("\tEnum: Create a Grade enum with values: A, B, C, D, F.");
            Console.WriteLine("\tArray: Use an int[] array to store scores for 5 students.");
            Console.WriteLine("\tFunctions: Write the following methods:");
            Console.WriteLine("\t\ta) Method To GetGrade returns the grade enum based on score(A >= 90, B >= 80, C >= 70, D >= 60, F< 60).");
            Console.WriteLine("\t\tb) Method To CalculateAverage returns the average of all scores.");
            Console.WriteLine("\t\tc) Method To GetMinMax finds the min and max scores using out.");
            Console.WriteLine("The program should:");

            Console.WriteLine("\tRead 5 student scores from the user.");
            Console.WriteLine("\tPrint each student's score and corresponding letter grade.");
            Console.WriteLine("\tPrint the class average, minimum, and maximum scores.");

            Console.WriteLine(new string('-', 70));
            #endregion
        }

        public static double Add(double a, double b)
        {
            return (a + b);
        }

        public static double Subtract(double a, double b)
        {
            return (a - b);
        }

        public static double Multiply(double a, double b)
        {
            return (a * b);
        }

        public static double Divide(double a, double b)
        {
            double ans = -1;
            try
            {
                ans = a / b;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                ans = 0;
            }
            return ans;
        } 


        public static void CalculateCircle(double radius, out double area, out double circumference)
        {
            area = 3.14 * radius * radius;
            circumference = 2 * 3.14 * radius;
        }
    }
}
