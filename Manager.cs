using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Session01_AdvancedC_
{
    internal class Manager<T> where T : Person
    {
        public void Welcome(T item)
        {
            item.Greet(); // safe because T inherits from Person
        }
    }

}
