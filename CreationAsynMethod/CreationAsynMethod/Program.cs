using System;
using System.Threading;
using System.Threading.Tasks;

namespace CreationAsynMethod
{
    class Program
    {
        public static async void AnotherMethod()
        {
            //first
            var x=await CookEgg();
            //second
            CookBacons();
            Breadtoast();
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            AnotherMethod();
            Console.ReadLine();
        }
        public static async Task<bool> CookEgg()
        {
            bool Result = false;
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Egg cooked...");
                Result = true;
            });
            return Result;
           
        }
        public static async void CookBacons()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Bacons cooked..");
            });
            
        }
        public static async void Breadtoast()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Bread toasted..");
            });

        }
    }
}
