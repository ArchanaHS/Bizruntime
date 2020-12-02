
using System;
using System.Collections;
using System.Collections.Generic;


namespace simple
{

    class ProjectCollections
    {

        // Driver code 
        public static void Main()
        {
            // Calling Arraylist
            ArraylistSample arr = new ArraylistSample();
            arr.arrayListTest();

            // Calling Queue
            SimpleQueue nq = new SimpleQueue();
            nq.QueueD();

            // Calling Stack
            SimpleStack sta = new SimpleStack();
            sta.StackD();

            SimpleHashTable HT = new SimpleHashTable();
            HT.HashT();

            Array coll = new Array();
            coll.CollectionsS();

        }

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
                Console.WriteLine(myList);
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

        class SimpleHashTable
        {
            public void HashT()
            {
                // Creates and initializes a new Hashtable.
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
        // QUEUE
        class SimpleQueue
        {
            public void QueueD()
            {
                // create and initialize new queue
                Queue myQ = new Queue();
                myQ.Enqueue("Hello");
                myQ.Enqueue("hello1");
                myQ.Enqueue("!");

                // display the properties and value of the queue.
                Console.WriteLine("Queue:-");
                Console.WriteLine("Count:   {0}" + myQ.Count);
                Console.WriteLine("Values: ");
                PrintValues(myQ);
                //Remove an element from the start.
                Console.WriteLine("dequeue: {0}", myQ.Dequeue());
                Console.WriteLine("Peek at next item to dequeue: {0}",
                myQ.Peek());
                Console.WriteLine("Values:");
                PrintValues(myQ);

                

            }
            public static void PrintValues(IEnumerable myCollection)
            {
                foreach (Object obj in myCollection)
                    Console.WriteLine("   : {0}", obj);
                    Console.WriteLine();

            }


        }
        // STACK
        class SimpleStack
        {
            public void StackD()
            {
                // Creating and initialize new stack
                Stack myStack = new Stack();
                myStack.Push("hello stack1");
                myStack.Push("hello stack2");
                myStack.Push("hello stack3");

                Console.WriteLine("============================");
                Console.WriteLine("Stack:-");
                Console.WriteLine("count: {0}" + myStack.Count);
                Console.WriteLine("values ");
                PrintValues(myStack);
                Console.WriteLine("pop: {0}", myStack.Pop()); //pop the stack element(hello3).
                PrintValues(myStack); //print all stack values.

                Console.WriteLine("peek: {0}", myStack.Peek());
            }
            public static void PrintValues(IEnumerable myCollection)
            {
                foreach (Object obj in myCollection)
                    Console.WriteLine(" {0}", obj);
                Console.WriteLine();

            }
        }
        // ICOLLECTIONS
        internal class Array
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
}



// ICollection-is a write operation,that modify the collections.
//add,remove,clear,isreadonly.

// IEnumerable- it is Read-only operation

