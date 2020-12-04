using System;
using System.Collections.Generic;
using System.Text;

namespace Program1
{
    public delegate void hellofunction(string message);
    //delegates is a function that points to the similar signature of the method.
    //to point to the other method it will tale return type of function d its parameter.
    //can create delegate instance.
    public class Delegatess
    {
        public static void hello(string strmessage)
        {
            Console.WriteLine(strmessage);
        }

        public static void Main(string[] args)
        {
            hellofunction hf = new hellofunction(hello);
            hf("hello from delegates");

        }
    }
}
