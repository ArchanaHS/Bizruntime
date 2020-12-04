using System;
using System.Collections.Generic;
using System.Text;

using System.Linq;


namespace CollectionLinq
{
    class PartionOperator
    {
        public void partion()
        {
            string[] countries = { "India", "Africa", "USA", "China", "Astralia", "Russia","Uk"};
            //linq take operator with Method syntax.
            IEnumerable<string> result = countries.Take(3);

            foreach(string s in result)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(".............................");
            //linq take operator with Query synatx.
            IEnumerable<string> result1 = (from x in countries select x).Take(4);
            foreach(string ss in result1)
            {
                Console.WriteLine(ss);
            }

            //linq  takewhile operator.
            Console.WriteLine("........................");
            IEnumerable<string> result2 = countries.TakeWhile(x => x.StartsWith("U"));
            foreach(string sb in result2)
            {
                Console.WriteLine(sb);
            }
            //linq skip operator.
            Console.WriteLine("........................");

            IEnumerable<string> result3 = countries.Skip(3);
            foreach(string sk in result3)
            {
                Console.WriteLine(sk);
            }

            Console.WriteLine("..................");

            //converting input collection to list method and array method.
            //List<string> result4 = countries.ToList();
            Console.WriteLine("list of elements.....");

            //List<string> result4 = (from x in countries select x).ToList();
            string[] result4 = (from x in countries select x).ToArray();
            foreach(string lsc in result4)
            {
                Console.WriteLine(lsc);
            }
            Console.ReadLine();
        }
    }
}
