using System;
using System.Threading.Tasks;



namespace Task1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Task1");
            var t1 = Task.Delay(2000);
            // await Task.Delay(2000);
            await t1;
            Console.WriteLine(t1.IsCompleted);
            Console.WriteLine("Task2");
            Console.WriteLine("Done....");
            Console.ReadKey();
        }
    }
}

