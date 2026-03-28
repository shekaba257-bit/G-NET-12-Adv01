using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Session01_AdvancedC_
{
    internal class Container<T>
    {
     
            private T item;

            public void Add(T value)
            {
                item = value;
            }

            public T Get()
            {
                return item;
            }
       
    }
}
