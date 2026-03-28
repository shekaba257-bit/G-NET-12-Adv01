using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Session01_AdvancedC_
{
    internal class Manager<T> where T : Person, IPrintable, new()
    {
        public void Welcome(T item)
        {
            item.Greet(); // safe because T inherits from Person
        }
        public void CreateAndPrint()
        {
            T item = new T(); // allowed because of new() constraint
            item.Print();     // allowed because of IPrintable
            Console.WriteLine(item.Name); // allowed because of Person
        }
    }

}
