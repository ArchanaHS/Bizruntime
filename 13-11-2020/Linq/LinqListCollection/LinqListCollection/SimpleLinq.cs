using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqListCollection
{
    class SimpleLinq
    {
        public void Method()
        {
            List<Employee> obj = new List<Employee>()
                {
                new Employee { EId=1,Name = "Akshay", Location="Chennai" },
                new Employee {EId=2,Name="abhinav",Location="Chennai" },
                new Employee { EId=2,Name = "Vaishali", Location="Chennai" },
                new Employee { EId=3,Name = "Priyanka", Location="Guntur" },
                new Employee { EId=4,Name = "Preeti", Location ="Vizag"},
                };

            //linq in query stntax.
            var result = from e in obj
                         where e.Location.Equals("Chennai")
                         select new
                         {
                             Name = e.Name,
                             Location = e.Location
                         };

            //foreach loop is used to print the value of the 'result' having the output of the LINQ query  
            foreach (var item in result)
            {
                Console.WriteLine(item.Name + "\t | " + item.Location);
            }
            Console.ReadLine();


        }

        class Employee
        {
            public int EId { get; set; }
            public string Name { get; set; }
            public string Location { get; set; }
        }
    }
    }
    
