using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class LinkedListCollection
    {
        private LinkedListNode<string> current;

        public LinkedListNode<string> Current { get; private set; }

        public void Method5()
        {
            var names = new LinkedList<string>();
            names.AddLast("Sonoo Jaiswal");
            names.AddLast("Ankit");
            names.AddLast("Peter");

            
            names.AddLast("Irfan");
            names.AddFirst("John");//added to first index  

           
            names.RemoveLast();


            LinkedListNode<String> node = names.Find("Peter");
            names.AddBefore(node, "John");
            names.AddAfter(node, "Lucy");
            // Iterate list element using foreach loop  
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
