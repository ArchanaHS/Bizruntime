//static polymorphism
using System;

namespace PolymorphismApplication
{

    class Printdata
    {
        //method overloading.
        void print(int i)
        {
            Console.WriteLine("Printing int: {0}", i);
        }

        void print(double f)
        {
            Console.WriteLine("Printing float: {0}", f);
        }

        void print(string s)
        {
            Console.WriteLine("Printing string: {0}", s);
        }

        static void Main(string[] args)
        {
            Printdata p = new Printdata();//object declaration.

            // Call print to print integer
            p.print(5);

            // Call print to print float
            p.print(500.263);

            // Call print to print string
            p.print("Hello C++");
            Console.ReadKey();
        }
    }
}
