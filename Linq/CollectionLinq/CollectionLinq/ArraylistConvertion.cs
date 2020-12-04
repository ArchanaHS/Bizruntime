using System;
using System.Collections.Generic;

using System.Collections;
using System.Linq;

namespace CollectionLinq
{
    class ArraylistConvertion
    {
        public void castconvertion()
        {
            ArrayList obj = new ArrayList();
            obj.Add("Australia");
            obj.Add("India");
            obj.Add("UK");
            obj.Add("USA");
            obj.Add(1);
            obj.Add(3);
            //gives Exception connot convert int to string in cast() method.
                        //converting Arraylist of object into string type of object.
                        // IEnumerable<string> result = obj.Cast<string>();
            IEnumerable<string> result = obj.OfType<string>();
            foreach(var ab in result)
            {
                Console.WriteLine(ab);
            }
            Console.ReadLine();


            int[] numArray = new int[5] { 1, 2, 3, 4, 5 };
            var result1 = numArray.AsEnumerable();
            foreach(var number in result1)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }

    }
}
