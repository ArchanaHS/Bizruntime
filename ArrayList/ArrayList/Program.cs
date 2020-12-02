//collection.
//Dynamic class.
//in array we can resize the array by using Array.Resize. 
// if we calling Array.Resize method it will store the new value and destroy the older one.

using System;
using System.Collections;
using System.Collections.Generic;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Auto Resizing
            // there is no size limitation it will keep rezing.
            ArrayList al = new ArrayList(2);
            Console.WriteLine(al.Capacity);
            //The capacity is an property, and which tells the number of an item is stored under Collection.
            al.Add(100);
            Console.WriteLine(al.Capacity);
            al.Add(200);
            al.Add(300);
            al.Add(400);
            Console.WriteLine(al.Capacity);
            al.Add(500);
            Console.WriteLine(al.Capacity);

		
         	Console.WriteLine("Count: {0}", al.Count);
            //count -> gets the number of an element.

            foreach(object obj in al)
                Console.WriteLine(obj + " ");
                Console.WriteLine();

            //inserting an item.
            al.Insert(3, 350);
            foreach (object obj in al)
                Console.WriteLine(obj + " ");
            Console.WriteLine();


            //remove an item,
            //remove by using the value.
            // al.Remove(200);

            // can remove by using a index position also.
            al.RemoveAt(1);
            foreach (object obj in al)
                Console.WriteLine(obj + " ");
            Console.WriteLine();

            al.Sort();
            foreach (object obj in al)
                Console.WriteLine(obj + " ");
            Console.WriteLine();

            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
