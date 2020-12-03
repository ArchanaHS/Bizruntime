using System;
using System.Threading;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Globalization;

namespace AsyncTask
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string cup = PourCoffee();

            Console.WriteLine("coffee is ready");

            var eggsTask = FryEggsAsync(2);
            var baconTask = FryBaconAsync(3);
            var toastTask = MakeToastWithButterAndJamAsync(2);

            var allTasks = new List<Task> { eggsTask, baconTask, toastTask };

            while (allTasks.Any())
            {
                Task finished = await Task.WhenAny(allTasks);

                if (finished == eggsTask)
                {
                    Console.WriteLine("eggs are ready");
                }
                else if (finished == baconTask)
                {
                    Console.WriteLine("bacon is ready");
                }
                else if (finished == toastTask)
                {
                    Console.WriteLine("toast is ready");
                }


                allTasks.Remove(finished);
            }

            Console.WriteLine("Breakfast is ready!");

            async Task<string> MakeToastWithButterAndJamAsync(int number)
            {
                var toast = await ToastBreadAsync(number);
                return toast;
            }
        }

        static void ttt()
        {
            Console.WriteLine(Thread.CurrentThread.Name + ": " + (10281.834483255407).ToString());
        }

        static int hardloop()
        {
            for (var i = 0; i < 10000; i++) { }
            return 0;
        }

        static string PourCoffee()
        {
            int i = hardloop();
            return "coffe";
        }

        static string PourOJ()
        {
            int i = hardloop();
            return "OJ";
        }

        static async Task<string> FryEggsAsync(int i)
        {
            int j = 0;
            await Task.Run(() => { j = hardloop(); });
            return "egg";
        }

        static async Task<string> FryBaconAsync(int i)
        {
            int j = 0;
            await Task.Run(() => { j = hardloop(); });
            return "bacon";
        }

        static async Task<string> ToastBreadAsync(int i)
        {
            int j = 0;
            await Task.Run(() => { j = hardloop(); });
            return "toast";
        }
    }
}
