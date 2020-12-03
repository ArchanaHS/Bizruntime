using System;
using System.Threading;
using System.Threading.Tasks;
namespace ThreadLockingProgramming
{
    class ThreadLocking
    {
        public void Display()
        {
            lock (this)
            {
                Console.Write("[CSharp is an ");
                Thread.Sleep(3000);
                Console.WriteLine("Object Oriented language..]");
            }
        }
        static void Main(string[] args)
        {
            ThreadLocking obj = new ThreadLocking();

            //obj.Display();
            //obj.Display();
            //obj.Display();
            Thread t1 = new Thread(obj.Display);
            Thread t2 = new Thread(obj.Display);
            Thread t3 = new Thread(obj.Display);
            t1.Start();
            t2.Start();
            t3.Start();

            Console.ReadLine();
        }
    }
}
