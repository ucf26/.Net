using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Xml.Schema;

namespace Assignment_01
{
    internal static class Utilities
    {
        public static void swap<T>(ref T x, ref T y)
        {
            T tmp = x;
            x = y;
            y = tmp;
        }

        public static T FindMax<T>(T[] arr) where T : IComparable<T>
        {
            T res = arr[0];
            foreach (T t in arr)
            {
                if(t.CompareTo(res) > 0)
                {
                    res = t;
                }
            }
            return res;
        }
    }
}
