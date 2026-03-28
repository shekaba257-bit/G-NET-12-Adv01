using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Session01_AdvancedC_
{
    internal class Printer<T> where T : IPrintable
    {
        public void PrintItem(T item)
        {
            item.Print(); // safe to call because T implements IPrintable
        }

    }
}
