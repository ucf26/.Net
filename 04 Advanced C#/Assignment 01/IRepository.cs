using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_01
{
    internal interface IRepository<T>
    {
        T? GetByID(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
