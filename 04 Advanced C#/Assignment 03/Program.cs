using Microsoft.VisualBasic;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Numerics;
using System.Reflection.Metadata;
using System.Timers;
using System.Xml;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            // Exercise 1: Student Grade Manager
            // Create a program that manages student grades using One Of Collections
            Console.WriteLine("===============================================");
            Console.WriteLine("=                                             =");
            Console.WriteLine("=       Exercise 1: Student Grade Manager     =");
            Console.WriteLine("=                                             =");
            Console.WriteLine("===============================================");

            // 1.Create a Collection with these grades: 85, 92, 78, 95, 88, 70, 100, 65

            List<int> grades = [85, 92, 78, 95, 88, 70, 100, 65];

            // 2.Print the collection, Count, first and last grade
            Console.WriteLine( "Grades are: ");
            grades.Print();
            Console.WriteLine($"Grades Count = {grades.Count}");
            Console.WriteLine($"Last Grade = {grades[grades.Count-1]}");
            Console.WriteLine(new string('-', 50));

            // 3.Sort the grades ascending, then print
            grades.Sort();
            Console.WriteLine("Sorted Grades are:");
            grades.Print();
            Console.WriteLine(new string('-', 50));

            // 4.Get the first grade above 90
            int FirstOver90 = -1;
            foreach(int grade in grades)
            {
                if(grade > 90)
                {
                    FirstOver90 = grade;
                    break;
                }
            }
            Console.WriteLine($"First Grade above 90 is: {FirstOver90}");
            Console.WriteLine(new string('-', 50));

            // 5.Get all grades below 75(failing grades)
            List<int> FallingGrades = new List<int>();
            foreach (int grade in grades)
            {
                if(grade < 75)
                {
                    FallingGrades.Add(grade);
                }
            }
            Console.WriteLine("Failling Grades are:");
            FallingGrades.Print();
            Console.WriteLine(new string('-', 50));

            // 6.Remove all failing grades(below 75)
            foreach (var grade in FallingGrades)
            {
                grades.RemoveAll(x =>  x == grade);
            }
            Console.WriteLine("Grades after removing Falling Grades:");
            grades.Print();
            Console.WriteLine(new string('-', 50));

            // 7.Check if any grade equals 100
            Console.WriteLine($"If any grades equals 100: {grades.Contains(100)}");
            Console.WriteLine(new string('-', 50));

            // 8.Create a List<string> where each grade becomes "Grade: X"
            List<string> StringGrades = new() { };
            foreach(var item in grades)
            {
                StringGrades.Add($"Grade: {item}");
            }
            StringGrades.Print();
            Console.WriteLine(new string('-', 50));

            #endregion

            #region Q2

            // Exercise 2: Leaderboard
            Console.WriteLine("===============================================");
            Console.WriteLine("=                                             =");
            Console.WriteLine("=            Exercise 2: Leaderboard          =");
            Console.WriteLine("=                                             =");
            Console.WriteLine("===============================================");

            // Create a leaderboard that automatically sorts players by score.
            SortedList<int, string> leaderboard = new() { };

            // 1.Add: 500 = "Ahmed", 200 = "Sara", 800 = "Ali", 350 = "Mona"
            leaderboard.Add(500, "Ahmed");
            leaderboard.Add(200 , "Sara");
            leaderboard.Add(800 , "Ali");
            leaderboard.Add(350 , "Mona");

            // 2.Print all entries(they should be sorted by score automatically)
            
            leaderboard.Print();
            Console.WriteLine(new string('-', 50));

            // 3.Access the first key and first value
            Console.WriteLine($"The first Key: {leaderboard.Keys[0]}");
            Console.WriteLine($"The first Value: {leaderboard.Values[0]}");
            Console.WriteLine(new string('-', 50));

            // 4.Check if score 500 exists

            foreach(var item in leaderboard)
            {
                if(item.Key == 500)
                {
                    Console.WriteLine(item);
                    break;
                }
            }
            Console.WriteLine(new string('-', 50));

            // 5.Safely get the player with score 999
            string player = "";
            if(leaderboard.TryGetValue(999, out player))
            {
                Console.WriteLine($"The Player with score 999 is: {player}");
            }
            else
            {
                Console.WriteLine($"No Player found.");
            }
            Console.WriteLine(new string('-', 50));

            // 6.Remove the player with score 200 and print the updated list
            leaderboard.Remove(200);
            Console.WriteLine("Leaderboard after removing");
            leaderboard.Print();
            Console.WriteLine(new string('-', 50));
            #endregion

            #region Q3

            // Exercise 3: Phone Book
            Console.WriteLine("===============================================");
            Console.WriteLine("=                                             =");
            Console.WriteLine("=            Exercise 3: Phone Book            ");
            Console.WriteLine("=                                             =");
            Console.WriteLine("===============================================");

            // Build a phone book application.
            // 1.Create a Collection  with 4 contacts(name → phone number)
            Dictionary<string, int> Contacts = new() { };
            Contacts["Yasser"] = 01116698454;
            Contacts["Mona"] = 01098775454;
            Contacts["Eslam"] = 0115545454;
            Contacts["Sayed"] = 0123545454;

            // 2.Add a new contact using [] syntax (add or update)
            Contacts["Ahmed"] = 0115545488;

            // 3.Try adding a duplicate using .Add() — catch the exception and print the error
            try
            {
                Contacts.Add("Yasser", 011545645);
            }
            catch(Exception ex) 
            { 
                Console.WriteLine(ex); 
            }
            Console.WriteLine(new string('-', 50));

            // 4.Try adding a duplicate using .TryAdd() — print whether it succeeded
            if(Contacts.TryAdd("Ali", 0151516554))
            {
                Console.WriteLine("Adding Succeeded");
            }
            else
            {
                Console.WriteLine("Adding failed");
            }
            Console.WriteLine(new string('-', 50));

            // 5.Search for a contact that doesn’t exist
            if (Contacts.ContainsKey("mahmoud"))
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("Doesn't exist");
            }
            Console.WriteLine(new string('-', 50));

            // 6.Get a contact with a fallback of "Not Found"
            if (Contacts.TryGetValue("Ahmed", out int number))
            {
                Console.WriteLine($"Ahmed: {number}");
            }
            else
            {
                Console.WriteLine($"Ahmed: not found");
            }
            Console.WriteLine(new string('-', 50));

            // 7.Print all Keys on one line, then all Values on another line
            foreach (var item in Contacts.Keys)
            {
                Console.Write(item);
                Console.Write("\t\t");
            }
            Console.WriteLine();
            foreach (var item in Contacts.Values)
            {
                Console.Write(item);
                Console.Write("\t");
            }
            Console.WriteLine(new string('-', 50));



            #endregion

            #region Q4
            //Exercise 4: Unique Email Validator
            Console.WriteLine("================================================");
            Console.WriteLine("=                                              =");
            Console.WriteLine("=       Exercise 4: Unique Email Validator     =");
            Console.WriteLine("=                                              =");
            Console.WriteLine("================================================");
            //Use Collection to manage unique email addresses.
            //1.Create a HashSet<string> with a case -insensitive comparer: new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);


            //2.Add these emails: "ahmed@test.com", "AHMED@test.com", "sara@test.com", "Sara@Test.Com"
            emails.Add("ahmed@test.com");
            emails.Add("AHMED@test.com");
            emails.Add("sara@test.com");
            emails.Add("Sara@Test.Com");

            //3.Print Count — how many are actually stored? Explain why.
            Console.WriteLine($"Emails Count: {emails.Count}");
            Console.WriteLine(new string('-', 50));

            //4.Create two sets: Set A = { 1, 2, 3, 4, 5 } and Set B = { 4,5,6,7,8}
            HashSet<int> SetA = [1, 2, 3, 4, 5];
            HashSet<int> SetB = [4, 5, 6, 7, 8];

            //5.Print the result of: UnionWith, IntersectWith, ExceptWith
            HashSet<int> union = new(SetA);
            union.UnionWith(SetB);

            Console.Write("Union Result: ");
            foreach (var item in union)
            {
                Console.Write(item);
                Console.Write("\t");
            }
            Console.WriteLine();


            HashSet<int> intersect = new(SetA);
            intersect.IntersectWith(SetB);

            Console.Write("Intersect Result: ");
            foreach (var item in intersect)
            {
                Console.Write(item);
                Console.Write("\t");
            }
            Console.WriteLine();

            HashSet<int> except = new(SetA);
            except.ExceptWith(SetB);

            Console.Write("Except Result: ");
            foreach (var item in except)
            {
                Console.Write(item);
                Console.Write("\t");
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 50));


            //6.Use IsSubsetOf to check if { 1,2} is a subset of Set A
            HashSet<int> small = new([1, 2]);
            if(small.IsSubsetOf(SetA))
            {
                Console.WriteLine("[1, 2] is subset of SetA");
            }
            else
            {
                Console.WriteLine("[1, 2] is not subset of SetA");
            }
            Console.WriteLine(new string('-', 50));


            #endregion

            #region Q5
            //Exercise 5: Print Queue Simulator
            Console.WriteLine("================================================");
            Console.WriteLine("=                                              =");
            Console.WriteLine("=       Exercise 5: Print Queue Simulator      =");
            Console.WriteLine("=                                              =");
            Console.WriteLine("================================================");
            //Simulate a printer queue
            //Create a Queue<string> and enqueue 5 documents: "Report.pdf", "Invoice.pdf", "Letter.docx", "Resume.pdf", "Photo.jpg"
            Queue<string> printer = new();
            printer.Enqueue("Report.pdf");
            printer.Enqueue("Invoice.pdf");
            printer.Enqueue("Letter.docx");
            printer.Enqueue("Resume.pdf");
            printer.Enqueue("Photo.jpg");


            //1.Print the queue contents and Count
            Console.WriteLine($"The printer Count is: {printer.Count}");
            foreach(var item in printer)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 50));

            //2.Use Peek to see which document will print next(without removing)
            Console.WriteLine($"The next document is: {printer.Peek()}");
            Console.WriteLine(new string('-', 50));

            //3.Process the queue: Dequeue each document and print "Printing: [name]"
            while (printer.Count > 0)
            {
                Console.WriteLine($"Printing: [{printer.Peek()}]");
                printer.Dequeue();
            }
            Console.WriteLine(new string('-', 50));

            //4.Try TryDequeue on the now-empty queue — what happens?
            bool val = printer.TryDequeue(out string res);
            if (val)
            {
                Console.WriteLine($"Succeeded and the result is {res}");
            }
            else 
            {
                Console.WriteLine("the Queue is empty");
            }
            Console.WriteLine(new string('-', 50));

            #endregion

            #region Q6
            //Exercise 6: Browser History(Undo)
            Console.WriteLine("================================================");
            Console.WriteLine("=                                              =");
            Console.WriteLine("=       Exercise 6: Browser History(Undo)      =");
            Console.WriteLine("=                                              =");
            Console.WriteLine("================================================");
            //Simulate browser back / forward
            //Create a Stack<string> for browser history
            Stack<string> BrowserHistory = new();

            //1.Push 5 URLs: "google.com", "github.com", "stackoverflow.com", "youtube.com", "claude.ai"
            BrowserHistory.Push("google.com");
            BrowserHistory.Push("github.com");
            BrowserHistory.Push("stackoverflow.com");
            BrowserHistory.Push("youtube.com");
            BrowserHistory.Push("claude.ai");


            //2.Use Peek to see the current page(top of stack)
            Console.WriteLine($"The current page is: {BrowserHistory.Peek()}");

            //3.Press "back" 3 times using Pop — print each page you leave

            BrowserHistory.Pop();
            BrowserHistory.Pop();
            BrowserHistory.Pop();
            //4.Print the current page after going back
            Console.WriteLine($"The current page is: {BrowserHistory.Peek()}");


            //5.Try TryPop on an empty stack — what happens?
            
            #endregion
        }
    }
}
