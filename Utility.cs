using System;
using System.Collections.Generic;
using System.Numerics;
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
        public static void PrintArray<T>( T[] items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        public static T FindMax <T>( T[] items) where T : INumber<T>
        {
            T max = items[0];

            foreach (var item in items)
            {
                if (item> max)
                    
                max = item;
            }
            return max;
        }
    }
}
