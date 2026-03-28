using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Session01_AdvancedC_
{
    internal class SafeList<T>

    {
        private List<T> items = new List<T>();
        public int Count => items.Count;

   
        public void Add(T item)
        {
            items.Add(item);
        }

       
        public T Get(int index)
        {
            if (index >= 0 && index < items.Count)
            {
                return items[index];
            }
            else
            {
                return default(T); 
            }
        }

     
    }
}
