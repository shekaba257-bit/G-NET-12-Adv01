using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Session01_AdvancedC_
{
    internal class Person
    {
        public string Name { get; set; }
        public void Greet()
        {
            Console.WriteLine($"Hello, {Name}!");
        }

    }
}
