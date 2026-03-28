using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Session01_AdvancedC_
{
    internal class Utility
    {

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
