using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CollectionLinq
{
    class SimpleLinqProgram
    {
        public void SortingOperation()
        {
            //creating datasource.
            int[] Numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            //creating query to fetch the value from the database.
            //var numQuery =
            //    from num in Numbers
            //    where (num % 2) == 0
            //    select num;

            // var numQuery = Numbers.Where(num => (num % 2) == 0);//Method Query

            //Mixed Syntax.

            var numQuery = (from num in Numbers
                            where (num % 2) == 0
                            select num).ToArray();
            

            foreach (int num in numQuery)
            {
                Console.WriteLine("{0,1}", num);
            }

            //Min value
            int MinimumNum = Numbers.Min();
            Console.WriteLine("Minimum value is:{0} ",MinimumNum);

            //Max Value
            int MaximumNum = Numbers.Max();
            Console.WriteLine("Maximum Number is:{0})", MaximumNum);

            //sum function
            Console.WriteLine("Calculating sum of all element in the list...");
            int sum = Numbers.Sum();
            Console.WriteLine("The sum is:{0} ", sum);

            //count the element.
            Console.WriteLine("Counting element in the list...");
            int count = Numbers.Count();
            Console.WriteLine("Element in the list: {0}", count);

            //Aggregate Function.
            Console.WriteLine("Product of element : ");
            int Average = Numbers.Aggregate((a, b) => a * b);
            Console.WriteLine("Product is {0}", Average);

        }



        static void Main(string[] args)
        {
            SimpleLinqProgram slp = new SimpleLinqProgram();
            slp.SortingOperation();

            Console.WriteLine("...................................");
            Console.WriteLine("linq sorting opertions.....");
            LinqSortingOperation ls = new LinqSortingOperation();
             ls.OrderStudentName();

            
            PartionOperator po = new PartionOperator();
            po.partion();

            Console.WriteLine("...................................");
            ArraylistConvertion arl = new ArraylistConvertion();
            arl.castconvertion();

        }

    }
}

