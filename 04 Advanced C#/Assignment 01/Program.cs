namespace Assignment_01
{
    internal class Program
    {

        class Animal
        {
            public static int Counter;

            public static void Increment()
            {
                Counter++;
            }
        }

        class Cat : Animal
        {

        }

        class Dog : Animal
        {

        }

        static void Main(string[] args)
        {
            
            #region Q1
            Console.WriteLine("Q1: What is a generic class? ");

            Console.WriteLine("It is a class defined with a type parameter (a placeholder for a type that is specified later when you actually use the class).");
            Console.WriteLine("Why use generics?");
            Console.WriteLine("\t1- Type safety at runtime: without generics you would store objects as object and cast them manually at runtime, errors can appear at runtime.");
            Console.WriteLine("\t2- No Boxing/Unboxing --> better Performance: storing value types in an object type causes boxing (wrapping an int value a heap-allocated object).");
            Console.WriteLine("\t3- Code reuse without reduplication.");
            Console.WriteLine("\t4- Constraints for smarter classes.");

            Console.WriteLine(new string('-', 50));

            #endregion

            #region Q2
            Console.WriteLine("Q2: Write a generic class Container<T> with Add and Get methods.");
            Console.WriteLine();
            Console.WriteLine("internal class Container<T>");
            Console.WriteLine("{");
            Console.WriteLine("    private T[] _arr;");
            Console.WriteLine("");
            Console.WriteLine("    public T this[int index]");
            Console.WriteLine("    {");
            Console.WriteLine("        get");
            Console.WriteLine("        {");
            Console.WriteLine("            return _arr[index];");
            Console.WriteLine("        }");
            Console.WriteLine("");
            Console.WriteLine("        set");
            Console.WriteLine("        {");
            Console.WriteLine("            _arr[index] = value;");
            Console.WriteLine("        }");
            Console.WriteLine("");
            Console.WriteLine("    }");
            Console.WriteLine("}");

        Console.WriteLine(new string('-', 50));

            #endregion

            #region Q3
            Console.WriteLine("Q3:What are multiple type parameters? Write Pair<TKey, TValue>.");
            Console.WriteLine("A generic class can have multiple type parameters, each acting as a placeholder.");

            Console.WriteLine("internal class Pair<TKey, TValue>");
            Console.WriteLine("{");
            Console.WriteLine("    public TKey Key { get; set; }");
            Console.WriteLine("    public TValue Value { get; set; }");
            Console.WriteLine();
            Console.WriteLine("    public Pair(TKey key, TValue value)");
            Console.WriteLine("    {");
            Console.WriteLine("        Key = key;");
            Console.WriteLine("        Value = value;");
            Console.WriteLine("    }");
            Console.WriteLine("}");

            Console.WriteLine(new string('-', 50));

            #endregion

            #region Q4
            Console.WriteLine("Q4: What is a generic method? Write Swap<T> method.");
            Console.WriteLine("It is a method defined with a type parameter which acts as a placeholder and they are solved at compilation.");

            Console.WriteLine("public static void swap<T>(ref T x, ref T y)");
            Console.WriteLine("{");
            Console.WriteLine("    T tmp = x;");
            Console.WriteLine("    x = y;");
            Console.WriteLine("    y = tmp;");
            Console.WriteLine("}");

        Console.WriteLine(new string('-', 50));

            #endregion


            #region Q5
            Console.WriteLine("Q5: Write a generic method FindMax<T> that finds maximum value");

            Console.WriteLine("public static T FindMax<T>(T[] arr) where T : IComparable<T>");
            Console.WriteLine("{");
            Console.WriteLine("    T res = arr[0];");
            Console.WriteLine("    foreach (T t in arr)");
            Console.WriteLine("    {");
            Console.WriteLine("        if (t.CompareTo(res) > 0)");
            Console.WriteLine("        {");
            Console.WriteLine("            res = t;");
            Console.WriteLine("        }");
            Console.WriteLine("    }");
            Console.WriteLine("    return res;");
            Console.WriteLine("}");

        Console.WriteLine(new string('-', 50));

            #endregion


            #region Q6
            Console.WriteLine("Q6: What is a generic interface? Write IRepository<T>. ");
            Console.WriteLine("It is an interface that defines its contract using a type parameter, and any class that implements it can specify the concrete type.");
            Console.WriteLine("Generic Interfaces are used when dealing whith databases to sign a contract with all entities to implement some methods and each entity will specify the concrete type.");

            Console.WriteLine("internal interface IRepository<T>");
            Console.WriteLine("{");
            Console.WriteLine("    T? GetByID(int id);");
            Console.WriteLine("    void Add(T entity);");
            Console.WriteLine("    void Update(T entity);");
            Console.WriteLine("    void Delete(T entity);");
            Console.WriteLine("}");

            Console.WriteLine(new string('-', 50));

            #endregion

            #region Q7
            Console.WriteLine("Q7: What is the 'struct' constraint? Write an example.");
            Console.WriteLine("it implies that T must be a value type only.");
            Console.WriteLine(new string('-', 50));

            #endregion

            #region Q8
            Console.WriteLine("Q8: What is the 'class' constraint? Write an example.");
            Console.WriteLine("it implies that T must be a reference type only.");
            Console.WriteLine(new string('-', 50));
            #endregion


            #region Q9
            Console.WriteLine("Q9: What is the 'new()' constraint? Write an example.");
            Console.WriteLine("it implies that T must have a parameterless constructor.");
            Console.WriteLine(new string('-', 50));
            #endregion


            #region Q10
            Console.WriteLine("Q10:  What is the interface constraint? Write an example.");
            Console.WriteLine("it implies that T mustc implement the interface.");
            Console.WriteLine(new string('-', 50));
            #endregion



            #region Q11
            Console.WriteLine("Q11: What is the base class constraint? Write an example.");
            Console.WriteLine("it implies that T must implement the interface.");
            Console.WriteLine(new string('-', 50));
            #endregion



            #region Q12
            Console.WriteLine("Q12: How do you apply multiple constraints? Write an example. ");
            Console.WriteLine("you can apply multiple constraints to a type parameter using the keyword where, they are comma-separated after the column.");
            
            Console.WriteLine(new string('-', 50));

            #endregion



            #region Q13
            Console.WriteLine("Q13: What does the 'default' keyword do in generics?");
            Console.WriteLine("Inside a generic method or a class you don't know at compile time whether T is value-type or reference-type, So default keyword solves this by assigning a valid value for each type.");

            Console.WriteLine(new string('-', 50));

            #endregion



            #region Q14
            Console.WriteLine("Q14: Write a SafeList<T> that returns default when the index is invalid.");

            Console.WriteLine("internal class SafeList<T>");
            Console.WriteLine("{");
            Console.WriteLine("    private List<T> _list = new List<T>();");
            Console.WriteLine("");
            Console.WriteLine("    public int Count => _list.Count;");
            Console.WriteLine("");
            Console.WriteLine("    public void Add(T item)");
            Console.WriteLine("    {");
            Console.WriteLine("        _list.Add(item);");
            Console.WriteLine("    }");
            Console.WriteLine("");
            Console.WriteLine("    public T Get(int index)");
            Console.WriteLine("    {");
            Console.WriteLine("        if (index < 0 || index >= _list.Count)");
            Console.WriteLine("        {");
            Console.WriteLine("            return default(T);");
            Console.WriteLine("        }");
            Console.WriteLine("");
            Console.WriteLine("        else");
            Console.WriteLine("        {");
            Console.WriteLine("            return _list[index];");
            Console.WriteLine("        }");
            Console.WriteLine("    }");
            Console.WriteLine("");
            Console.WriteLine("}");

            Console.WriteLine(new string('-', 50));

            #endregion




            
            #region Q18
            Console.WriteLine("Q18: How do static members work in generic types?");
            Console.WriteLine("Each closed generic type has its own copy of static fields.");
            Console.WriteLine(new string('-', 50));
            #endregion



            
            
            #region Q19
            Console.WriteLine("Q19: How can you inherit from a generic class?");
            Console.WriteLine("Generic classes can inherit from generic and non-generic classes, and there are multiple patterns to do so.");

            Console.WriteLine(new string('-', 50));
            #endregion



            
            
            #region Q20
            Console.WriteLine("Q20: Complete Exercise - Create a generic Cache<TKey, TValue>with Add, Get, Remove, Contains, and expiration support. ");

            Console.WriteLine(new string('-', 50));
            #endregion



        }
    }
}
