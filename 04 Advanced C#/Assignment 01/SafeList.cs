using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_01
{
    internal class SafeList<T>
    {
        private List<T> _list = new List<T>();

        public int Count => _list.Count;

        public void Add(T item)
        {
            _list.Add(item);
        }

        public T Get(int index)
        {
            if(index < 0 || index >= _list.Count)
            {
                return default(T);
            }

            else
            {
                return _list[index];
            }
        }

    }
}
