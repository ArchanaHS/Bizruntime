using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class ICollection
    {
        public void CollectionsS()
        {
            string[] monthsofYear =
            {
                    "January",
                    "February",
                    "March",
                    "April",
                    "May",
                    "June",
                    "July",
                    "August",
                    "September",
                    "October",
                    "November",
                    "December"
                };

            Console.WriteLine("================================");

            ICollection<string> collection = monthsofYear;
            (collection as string[])[2] = "Financial Month";
            if (!collection.IsReadOnly)
            {
                collection.Add("Financials");
            }
            else
            {
                Console.WriteLine("readonly collection");
            }
            foreach (var month in collection)
            {
                Console.WriteLine(month);
            }

            Console.ReadLine();

        }
    }
}
