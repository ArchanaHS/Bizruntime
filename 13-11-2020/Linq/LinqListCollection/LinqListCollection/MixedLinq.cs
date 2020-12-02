using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqListCollection
{
    class MixedLinq
    {
        public void Method1()
       {
            List<int> integerList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };
            //LINQ Query using Mixed Syntax  
            var MethodSyntax = (from objj in integerList
                         where objj > 5
                select objj ).Sum();
            //Execution  
            Console.WriteLine("-----------------");
            Console.Write("Sum Is : " + MethodSyntax);

            Console.ReadKey();

        }

    }
}
