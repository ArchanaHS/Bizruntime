using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class ArraylistSample
    {
        public void arrayListTest()
        {
            ArrayList myList = new ArrayList();
            // Adding elements to ArrayList 
            myList.Add("Hello1");
            myList.Add("World2");
            myList.Add("world3");
            myList.Add("world4");
            myList.Add("world5");

            Console.WriteLine("Count : " + myList.Count);
            Console.WriteLine("Capacity : " + myList.Capacity);

            // To check the arraysize is fixed size or not(IsFixedSize)
            Console.WriteLine("IsFixedSize :" + myList.IsFixedSize);

            // To check the arraylist is read-only or not (IsReadOnly)
            Console.WriteLine("IsReadOnly :" + myList.IsReadOnly);


            myList.Remove("world4"); //remove world4 from the list
            myList.RemoveAt(2); //remove from the index 2(world3)
            myList.RemoveRange(0, 2); //it will remove from index 0-2(first 3)

            Console.WriteLine("Values: ");
            PrintValues(myList);

        }
        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
                Console.Write("   {0}", obj);
            Console.WriteLine();
            Console.WriteLine("===============================");
        }
    }
}
