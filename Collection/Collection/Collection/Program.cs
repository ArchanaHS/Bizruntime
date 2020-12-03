using System;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //List
            Console.WriteLine("List....");

            ListCollection lst = new ListCollection();
            lst.Method();
            Console.WriteLine("..........................................");
            Console.ReadKey();

            //HashSet
            Console.WriteLine("HashSet....");
            HashSetCollection hst = new HashSetCollection();
            hst.Method1();
            Console.WriteLine("..........................................");
            Console.ReadKey();

            //SorttedSet
            Console.WriteLine("SortedSet.......");
            SortedSetCollection src = new SortedSetCollection();
            src.Method2();
            Console.WriteLine("..........................................");
            Console.ReadKey();

            //stack..
            Console.WriteLine("Stack............");
            StackCollection sc = new StackCollection();
            sc.Method3();
            Console.WriteLine("..........................................");
            Console.ReadKey();

            //queue
            Console.WriteLine("Queue............");
            QueueCollection qc = new QueueCollection();
            qc.Method4();
            Console.WriteLine("..........................................");
            Console.ReadKey();

            //LinkedList
            Console.WriteLine("LinkedList.........");
            LinkedListCollection lc = new LinkedListCollection();
            lc.Method5();
            Console.WriteLine("..........................................");
            Console.ReadKey();

            //Dictionary
            Console.WriteLine("Dictionary........");
            DictionaryCollection dc = new DictionaryCollection();
            dc.Method6();
            Console.WriteLine("..........................................");
            Console.ReadKey();

            //Sorted Dictionary
            Console.WriteLine("Sorted Dictionary...");
            SortedDictionaryCollection sdc = new SortedDictionaryCollection();
            sdc.Method7();
            Console.WriteLine("..........................................");
            Console.ReadKey();

            //SortedList
            Console.WriteLine("Sorted List.....");
            SortedListColection slc = new SortedListColection();
            slc.Method8();
            Console.WriteLine("..........................................");
            Console.ReadKey();

            //Arraylist
            Console.WriteLine("ArrayList...");
            ArrayListCollection arc = new ArrayListCollection();
            arc.Method9();
            Console.WriteLine("..........................................");
            Console.ReadKey();


            //HashTable.
            Console.WriteLine("Hashtable...");
            HashTableCollection hsc = new HashTableCollection();
            hsc.Method10();
            Console.WriteLine("..........................................");
            Console.ReadKey();




        }
    }
}
