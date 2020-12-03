using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ThreadLocking
    {

        class ThreadPriorities
        {
            static long Count1, Count2;
            public static void IncrementCount1()
            {
                
                while (true)
                    Count1 += 1;


            }
            public static void IncrementCount2()
            {
                while (true)
                    Count2 += 1;


            }
             static void Main()
            {
                Thread t1 = new Thread(IncrementCount1);
                Thread t2 = new Thread(IncrementCount2);

                t1.Priority = ThreadPriority.Lowest;
                t2.Priority = ThreadPriority.Highest;

                t1.Start();
                t2.Start();

            Console.WriteLine("The Main Method are going to sleep...");
            Thread.Sleep(3000);
            Console.WriteLine("The main Thread woke up...");


            try
            {
                t1.Abort();
                t2.Abort();

            }catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }



            t1.Join();
                t2.Join();

            Console.WriteLine("The Count1 :" + Count1);
            Console.WriteLine("The Count2 :" + Count2);

            Console.ReadLine();



        }

        }
    }


