using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_03
{
    internal static class Utilities
    {
        public static void Print<T>(this IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
