using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            //delegate is a type safe function pointer.
            DelegateFunction df = new DelegateFunction();
            df.DelegateProgram();
            EventFunction ef = new EventFunction();
            ef.EventProgram();
            Console.WriteLine(ef);


        }
    }
}
