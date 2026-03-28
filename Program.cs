using System.Net.NetworkInformation;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_Session01_AdvancedC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //Q1: What is a generic class? Why use generics?
            //Generic class:
            //A class that uses a type parameter(like<T>) instead of a fixed data type, so it can work with any type
            //Why use generics ?
            //Reusability : write once, use with different types
            //Type safety: fewer errors
            //Performance: no boxing / unboxing
            #endregion

            #region Question02
            //Q2: Write a generic class Container<T> with Add and Get methods.
            //Container<string> stringcontainer= new Container<string>();
            //stringcontainer.Add("Iphone16");

            #endregion
            #region Question03
            ////Using more than one generic type(like<TKey, TValue>) in a class

            //Pair<int, string> pair1 = new Pair<int, string>(1, "Hello");
            //Console.WriteLine(pair1.Key);
            //Console.WriteLine(pair1.Value);

            //Pair<string, double> pair2 = new Pair<string, double>("Price", 99.9);
            //Console.WriteLine(pair2.Key);
            #endregion

        }
    }
}
