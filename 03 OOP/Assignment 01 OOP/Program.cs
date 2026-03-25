namespace Assignment_01_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1

            #region Q1

            Console.WriteLine("Q1 : Explain with code example how class and struct behave differently");
            Console.WriteLine("struct is a value type, while class is a reference type.");
            Console.WriteLine("This means that structs are stored on the stack, and classes are stored on the heap.");
            Console.WriteLine("When you copy a struct, you get a new copy of the data, but when you copy a class, you get a reference to the same object.");
            
            
            MyStruct01 struct1 = new MyStruct01 { x = 10 }; // This allocates the required memory for the struct on the stack and initializes its fields to their default values.
            MyClass01 class1 = new MyClass01 { x = 20 }; // This allocates memory for the class on the heap and initializes its fields to their default values. The variable class1 holds a reference to the memory location where the object is stored. 

            // Copy Behavior
            MyStruct01 struct2 = struct1; // This creates a new independent copy of struct1 and assigns it to struct2.
            struct2.x = 13; // struct1 not affected
            Console.WriteLine($"struct1.x = {struct1.x}, struct2.x = {struct2.x}");

            MyClass01 class2 = class1; // This creates a new reference to the same object on the heap. Both class1 and class2 point to the same memory location.
            class2.x = 25; // class1 is affected
            Console.WriteLine($"class1.x = {class1.x}, class2.x = {class2.x}");

            // Inheritance
            Console.WriteLine("Struct does not support inheritance, while class does.");


            Console.WriteLine(new string('-', 70));
            #endregion


            #region Q2

            Console.WriteLine("Q2 : Explain the difference between public and private access modifiers with an example. ");
            Console.WriteLine("public members are accessible from anywhere, while private members are accessible only within the same class.");
            Console.WriteLine("Example:");
            Console.WriteLine("class MyClass {");
            Console.WriteLine("    public int publicField; // Accessible from anywhere");
            Console.WriteLine("    private int privateField; // Accessible only within MyClass");
            Console.WriteLine("}");
            Console.WriteLine(new string('-', 70));

            #endregion


            #region Q3

            Console.WriteLine("Q3 : Describe the steps to create and use a class library in Visual    Studio.");
            Console.WriteLine("1. Open Visual Studio and create a new project.");
            Console.WriteLine("2. Select 'Class Library' as the project type.");
            Console.WriteLine("3. Write your classes and methods in the library.");
            Console.WriteLine("4. Build the project to generate the DLL file.");
            Console.WriteLine("5. Reference the DLL in another project to use the library.");
            Console.WriteLine(new string('-', 70));

            #endregion


            #region Q4

            Console.WriteLine("Q4 : What is a class library? Why do we use class libraries?");
            Console.WriteLine("A class library is a collection of pre-written classes and methods that can be used in multiple projects.");
            Console.WriteLine("We use class libraries to promote code reuse, modularity, and maintainability.");
            Console.WriteLine(new string('-', 70));

            #endregion


            #endregion
        }
    }

    public struct MyStruct01
    {
        public int x;
    }
    public class MyClass01
    {
        public int x;
    }
    struct AnimalStruct
    {
        public string Name;
    }
    class AnimalClass
    {
        public string Name;
    }

    class Dog : AnimalClass
    {
        public string Breed;
    }


}
