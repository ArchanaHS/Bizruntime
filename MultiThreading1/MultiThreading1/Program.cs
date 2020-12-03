using System;
using System.Threading;

namespace MultiThreading1
{
    class MultiProgram
    {
        static  void Test1()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test1 :" + i);
            }
            Console.WriteLine("Thread1 is exiting...");
        }
        static void Test2()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test2 :" + i);

                if (i == 50)
                {
                    Console.WriteLine("Thread2 gpoing to sleep now..");
                    Thread.Sleep(10000);
                    Console.WriteLine("Thread2 wokeup....");
                }
            }
            Console.WriteLine("Thread2 is exiting...");
        }
        static void Test3()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test3:" + i);
            }
            Console.WriteLine("Thread3 is exiting...");
        }

        static void Main(string[] args)
        {

            
            Thread T1=new Thread(Test1);
            
            Thread T2=new Thread(Test2);
            Thread T3=new Thread(Test3);
            T1.Start();
            T2.Start();
            T3.Start();
            Console.WriteLine("Thread Main is Exiting....");
        }
    }
}
