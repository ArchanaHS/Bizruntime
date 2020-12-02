using System;
using System.Collections.Generic;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {



            //Array and arraylist.
            // fixed size <-> variable size.
            // not possible to insert an item <-> possible to instert an item.
            //not possible to delete an item  <-> possible to delete an item.

            //if we want to declare an arraylist means we have to call namespace called System.Collection.

            //creating a list of string.
            var salmons = new List<string>();
            salmons.Add("abc\n");
            salmons.Add("def\n");
            salmons.Add("ghi\n");

            //iterate through the list.
            foreach (var salmon in salmons)
            {
                Console.Write(salmon + "");
            }
        }
    }
}

