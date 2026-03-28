using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Session01_AdvancedC_
{
    internal interface IReposatory<T>
    {
        void Add(T item);
        void Remove(T item);
        T GetById(int id);
    }
}
