using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public delegate void MyDelegate(string msg);

    class DelegateFunction
    {
        public void DelegateProgram()
        {
           
            MyDelegate del = ClassA.MethodA;
            del("Hello World");

            del = ClassB.MethodB;
            del("Hello World");

            del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
            del("Hello World");
            Console.WriteLine("..................");
           // Console.ReadLine();


        }
        

    }
    public class ClassA
    {
        public static void MethodA(string message)
        {
            Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
        }
    }

    public class ClassB
    {
        public static void MethodB(string message)
        {
            Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
        }
    }
    
}
