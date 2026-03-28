using System.Data;
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

            #region Question04
            ////Q4: What is a generic method? Write Swap<T> method.

            ////A method that uses a type parameter (like <T>) so it can work with any data type.

            //int a = 10, b = 20;
            //Utility.Swap<int>(ref a, ref b);

            //Console.WriteLine(b);//10
            //Console.WriteLine(a);//20
            #endregion


            #region Question05
            //Q5: Write a generic method FindMax<T> that finds maximum value
            //int[] Numbers = { 10, 5, 7, 8, 12, 15, 4, };
            //Utility.PrintArray<int>(Numbers);
            //Console.WriteLine($"Max Number ={Utility.FindMax(Numbers)}");

            #endregion
            #region Question06
            //Q6: What is a generic interface? Write IRepository<T>. 

            //IReposatory<Product> productRepo = new ProductRepository();
            //productRepo.Add(new Product(1, "Iphone16", 5000.00m));
            //productRepo.Add(new Product(2, "Iphone17", 6000.00m));



            #endregion
            #region Question07
            ////Q7: What is the 'struct' constraint? Write an example.
            ////generic constraint that ensures the type parameter must be a value type
            ////(like int, double, DateTime, or a custom struct)

            //ValueHolder<int> intHolder = new (100);
            //Console.WriteLine(intHolder.Value);

            //ValueHolder<double> doubleHolder = new (3.14);
            //Console.WriteLine(doubleHolder.Value);
            #endregion
            #region Question08
            //Q8: What is the 'class' constraint? Write an example.
            //generic constraint that ensures the type parameter must be a reference type
            ////Repository<string> stringRepo = new Repository<string>();
            ////stringRepo.Add("Hello");
            ////stringRepo.Add("World");
            ////Console.WriteLine(stringRepo.GetFirst()); 
            #endregion
            #region Question09
            //Q9: What is the 'new()' constraint? Write an example 
            //  must have a public parameterless constructor 


            ////Factory<Product> productFactory = new Factory<Product>();
            ////Product p = productFactory.CreateInstance();
            ////Console.WriteLine(p.Name);
            #endregion
        }
    }
}
