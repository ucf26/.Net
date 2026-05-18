using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_01
{
    internal class Container<T>
    {
        private T[] _arr;

        public T this[int index] {
            get{
                return _arr[index];
            }

            set
            {
                _arr[index] = value;
            }
        
        }
    }
}
