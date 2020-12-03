using System;
using System.Collections;

namespace Collection
{
    class ArrayListCollection
    {
        public void Method9()
        {
            var arlist1 = new ArrayList();
            Console.WriteLine(arlist1.Capacity);
            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);
            Console.WriteLine("Count: {0}", arlist1.Count);

            // adding elements using object initializer syntax
            var arlist2 = new ArrayList()
                    {
                        2, "Steve", true, 4.5, null
                    };

            Console.WriteLine("ArrayList 1 Elements");
            for (int i = 0; i < arlist1.Count; i++)
                Console.WriteLine(arlist1[i]);

            Console.WriteLine("ArrayList 2 Elements");

            for (int i = 0; i < arlist2.Count; i++)
                Console.WriteLine(arlist2[i]);

            //Access individual item using indexer
            int firstElement = (int)arlist1[0];
            string secondElement = (string)arlist1[1];

            //update elements
            arlist1[0] = "Steve";
            arlist1[1] = 100;

            arlist1.Insert(1, "Second Item");

            foreach (var val in arlist1)
                Console.WriteLine(val);
            //remove
            arlist1.Remove(null); //Removes first occurance of null
            arlist1.RemoveAt(4);

            Console.WriteLine(arlist1.Contains("Bill")); // true
            Console.WriteLine(arlist1.Contains(10));
        }
    }
    }

