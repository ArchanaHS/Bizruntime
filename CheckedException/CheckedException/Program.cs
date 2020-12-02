using System;

namespace CheckedException
{
    class Program
    {
        static void Main(string[] args)
        {
            unchecked
            //checked
            {

                int val = int.MaxValue;
                Console.WriteLine(val + 2);

            }
        }
    }
}