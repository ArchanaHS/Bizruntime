using System;
using System.Threading;

namespace MultiThreadin2
{
    class Program
    {

        static void Test1()
        {
            for(int i=1; i<=100; i++)
            {
                Console.WriteLine("Test1 :" + i);
            }
        }

        static void Test2(object Max)
        {
            int num = Convert.ToInt32(Max);
            for (int i = 1; i<= num; i++)
            {
                Console.WriteLine("Test2 :" + i);
            }
        }


        static void Main(string[] args)
        {
            //creating instance of threadstart  d passing parameter as a Method Name.
            //Delegates.
            //Explicitly perform the instance of the class.
            //ThreadStart obj = new ThreadStart(Test1);

            //we can instaiate the delegate directly by passing the method.
            ThreadStart obj = Test1;

            
            Thread T1 = new Thread(obj);
            Test1();
            Console.ReadLine();

            ParameterizedThreadStart obj1 = new ParameterizedThreadStart(Test2);
            Thread T2 = new Thread(obj1);
            T2.Start(50);
            Console.ReadLine();

           
        }
    }
}
