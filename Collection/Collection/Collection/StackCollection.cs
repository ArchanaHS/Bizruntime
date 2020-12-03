using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class StackCollection
    {
        public void Method3()
        {
            Stack<string> names = new Stack<string>();
            names.Push("Abhay");
            names.Push("Reshma");
            names.Push("Dev");
            names.Push("vandhan");
            names.Push("kshetra");
            names.Push("vinay");

            
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Peek element:" + names.Peek());
            Console.WriteLine("Pop: " + names.Pop());
            Console.WriteLine("After Pop, Peek element: " + names.Peek());
        }
    }
}
