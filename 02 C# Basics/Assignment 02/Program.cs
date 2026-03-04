using System;

namespace CSharpAssignment
{
    class Program
    {
        // Class-level field for scope demonstrations
        static int classField = 100;
        static int callCount = 0; // used in Q6 lifetime demo

        static void Main(string[] args)
        {
            #region Q1 - Regions
            Console.WriteLine("Q1");
            Console.WriteLine("What is the purpose of #region and #endregion directives in C#?");
            Console.WriteLine("How do they help in code organization?");
            Console.WriteLine();

            Console.WriteLine("#region and #endregion are preprocessor directives that let you collapse");
            Console.WriteLine("and expand sections of code in an IDE like Visual Studio.");
            Console.WriteLine("They have NO effect on compilation or runtime behaviour.");
            Console.WriteLine("They are purely a readability and navigation tool.");
            Console.WriteLine();
            Console.WriteLine("Benefits:");
            Console.WriteLine("  1. Long files become easier to navigate by folding unrelated sections.");
            Console.WriteLine("  2. Logical groupings (e.g. 'Initialization', 'Event Handlers') are visible at a glance.");
            Console.WriteLine("  3. Regions can be nested inside each other.");
            Console.WriteLine();

            // Nested region example (visible in source, collapsed in IDE)
            #region Outer Region
            Console.WriteLine("Outer region is open.");
            #region Inner Region
            Console.WriteLine("Inner region is also open (nested regions are allowed).");
            #endregion // Inner Region
            #endregion // Outer Region

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Q2 - Variable Declaration: Explicit vs Implicit
            Console.WriteLine("Q2");
            Console.WriteLine("What is the difference between explicit and implicit variable");
            Console.WriteLine("declaration in C#? Provide examples of both.");
            Console.WriteLine();

            // EXPLICIT DECLARATION - you state the type yourself
            int explicitInt = 42;
            string explicitString = "Hello";
            double explicitDouble = 3.14;

            Console.WriteLine("Explicit declaration - the programmer writes the type:");
            Console.WriteLine($"  int    explicitInt    = {explicitInt}");
            Console.WriteLine($"  string explicitString = \"{explicitString}\"");
            Console.WriteLine($"  double explicitDouble = {explicitDouble}");
            Console.WriteLine();

            // IMPLICIT DECLARATION - 'var' lets the compiler infer the type
            var implicitInt = 42;        // compiler infers int
            var implicitString = "Hello";   // compiler infers string
            var implicitDouble = 3.14;      // compiler infers double

            Console.WriteLine("Implicit declaration - 'var' lets the compiler infer the type:");
            Console.WriteLine($"  var implicitInt    = {implicitInt}    (type: {implicitInt.GetType().Name})");
            Console.WriteLine($"  var implicitString = \"{implicitString}\" (type: {implicitString.GetType().Name})");
            Console.WriteLine($"  var implicitDouble = {implicitDouble} (type: {implicitDouble.GetType().Name})");
            Console.WriteLine();
            Console.WriteLine("Key point: 'var' is still STRONGLY typed. The type is fixed at compile time.");
            Console.WriteLine("Use explicit when the type adds clarity; use var when the type is obvious from context.");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Q3 - Constants
            Console.WriteLine("Q3");
            Console.WriteLine("Write the syntax for declaring a constant in C#.");
            Console.WriteLine("Why would you use a constant instead of a regular variable?");
            Console.WriteLine();

            // Constant examples
            const double PI = 3.14159265358979;
            const int MAX_USERS = 100;
            const string APP_NAME = "MyApp";

            Console.WriteLine("Syntax:  const <type> NAME = <value>;");
            Console.WriteLine();
            Console.WriteLine($"  const double PI        = {PI}");
            Console.WriteLine($"  const int    MAX_USERS = {MAX_USERS}");
            Console.WriteLine($"  const string APP_NAME  = \"{APP_NAME}\"");
            Console.WriteLine();
            Console.WriteLine("Why use const over a variable?");
            Console.WriteLine("  1. Safety    - value cannot be changed accidentally after declaration.");
            Console.WriteLine("  2. Clarity   - signals intent; readers know this value never changes.");
            Console.WriteLine("  3. Performance - compiler replaces usages with the literal value (inlined).");
            Console.WriteLine("  4. Convention - named constants (PI, MAX_USERS) are more readable than magic numbers.");
            Console.WriteLine();
            Console.WriteLine("Restriction: the value must be known at COMPILE TIME (literal or const expression).");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Q4 - Class-level vs Method-level Scope
            //Console.WriteLine("Q4");
            //Console.WriteLine("Explain the difference between class-level scope and method-level scope.");
            //Console.WriteLine();

            //// Method-level variable - only alive inside Main
            //int methodVar = 50;

            //Console.WriteLine("Class-level scope:");
            //Console.WriteLine("  Declared outside any method, as a field of the class.");
            //Console.WriteLine($"  'classField' is accessible from ANY method in this class. Value = {classField}");
            //Console.WriteLine();
            //Console.WriteLine("Method-level scope:");
            //Console.WriteLine("  Declared inside a method. Exists only while that method is executing.");
            //Console.WriteLine($"  'methodVar' only exists inside Main(). Value = {methodVar}");
            //Console.WriteLine();
            //Console.WriteLine("Key differences:");
            //Console.WriteLine("  Lifetime  - classField lives as long as the class; methodVar dies when Main() returns.");
            //Console.WriteLine("  Visibility - classField is visible to all methods; methodVar is invisible outside Main.");

            //Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Q5 - Block-level Scope
            Console.WriteLine("Q5");
            Console.WriteLine("What is block-level scope? Give an example showing a variable that");
            Console.WriteLine("is only accessible within a specific block.");
            Console.WriteLine();

            Console.WriteLine("A block is any code enclosed in { }.");
            Console.WriteLine("Variables declared inside a block are ONLY visible within that block.");
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                int blockVar = i * 10; // blockVar only exists inside this for-loop block
                Console.WriteLine($"  Inside loop block: i = {i}, blockVar = {blockVar}");
            }
            // Console.WriteLine(blockVar); // ERROR - blockVar is out of scope here

            if (true)
            {
                int ifVar = 99; // only visible inside this if-block
                Console.WriteLine($"  Inside if block: ifVar = {ifVar}");
            }
            // Console.WriteLine(ifVar); // ERROR - ifVar is out of scope here

            Console.WriteLine();
            Console.WriteLine("Both 'blockVar' and 'ifVar' are inaccessible after their closing brace.");
            Console.WriteLine("C# does NOT allow re-declaring them in an outer scope if still in the same method.");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Q6 - Variable Lifetime: Local vs Static
            Console.WriteLine("Q6");
            Console.WriteLine("What is variable lifetime? Explain the lifetime of local variables");
            Console.WriteLine("vs static variables.");
            Console.WriteLine();

            Console.WriteLine("Variable lifetime = how long a variable holds its value in memory.");
            Console.WriteLine();
            Console.WriteLine("Local variable lifetime:");
            Console.WriteLine("  Created when execution enters the method/block.");
            Console.WriteLine("  Destroyed when execution leaves the method/block.");
            Console.WriteLine("  Each call gets a FRESH copy.");
            Console.WriteLine();
            Console.WriteLine("Static variable lifetime:");
            Console.WriteLine("  Created when the class is first loaded.");
            Console.WriteLine("  Persists for the entire duration of the program.");
            Console.WriteLine("  Shared across ALL calls - retains its value between calls.");
            Console.WriteLine();

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Q7 - Garbage Collector
            Console.WriteLine("Q7");
            Console.WriteLine("What is the Garbage Collector in C#? How does it affect the");
            Console.WriteLine("lifetime of objects?");
            Console.WriteLine();

            Console.WriteLine("The Garbage Collector (GC) is a component of the .NET runtime that");
            Console.WriteLine("automatically manages heap memory.");
            Console.WriteLine();
            Console.WriteLine("How it works:");
            Console.WriteLine("  1. Objects are allocated on the heap when created with 'new'.");
            Console.WriteLine("  2. The GC tracks which objects are still reachable (referenced).");
            Console.WriteLine("  3. When an object has no more references it becomes eligible for collection.");
            Console.WriteLine("  4. The GC periodically runs, frees unreachable objects, and compacts the heap.");
            Console.WriteLine();
            Console.WriteLine("Effect on object lifetime:");
            Console.WriteLine("  You do NOT need to free memory manually (unlike C/C++).");
            Console.WriteLine("  An object is not destroyed the instant its last reference is lost;");
            Console.WriteLine("  the GC decides WHEN to collect it (non-deterministic).");
            Console.WriteLine("  For deterministic cleanup of resources (files, DB connections),");
            Console.WriteLine("  implement IDisposable and use the 'using' statement.");
            Console.WriteLine();

            // Demonstration: object created, then reference cleared
            object tempObj = new object();
            Console.WriteLine($"  Object created. HashCode = {tempObj.GetHashCode()}");
            tempObj = null;
            Console.WriteLine("  Reference set to null. Object is now eligible for GC collection.");
            GC.Collect();
            Console.WriteLine("  GC.Collect() requested (GC may or may not run immediately in real apps).");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Q8 - Variable Shadowing
            Console.WriteLine("Q8");
            Console.WriteLine("What is variable shadowing in C#? Does C# allow shadowing in");
            Console.WriteLine("nested blocks within the same method?");
            Console.WriteLine();

            Console.WriteLine("Shadowing = declaring a variable with the same name as one in an outer scope,");
            Console.WriteLine("causing the inner variable to 'hide' the outer one within its block.");
            Console.WriteLine();
            Console.WriteLine("C# DOES allow shadowing between a method variable and a class field:");

            int classField = 999; // this local 'classField' shadows the static classField above
            Console.WriteLine($"  Inside Main, local classField = {classField}  (shadows the class-level field)");
            Console.WriteLine($"  To access the class-level one use: Program.classField = {Program.classField}");
            Console.WriteLine();

            Console.WriteLine("C# does NOT allow shadowing within nested blocks in the same method:");
            Console.WriteLine("  Example that would cause a COMPILE ERROR:");
            Console.WriteLine("    int x = 10;");
            Console.WriteLine("    if (true) { int x = 20; }  // ERROR: x already defined in enclosing scope");
            Console.WriteLine();
            Console.WriteLine("This rule prevents accidental bugs from accidentally reusing variable names.");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Q9 - C# Naming Rules
            Console.WriteLine("Q9");
            Console.WriteLine("List five rules that MUST be followed when naming variables in C#.");
            Console.WriteLine();

            Console.WriteLine("1. Must start with a letter (a-z, A-Z) or an underscore (_).");
            Console.WriteLine("   Valid: _count, myVar   Invalid: 1count, -value");
            Console.WriteLine();
            Console.WriteLine("2. After the first character, can contain letters, digits (0-9), or underscores.");
            Console.WriteLine("   Valid: user1, max_val   Invalid: user-1, max val");
            Console.WriteLine();
            Console.WriteLine("3. Cannot be a C# reserved keyword (if, class, int, for, etc.).");
            Console.WriteLine("   To use a keyword as a name, prefix with @: @class, @int  (avoid this in practice).");
            Console.WriteLine();
            Console.WriteLine("4. Names are CASE-SENSITIVE.");
            Console.WriteLine("   'count', 'Count', and 'COUNT' are three different identifiers.");
            Console.WriteLine();
            Console.WriteLine("5. No spaces or special characters (!, @, #, $, -, .) except the underscore.");
            Console.WriteLine("   Valid: firstName   Invalid: first-name, first.name");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Q10 - Naming Conventions
            Console.WriteLine("Q10");
            Console.WriteLine("What naming conventions are recommended for:");
            Console.WriteLine("(a) local variables  (b) class names  (c) constants");
            Console.WriteLine();

            Console.WriteLine("(a) Local variables and method parameters -> camelCase");
            int totalPrice = 0;
            string firstName = "Ali";
            Console.WriteLine($"    Example: totalPrice = {totalPrice}, firstName = \"{firstName}\"");
            Console.WriteLine();

            Console.WriteLine("(b) Class names, methods, properties, public fields -> PascalCase");
            Console.WriteLine("    Example: class CustomerOrder  |  void CalculateTotal()  |  int MaxRetries");
            Console.WriteLine();

            Console.WriteLine("(c) Constants -> ALL_CAPS_WITH_UNDERSCORES  (or PascalCase - both are used)");
            const int MAX_SCORE = 100;
            const double GravityMs2 = 9.81; // PascalCase style also acceptable
            Console.WriteLine($"    Example: MAX_SCORE = {MAX_SCORE}  |  GravityMs2 = {GravityMs2}");
            Console.WriteLine();
            Console.WriteLine("(bonus) Private fields -> _camelCase with leading underscore");
            Console.WriteLine("    Example: private int _userId;");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Q11 - Error Types
            Console.WriteLine("Q11");
            Console.WriteLine("Compare and contrast syntax errors, runtime errors, and logical errors.");
            Console.WriteLine("Provide an example of each.");
            Console.WriteLine();

            Console.WriteLine("1. SYNTAX ERROR");
            Console.WriteLine("   When:    Code violates the grammar rules of C#.");
            Console.WriteLine("   Caught:  At COMPILE time - program cannot build.");
            Console.WriteLine("   Example: int x = ;          // missing value");
            Console.WriteLine("            Console.WriteLne(); // typo in method name");
            Console.WriteLine();

            Console.WriteLine("2. RUNTIME ERROR (Exception)");
            Console.WriteLine("   When:    Code is syntactically correct but fails during execution.");
            Console.WriteLine("   Caught:  At RUNTIME - program crashes unless handled.");
            Console.WriteLine("   Example:");
            try
            {
                int[] arr = new int[3];
                int bad = arr[10]; // IndexOutOfRangeException at runtime
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"   Caught runtime error: {e.GetType().Name} - {e.Message}");
            }
            Console.WriteLine();

            Console.WriteLine("3. LOGICAL ERROR");
            Console.WriteLine("   When:    Code compiles and runs but produces the WRONG result.");
            Console.WriteLine("   Caught:  Only by testing / code review - compiler cannot detect it.");
            Console.WriteLine("   Example:");
            int a = 10, b = 3;
            // BUG: should be a + b but we accidentally wrote a - b
            int wrongResult = a - b;
            int correctResult = a + b;
            Console.WriteLine($"   Intended a + b = {correctResult}, but code says a - b = {wrongResult}");
            Console.WriteLine("   No error thrown - the bug is silent.");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Q12 - Exception Handling Importance
            Console.WriteLine("Q12");
            Console.WriteLine("Why is exception handling important in C#? What would happen if");
            Console.WriteLine("you don't handle exceptions?");
            Console.WriteLine();

            Console.WriteLine("Without exception handling:");
            Console.WriteLine("  - An unhandled exception causes the program to CRASH immediately.");
            Console.WriteLine("  - The call stack is printed to the console (or event log) and execution stops.");
            Console.WriteLine("  - Users get a poor experience; data may be lost or left in a corrupt state.");
            Console.WriteLine("  - Resources (files, DB connections, network sockets) may not be released.");
            Console.WriteLine();
            Console.WriteLine("With exception handling (try-catch-finally):");
            Console.WriteLine("  - Errors are caught and handled gracefully.");
            Console.WriteLine("  - The program can log the error, inform the user, and continue running.");
            Console.WriteLine("  - Resources are always cleaned up via finally or 'using' blocks.");
            Console.WriteLine("  - You can distinguish expected errors (bad input) from unexpected ones (bugs).");
            Console.WriteLine();
            Console.WriteLine("Example - without handling, this would crash the entire program:");
            try
            {
                string s = null;
                int len = s.Length; // NullReferenceException
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("  Caught NullReferenceException - program continues instead of crashing.");
            }

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Q13 - try-catch-finally
            Console.WriteLine("Q13");
            Console.WriteLine("Write a code example demonstrating try-catch-finally.");
            Console.WriteLine("Explain when the finally block executes.");
            Console.WriteLine();

            Console.WriteLine("finally ALWAYS executes - whether an exception occurred or not.");
            Console.WriteLine("Use it to release resources (close files, DB connections, etc.).");
            Console.WriteLine();

            Console.WriteLine("--- Scenario A: no exception ---");
            try
            {
                Console.WriteLine("  try: Opening file...");
                int result = 10 / 2;
                Console.WriteLine($"  try: Result = {result}. No exception.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("  catch: Division by zero caught.");
            }
            finally
            {
                Console.WriteLine("  finally: File closed. (runs regardless of exception)");
            }

            //Console.WriteLine();
            //Console.WriteLine("--- Scenario B: exception occurs ---");
            //try
            //{
            //    Console.WriteLine("  try: Attempting division by zero...");
            //    int result = 10 / 0;
            //    Console.WriteLine("  try: This line is NEVER reached.");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine($"  catch: Caught - {ex.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine("  finally: Still runs even after exception was caught.");
            //}

            //Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Q14 - Common Built-in Exceptions
            Console.WriteLine("Q14");
            Console.WriteLine("List and explain five common built-in exceptions in C# with scenarios.");
            Console.WriteLine();

            Console.WriteLine("1. NullReferenceException");
            Console.WriteLine("   Scenario: Calling a method or property on an object that is null.");
            try { string s = null; _ = s.Length; }
            catch (NullReferenceException) { Console.WriteLine("   Caught: string s = null; s.Length;"); }

            Console.WriteLine();
            Console.WriteLine("2. IndexOutOfRangeException");
            Console.WriteLine("   Scenario: Accessing an array element with an invalid index.");
            try { int[] arr = new int[3]; _ = arr[5]; }
            catch (IndexOutOfRangeException) { Console.WriteLine("   Caught: arr[5] on a 3-element array."); }

            //Console.WriteLine();
            //Console.WriteLine("3. DivideByZeroException");
            //Console.WriteLine("   Scenario: Dividing an integer by zero.");
            //try { int x = 5 / 0; }
            //catch (DivideByZeroException) { Console.WriteLine("   Caught: 5 / 0 integer division."); }

            Console.WriteLine();
            Console.WriteLine("4. FormatException");
            Console.WriteLine("   Scenario: Parsing a string that is not a valid number.");
            try { int.Parse("abc"); }
            catch (FormatException) { Console.WriteLine("   Caught: int.Parse(\"abc\");"); }

            Console.WriteLine();
            Console.WriteLine("5. InvalidCastException");
            Console.WriteLine("   Scenario: Unboxing an object to a different type than it was boxed as.");
            try { object o = 10; long l = (long)o; }
            catch (InvalidCastException) { Console.WriteLine("   Caught: object o = 10 (int); cast to long directly."); }

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Q15 - Multiple catch Blocks
            Console.WriteLine("Q15");
            Console.WriteLine("Why is the order of catch blocks important when handling multiple");
            Console.WriteLine("exceptions? Write code showing correct ordering.");
            Console.WriteLine();

            Console.WriteLine("Rule: catch blocks are evaluated TOP to BOTTOM.");
            Console.WriteLine("More specific (child) exceptions MUST come before more general (parent) ones.");
            Console.WriteLine("Exception inherits from SystemException which inherits from Exception.");
            Console.WriteLine("Placing 'catch (Exception)' first would swallow ALL exceptions, making");
            Console.WriteLine("the specific handlers unreachable (compile error in C#).");
            Console.WriteLine();

            Console.WriteLine("CORRECT ORDER (specific -> general):");
            try
            {
                int[] arr = new int[3];
                Console.WriteLine("  Accessing arr[10]...");
                _ = arr[10];
            }
            catch (IndexOutOfRangeException ex)   // most specific - checked first
            {
                Console.WriteLine($"  Caught specific: IndexOutOfRangeException - {ex.Message}");
            }
            catch (SystemException ex)             // less specific
            {
                Console.WriteLine($"  Caught SystemException: {ex.Message}");
            }
            catch (Exception ex)                   // most general - checked last
            {
                Console.WriteLine($"  Caught Exception: {ex.Message}");
            }

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Q16 - throw vs throw ex
            Console.WriteLine("Q16");
            Console.WriteLine("What is the difference between 'throw' and 'throw ex' when");
            Console.WriteLine("re-throwing an exception? Which one preserves the stack trace?");
            Console.WriteLine();

            Console.WriteLine("'throw'    - re-throws the ORIGINAL exception with its full stack trace preserved.");
            Console.WriteLine("             Use this when you want to let the exception propagate unchanged.");
            Console.WriteLine();
            Console.WriteLine("'throw ex'  - throws the exception as if it originated HERE.");
            Console.WriteLine("              RESETS the stack trace, losing the original call information.");
            Console.WriteLine("              This makes debugging much harder - AVOID unless intentional.");
            Console.WriteLine();
            Console.WriteLine("Best practice: always use bare 'throw' when re-throwing.");
            Console.WriteLine();

            Console.WriteLine("Example - 'throw' (correct):");
            try
            {
                try
                {
                    int[] arr = new int[1];
                    _ = arr[5];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("  Inner catch: logging the error...");
                    throw;  // re-throw - original stack trace preserved
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"  Outer catch: {ex.GetType().Name} re-caught with original trace.");
            }

            Console.WriteLine();
            Console.WriteLine("Example - 'throw ex' (avoid - loses stack trace):");
            try
            {
                try
                {
                    int[] arr = new int[1];
                    _ = arr[5];
                }
                catch (IndexOutOfRangeException ex)
                {
                    // throw ex;  // this would reset stack trace - shown commented out intentionally
                    Console.WriteLine("  'throw ex' would reset the stack trace to this line.");
                    throw; // using correct form in this demo
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("  Outer catch received the exception.");
            }

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Q17 - Stack and Heap Memory
            Console.WriteLine("Q17");
            Console.WriteLine("Explain the differences between Stack and Heap memory in C#.");
            Console.WriteLine("What types of data are stored in each?");
            Console.WriteLine();

            Console.WriteLine("STACK:");
            Console.WriteLine("  Structure : LIFO (Last In, First Out).");
            Console.WriteLine("  Speed     : Very fast - just moves a pointer.");
            Console.WriteLine("  Size      : Small and fixed (typically 1-4 MB).");
            Console.WriteLine("  Managed by: Runtime automatically - no GC needed.");
            Console.WriteLine("  Stores    : Value types (int, double, bool, struct, char)");
            Console.WriteLine("              and reference variables (the POINTER, not the object).");
            Console.WriteLine("  Lifetime  : Automatically freed when method returns.");
            Console.WriteLine();

            Console.WriteLine("HEAP:");
            Console.WriteLine("  Structure : Unordered pool of memory.");
            Console.WriteLine("  Speed     : Slower - allocation involves finding free space.");
            Console.WriteLine("  Size      : Large (limited by system RAM).");
            Console.WriteLine("  Managed by: Garbage Collector.");
            Console.WriteLine("  Stores    : Reference type objects (class instances, arrays, strings).");
            Console.WriteLine("  Lifetime  : Until no references point to the object (then GC collects it).");
            Console.WriteLine();

            // Demonstration
            int stackValue = 42;               // int lives on the stack
            int[] heapArray = new int[3];      // array object lives on the heap; heapArray (pointer) on stack
            Console.WriteLine($"  stackValue = {stackValue}  (int on stack)");
            Console.WriteLine($"  heapArray reference is on the stack; the int[3] object is on the heap.");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Q18 - Value Types vs Reference Types
            Console.WriteLine("Q18");
            Console.WriteLine("Write a code example showing how value types and reference types");
            Console.WriteLine("behave differently when assigned to another variable.");
            Console.WriteLine();

            // VALUE TYPE - assignment copies the value
            Console.WriteLine("VALUE TYPE (int) - assignment creates an independent copy:");
            int original = 10;
            int copy = original;  // copy gets its own independent copy of the value
            copy = 99;
            Console.WriteLine($"  original = {original}  (unchanged)");
            Console.WriteLine($"  copy     = {copy}     (modified independently)");
            Console.WriteLine();

            // REFERENCE TYPE - assignment copies the reference (both point to same object)
            Console.WriteLine("REFERENCE TYPE (int[]) - assignment copies the REFERENCE, not the data:");
            int[] arrayA = { 1, 2, 3 };
            int[] arrayB = arrayA;   // arrayB points to the SAME object in heap memory
            arrayB[0] = 999;
            Console.WriteLine($"  arrayA[0] = {arrayA[0]}  (changed! both variables point to same array)");
            Console.WriteLine($"  arrayB[0] = {arrayB[0]}");
            Console.WriteLine();
            Console.WriteLine("To get a true copy of a reference type, you must explicitly clone/copy it:");
            int[] arrayC = (int[])arrayA.Clone();
            arrayC[0] = 1;
            Console.WriteLine($"  After Clone: arrayA[0] = {arrayA[0]}, arrayC[0] = {arrayC[0]}  (independent)");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Q19 - Object in C#
            Console.WriteLine("Q19");
            Console.WriteLine("Why is 'object' considered the base type of all types in C#?");
            Console.WriteLine("What methods does every type inherit from System.Object?");
            Console.WriteLine();

            Console.WriteLine("'object' is an alias for System.Object.");
            Console.WriteLine("In C#, EVERY type - whether int, string, a custom class, or an enum -");
            Console.WriteLine("implicitly inherits from System.Object. This is the root of the type hierarchy.");
            Console.WriteLine("It means any value can be stored in an object variable (boxing for value types).");
            Console.WriteLine();
            Console.WriteLine("Methods every type inherits from System.Object:");
            Console.WriteLine();
            Console.WriteLine("  1. ToString()");
            Console.WriteLine("     Returns a string representation of the object.");
            int num = 42;
            Console.WriteLine($"     42.ToString() = \"{num.ToString()}\"");

            Console.WriteLine();
            Console.WriteLine("  2. Equals(object obj)");
            Console.WriteLine("     Checks equality. Value types compare by value; reference types by reference by default.");
            Console.WriteLine($"     42.Equals(42) = {num.Equals(42)}");

            Console.WriteLine();
            Console.WriteLine("  3. GetHashCode()");
            Console.WriteLine("     Returns an integer hash code used in hash-based collections (Dictionary, HashSet).");
            Console.WriteLine($"     42.GetHashCode() = {num.GetHashCode()}");

            Console.WriteLine();
            Console.WriteLine("  4. GetType()");
            Console.WriteLine("     Returns a Type object describing the runtime type of the instance.");
            Console.WriteLine($"     42.GetType() = {num.GetType()}");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion
        }
    }
}