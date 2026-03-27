using System.Security.Cryptography.X509Certificates;

namespace Assignment_02_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Console.WriteLine("Q1 : Consider the following class:");
            Console.WriteLine("public class BankAccount\r\n            {\r\n                public string Owner;\r\n                public double Balance;\r\n\r\n                public void Withdraw(double amount)\r\n                {\r\n                    Balance -= amount;\r\n                }\r\n            }");


            // A
            Console.WriteLine("a) Identify at least two problems with this design from an encapsulation perspective.");
            Console.WriteLine("1- the fields Owner and Balance are made public which can be accessed and modified everywhere.");
            Console.WriteLine("2- the Withdraw method does not check if the amount to withdraw is greater than the balance, which can lead to negative balance.");

            // B
            Console.WriteLine("b) Describe how you would fix this class to follow proper encapsulation principles. " +
                "You do not need to write the full code.");

            Console.WriteLine("1- Make the fields Private.");
            Console.WriteLine("2- add public properties to controll the access to them");
            Console.WriteLine("3- Modify the withdraw function to validate if the balance in the account is enough to withdraw.");

            Console.WriteLine("public class BankAccount\r\n            {\r\n                private string _owner;\r\n                private double _balance;\r\n\r\n           \r\n                public string Owner\r\n                {\r\n                    get { return Owner; }\r\n                    set { Owner = value; }\r\n                }\r\n                \r\n                public double Balance\r\n                {\r\n                    get { return _balance; }\r\n                }\r\n                \r\n                public void Withdraw(double amount)\r\n                {\r\n                    if(amount <= _balance && amount > 0)\r\n                    {\r\n                        _balance -= amount;\r\n                    }\r\n                }\r\n\r\n            }");


            // C
            Console.WriteLine("c) Explain why exposing fields directly (as public) is considered a bad practice in OOP.");
            Console.WriteLine("By exposing them as public they will accessed everywhere ,and can be modified with non-valid data without validation");


            Console.WriteLine(new string('-', 70));
            #endregion


            #region Q2

            Console.WriteLine("Q02 : What is the difference between a field and a property in C#?" +
                " Can a property contain logic? Give an example of a read-only property that returns a calculated value.");

            Console.WriteLine("Fields: ");
            Console.WriteLine("- Variables that stores data");
            Console.WriteLine("- usually made private");
            Console.WriteLine("- cannot contain logic");

            Console.WriteLine("Properties: ");
            Console.WriteLine("- Provide a way to read, write or compute the values of private fields");
            Console.WriteLine("- Can contain logic");
            Console.WriteLine("- Can be read-only or write-only");

            Console.WriteLine("Example of a read-only property that returns a calculated value:");
            Console.WriteLine("public class Circle");
            Console.WriteLine("{");
            Console.WriteLine("    private double _radius;");
            Console.WriteLine("    public double Radius");
            Console.WriteLine("    {");
            Console.WriteLine("        get { return _radius; }");
            Console.WriteLine("        set { _radius = value; }");
            Console.WriteLine("    }");
            Console.WriteLine("    public double Area");
            Console.WriteLine("    {");
            Console.WriteLine("        get { return Math.PI * _radius * _radius; }");
            Console.WriteLine("    }");
            Console.WriteLine("}");
            Console.WriteLine(new string('-', 70));

            #endregion


            #region Q3
            Console.WriteLine("Q3 : Look at the following code and answer the questions below:");


            Console.WriteLine("public class StudentRegister");
            Console.WriteLine("{");
            Console.WriteLine("    private string[] names = new string[5];");
            Console.WriteLine("    public string this[int index]");
            Console.WriteLine("    {");
            Console.WriteLine("        get { return names[index]; }");
            Console.WriteLine("        set { names[index] = value; }");
            Console.WriteLine("    }");
            Console.WriteLine("}");

            // A 
            Console.WriteLine("a) What is `this[int index]` called? Explain its purpose.");
            Console.WriteLine("It is called an indexer. It allows instances of the class to be indexed like arrays." +
                " In this case, it provides a way to access and modify the names array using an index.");

            // B
            Console.WriteLine("b) What happens if someone writes `register[10] = \"Ali\";` ? How would you make the indexer safer?");
            Console.WriteLine("It will throw an IndexOutOfRangeException because the index 10 is out of bounds for the names array which has a length of 5." +
                " To make the indexer safer, we can add a check to ensure that the index is within the valid range before accessing the array.");


            // C 
            Console.WriteLine("c) Can a class have more than one indexer? If yes, give an example of when that would be useful.");
            Console.WriteLine("Yes, a class can have more than one indexer, but they must differ in their parameter types or number of parameters." +
                " This can be useful when you want to provide different ways to access the data within the class. " +
                "For example, you could have one indexer that takes an integer index and another that takes a string key.");

            Console.WriteLine(new string('-', 70));

            #endregion

            #region Q4


            Console.WriteLine("Q4 : Consider the following code and answer the questions below:");

            Console.WriteLine("public class Order");
            Console.WriteLine("{");
            Console.WriteLine("    public static int TotalOrders = 0;");
            Console.WriteLine("    public string Item;");
            Console.WriteLine("    public Order(string item)");
            Console.WriteLine("    {");
            Console.WriteLine("        Item = item;");
            Console.WriteLine("        TotalOrders++;");
            Console.WriteLine("    }");
            Console.WriteLine("}");

            // A
            Console.WriteLine("a) What does the `static` keyword mean on `TotalOrders`? How is it different from the `Item` field?");
            Console.WriteLine("The `static` keyword means that the field belongs to the class itself rather than any particular instance of the class." +
                " This means that all instances of the class share the same `TotalOrders` field, whereas each instance has its own `Item` field.");


            // B
            Console.WriteLine("b) Can a static method inside `Order` access the `Item` field directly? Why or why not?");
            Console.WriteLine("No, a static method cannot access the `Item` field directly because `Item` is an instance field, and static methods do not have access to instance members." +
                " To access the `Item` field, a static method would need to have a reference to an instance of the `Order` class.");
            #endregion
        }


    } 
}
