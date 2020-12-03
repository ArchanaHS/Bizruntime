using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace AsyncTaskAwait
{
    class Async
    {
        public void method()
        {
            Console.WriteLine("Starting.......");
            var worker = new Worker();
            worker.DoWork();
            while (!worker.isComplete)
            {
                Console.Write(".");
                Thread.Sleep(1000);

            }
            Console.WriteLine("done");
            Console.ReadKey();
        }

    }
    public class Worker
    {
        public bool isComplete { get; private set; }
        public async void DoWork()
        {
            this.isComplete = false;
            Console.WriteLine("Doing Work...");
            LongOperation();
            Console.WriteLine("work complete...");
            isComplete = true;
        }
        private void LongOperation()
        {
            return Task.Factory.StartNew(()=>{
                Console.WriteLine("Working...");
                Thread.Sleep(100);
                });
        }


    }
}
