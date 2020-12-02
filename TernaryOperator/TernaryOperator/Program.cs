using System;

namespace TernaryOperator
{
    class Program
    {
        static void method()
        {
            int time = 20;
            string result = (time < 18) ? "Good day" : "good evening.";
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            method();
        }
    }
}
