using System;
using System.IO;

namespace Date
{
    class Program

    {
        static  void method()
        {
            
            DateTime dt1 = new DateTime();
            Console.WriteLine(dt1);

            DateTime dt2 = new DateTime(2014,12,30);
            Console.WriteLine(dt2);

            DateTime dt3 = new DateTime(2015, 12, 31, 5, 10, 20);
            Console.WriteLine(dt3);

            DateTime dt4 = new DateTime(2015, 12, 31, 5, 10, 20,DateTimeKind.Utc);
            Console.WriteLine(dt4);


            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine(currentDateTime);

            DateTime todaysdate = DateTime.Today;
            Console.WriteLine(todaysdate);

            DateTime dt = new DateTime(2015, 12, 30);
            TimeSpan ts = new TimeSpan(25, 20, 55);
            DateTime newDate = dt.Add(ts);
            Console.WriteLine(newDate);
        }

        static void Main(string[] args)
        {
            method();
        }
    }
}
