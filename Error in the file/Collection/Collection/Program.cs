using System;

namespace Collection
{
    class ProgramCollection
    {
        static void Main(string[] args)
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

           

            Array coll = new Array();
            coll.CollectionsS();

        }
    }
}
