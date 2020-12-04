using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
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
            Console.WriteLine("dequeue: {0}", myQ.Dequeue());
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
}
