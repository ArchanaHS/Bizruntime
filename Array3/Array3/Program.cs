using System;
using System.Collections.Generic;//namespace to access list
using System.Linq;

namespace Array3
{
    class Foreachloop
    {
        static void Main(string[] args)
        {
            Foreachloop b= new Foreachloop();

            b.method();

        }

            private void method()
            {

                var val = new[] { 20, 40, 60 };

                var str = new[] { " ele1", " ele2", " ele3" };
                var res = val.Zip(str, (n, w) => new { Number = n, Word = w });

                foreach (var a in res)
                {
                    Console.WriteLine(a.Number + a.Word);
                }
            }

        
    }
}

