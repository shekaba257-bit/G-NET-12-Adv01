using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Session01_AdvancedC_
{
    internal class Document : IPrintable
    {
        public string Title { get; set; } = "My Document";
        public void Print()
        {
            Console.WriteLine($"Printing: {Title}");
        }
    }
}
