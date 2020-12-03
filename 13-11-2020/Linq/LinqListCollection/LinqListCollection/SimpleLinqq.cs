using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqListCollection
{
    class SimpleLinqq
    {
        public void LinQM()
        {
            // string collection
            Console.WriteLine("-----------------");
            Console.WriteLine("LinQ Using Method Syntax:");
            IList<string> stringList = new List<string>() {
            "C# Tutorials",
            "VB.NET Tutorials",
            "Learn C++",
            "MVC Tutorials" ,
            "Java"
        };

            // LINQ Method Syntax
            var result = stringList.Where(s => s.Contains("Tutorials"));


            foreach (var str in result)
            {
                Console.WriteLine(str);
            }
        }

    }
}
