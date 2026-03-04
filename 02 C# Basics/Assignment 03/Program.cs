namespace Solution03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Q1
            Console.WriteLine("Q1");
            Console.WriteLine("What will this print and explain what happens?");
            Console.WriteLine("double d = 9.99;");
            Console.WriteLine("int x = (int)d;");
            Console.WriteLine("Console.WriteLine(x);");
            Console.WriteLine();

            double d = 9.99;
            int x1 = (int)d;
            Console.WriteLine(x1);
            Console.WriteLine("This will print 9. When casting a double to an int, " +
                "the decimal part is truncated and only the whole number is kept. So 9.99 becomes 9.");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Q2
            Console.WriteLine("Q2");
            Console.WriteLine("This code doesn't compile. Fix it with the smallest change?");
            Console.WriteLine("int n = 5;");
            Console.WriteLine("double d2 = n / 2;");
            Console.WriteLine("Console.WriteLine(d2);");
            Console.WriteLine();

            // Fix: cast n to double before division so we get floating-point division
            int n = 5;
            double d2 = (double)n / 2;
            Console.WriteLine(d2);
            Console.WriteLine("Fix: cast n to double -> (double)n / 2. " +
                "Without the cast, integer division gives 2 (not 2.5). " +
                "Casting n to double forces floating-point division, resulting in 2.5.");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Q3
            Console.WriteLine("Q3");
            Console.WriteLine("You read a number from user input. Write the correct line to get age as int.");
            Console.WriteLine();

            Console.Write("Enter Your Age: ");
            string input = Console.ReadLine();
            bool parsed = int.TryParse(input, out int age);
            if (parsed)
                Console.WriteLine($"Your Age is {age}.");
            else
                Console.WriteLine("Not a valid number.");

            Console.WriteLine("Use int.TryParse(input, out int age) to safely parse the string. " +
                "It returns true if successful and stores the result in age; " +
                "false if the input is not a valid integer, avoiding exceptions.");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Q4
            Console.WriteLine("Q4");
            Console.WriteLine("What happens here and why?");
            Console.WriteLine("string s = \"12a\";");
            Console.WriteLine("int x = int.Parse(s);");
            Console.WriteLine("Console.WriteLine(x);");
            Console.WriteLine();

            Console.WriteLine("This will throw a FormatException because \"12a\" is not a valid integer string. " +
                "int.Parse requires the string to contain only numeric characters.");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Q5
            Console.WriteLine("Q5");
            Console.WriteLine("Complete the code from the previous question so it prints Invalid " +
                "if conversion fails, otherwise prints the number.");
            Console.WriteLine();

            string s5 = "12a";
            if (int.TryParse(s5, out int x5))
                Console.WriteLine(x5);
            else
                Console.WriteLine("Invalid");

            Console.WriteLine("Use int.TryParse which returns false instead of throwing an exception " +
                "when the string cannot be parsed. If it returns false we print \"Invalid\".");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Q6
            Console.WriteLine("Q6");
            Console.WriteLine("What will this print and explain why?");
            Console.WriteLine("object o = 10;");
            Console.WriteLine("int a = (int)o;");
            Console.WriteLine("Console.WriteLine(a + 1);");
            Console.WriteLine();

            object o6 = 10;
            int a6 = (int)o6;
            Console.WriteLine(a6 + 1);
            Console.WriteLine("This prints 11. The value 10 is boxed into the object o. " +
                "When we unbox it with (int)o we get 10 back. Adding 1 gives 11.");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Q7
            Console.WriteLine("Q7");
            Console.WriteLine("What will this print and explain why, and if there is a problem handle it?");
            Console.WriteLine("object o = 10;");
            Console.WriteLine("long x = (long)o;");
            Console.WriteLine("Console.WriteLine(x);");
            Console.WriteLine();

            object o7 = 10;
            // Fix: unbox to the original boxed type (int) first, then cast to long
            long x7 = (long)(int)o7;
            Console.WriteLine(x7);
            Console.WriteLine("This throws an InvalidCastException if written as (long)o directly. " +
                "The object was boxed as an int, so you must unbox to int first, then cast to long: " +
                "(long)(int)o. This prints 10.");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Q8
            Console.WriteLine("Q8");
            Console.WriteLine("Fix this to avoid exceptions and print -1 if conversion isn't possible?");
            Console.WriteLine("object o = 10;");
            Console.WriteLine("long x = o;");
            Console.WriteLine("Console.WriteLine(x);");
            Console.WriteLine();

            object o8 = 10;
            long x8;
            try
            {
                x8 = (long)(int)o8;
            }
            catch (InvalidCastException)
            {
                x8 = -1;
            }
            Console.WriteLine(x8);
            Console.WriteLine("The object boxes an int, so it must be unboxed to int before casting to long. " +
                "A try-catch around InvalidCastException catches any unboxing mismatch and returns -1 instead.");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Q9
            Console.WriteLine("Q9");
            Console.WriteLine("What will this print and explain why?");
            Console.WriteLine("string? name = null;");
            Console.WriteLine("Console.WriteLine(name?.Length);");
            Console.WriteLine();

            string? name9 = null;
            Console.WriteLine(name9?.Length);
            Console.WriteLine("This prints an empty line (nothing). The null-conditional operator ?. " +
                "short-circuits when name is null and returns null instead of throwing a NullReferenceException. " +
                "Console.WriteLine(null) prints an empty line.");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Q10
            Console.WriteLine("Q10");
            Console.WriteLine("What will this print and explain the process?");
            Console.WriteLine("string? name2 = null;");
            Console.WriteLine("int length = name2?.Length ?? 0;");
            Console.WriteLine("Console.WriteLine(length);");
            Console.WriteLine();

            string? name10 = null;
            int length10 = name10?.Length ?? 0;
            Console.WriteLine(length10);
            Console.WriteLine("This prints 0. The null-conditional operator returns null because name2 is null, " +
                "then the null-coalescing operator ?? provides the fallback value 0.");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Q11
            Console.WriteLine("Q11");
            Console.WriteLine("What's wrong with this \"safe\" code and how can we solve it?");
            Console.WriteLine("string? s = null;");
            Console.WriteLine("int x = int.Parse(s ?? \"0\");");
            Console.WriteLine("Console.WriteLine(x);");
            Console.WriteLine();

            // The code actually works fine with s ?? "0" since "0" is valid for int.Parse.
            // However a safer approach is int.TryParse to handle any non-numeric strings.
            string? s11 = null;
            int.TryParse(s11 ?? "0", out int x11);
            Console.WriteLine(x11);
            Console.WriteLine("The code works when s is null (parses \"0\"), but int.Parse will still throw " +
                "a FormatException if the string is non-null but non-numeric. " +
                "Using int.TryParse is safer as it handles both cases without exceptions.");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Q12
            Console.WriteLine("Q12");
            Console.WriteLine("What happens here and if there is a problem, handle it?");
            Console.WriteLine("string? s = null;");
            Console.WriteLine("Console.WriteLine(s!.Length);");
            Console.WriteLine();

            // Fix: use null-conditional operator instead of null-forgiving operator
            string? s12 = null;
            Console.WriteLine(s12?.Length);
            Console.WriteLine("This throws a NullReferenceException at runtime. The null-forgiving operator (!) " +
                "only silences the compiler warning; it does not prevent the exception. " +
                "Fix: use s?.Length which safely returns null when s is null.");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Q13
            Console.WriteLine("Q13");
            Console.WriteLine("What will this print?");
            Console.WriteLine("string? s = null;");
            Console.WriteLine("int x = Convert.ToInt32(s);");
            Console.WriteLine("Console.WriteLine(x);");
            Console.WriteLine();

            string? s13 = null;
            int x13 = Convert.ToInt32(s13);
            Console.WriteLine(x13);
            Console.WriteLine("This prints 0. Convert.ToInt32 treats a null string as 0 instead of throwing an exception, " +
                "unlike int.Parse which would throw a FormatException.");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Q14
            Console.WriteLine("Q14");
            Console.WriteLine("Compare results and explain each result:");
            Console.WriteLine("string? s = null;");
            Console.WriteLine("A: int a = int.Parse(s);");
            Console.WriteLine("B: int b = Convert.ToInt32(s); Console.WriteLine(b);");
            Console.WriteLine();

            // A throws, so we demonstrate with try-catch
            string? s14 = null;
            try
            {
                int a14 = int.Parse(s14);
            }
            catch (Exception e)
            {
                Console.WriteLine($"A throws: {e.GetType().Name}");
            }

            int b14 = Convert.ToInt32(s14);
            Console.WriteLine($"B prints: {b14}");

            Console.WriteLine("A throws an ArgumentNullException because int.Parse does not accept null. " +
                "B prints 0 because Convert.ToInt32 has special handling for null and returns 0.");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Q15
            Console.WriteLine("Q15");
            Console.WriteLine("Complete the line to print \"Guest\" when user is null, " +
                "otherwise print the user name in uppercase:");
            Console.WriteLine();

            string? user = null;
            Console.WriteLine(user?.ToUpper() ?? "Guest");
            Console.WriteLine("user?.ToUpper() returns null when user is null (null-conditional operator), " +
                "then ?? \"Guest\" provides the fallback. If user had a value it would be printed in uppercase.");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion
        }
    }
}