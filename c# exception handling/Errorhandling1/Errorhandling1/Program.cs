using System;

namespace Errorhandling1
{
    class Exceptionhandling
    {
        static void Main(string[] args)
        {
            int i = 20;
            int j = Convert.ToInt32(Console.ReadLine());
            int result=0;
            try
            {
                 result = i/j;
            }
           
            catch (Exception e)
            {
                Console.WriteLine("Divide by zero is not allowed ");
            }
            finally
                {
                Console.WriteLine("blocked");
            }
            Console.WriteLine("result is"+result);
            Console.ReadKey();
        }
    }
}
