using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Session01_AdvancedC_
{
    internal class Employee:Person, IPrintable
    {
        public int Id { get; set; }

        public void Print()
        {
            Console.WriteLine($"Employee: {Name}");
        }
    }
}
