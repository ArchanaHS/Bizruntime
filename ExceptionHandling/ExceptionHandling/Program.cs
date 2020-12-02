using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                int x = a / b;
            }
            //catch(Exception e)
            catch(NullReferenceException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("this code is executed..");
            }
            Console.WriteLine("Reset of the code....");

        }
    }
}
