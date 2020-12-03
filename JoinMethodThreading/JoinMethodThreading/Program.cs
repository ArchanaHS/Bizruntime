using System;
using System.Threading;

namespace JoinMethodThreading
{
    class Program
    {
        static void Test1()
        {
            Console.WriteLine("thread1 is starting..");
            for (int i = 0; i <= 50; i++)
                Console.WriteLine("Test1 :" + i);
            Thread.Sleep(5000);
            Console.WriteLine("Test1 thread is exiting..");
             
        }
        static void Test2()
        {
            Console.WriteLine("thread2 is starting..");
            for (int i = 0; i <= 50; i++)
                Console.WriteLine("Test2 :" + i);
            Console.WriteLine("Test2 thread is exiting..");
        }
        static void Test3()
        {
            Console.WriteLine("thread3 is starting..");
            for (int i = 0; i <= 50; i++)
                Console.WriteLine("Test3 :" + i);
            Console.WriteLine("Test3 thread is exiting..");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("The Main Tread Started.....");
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Start();
            t2.Start();
            t3.Start();
            t1.Join(3000);//overloading method
            t2.Join();
            t3.Join();
            Console.WriteLine("Main thread is exiting...");
        }
    }
}
