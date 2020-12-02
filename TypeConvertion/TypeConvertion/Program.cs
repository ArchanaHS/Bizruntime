using System;

namespace TypeConvertion
{
    class Conversion// class declaration.
    {

        static void Main(string[] args)
        {
            double d = 5673.74; // value intialization.
            int i; // variable declaration.

            // cast double to int.
            i = (int)d; // type casting.
            Console.WriteLine(i);
            Console.ReadKey();



        }
    }
}

