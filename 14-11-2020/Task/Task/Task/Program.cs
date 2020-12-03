using System;

using System.Threading.Tasks;
namespace TaskProblem
{
    /*  public static class TaskProgram
      {
          public static void Main()
          {
              Task t = Task.Run(() =>

              {
                  for (int x = 0; x < 50; x++)
                  {
                      Console.Write("Hi ");
                  }
              });
              t.Wait();
          }
      }*/



    class Program
    {
        static void Main()
        {
            // Call Task.Run and invoke Method1.
            // ... Then call Method2.
            //     Finally wait for Method2 to finish for terminating the program.

            Task.Run(() => Method1()).ContinueWith(task => Method2()).Wait();
        }

        static void Method1()
        {
            Console.WriteLine("::Method1::");
        }

        static void Method2()
        {
            Console.WriteLine("::Method2::");
        }
    }

}