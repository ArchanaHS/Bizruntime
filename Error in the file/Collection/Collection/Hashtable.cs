using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class SimpleHashTable
    {
        public void HashT()
        {
            // Creates and initializes a new Hashtable.
            SimpleHashTable HT = new SimpleHashTable();
            HT.HashT();
            var myHT = new Hashtable();
            myHT.Add("one", "The");
            myHT.Add("two", "quick");
            myHT.Add("three", "brown");
            myHT.Add("four", "fox");

            // Displays the Hashtable.
            Console.WriteLine("============================");
            Console.WriteLine("Htable:");
            Console.WriteLine("The Hashtable contains the following:");
            PrintKeysAndValues(myHT);

        }

        public static void PrintKeysAndValues(Hashtable myHT)
        {
            Console.WriteLine("\t-KEY-\t-VALUE-");
            foreach (DictionaryEntry de in myHT)
                Console.WriteLine($"\t{de.Key}:\t{de.Value}");
            Console.WriteLine();
        }
    }
}
