using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
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
}
