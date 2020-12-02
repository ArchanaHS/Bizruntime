using System;

namespace variable
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable declaration.
            short a;
            int b;
            double c;
            string name;

            /* actual initialization */
            a = 10;
            b = 20;
            c = a + b;
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
            // acceptong value from the user.
            Console.WriteLine("user name");
           name= Convert.ToString(Console.ReadLine());
            Console.WriteLine(b);
            Console.ReadLine();
        }
        
           
            

    }
}
