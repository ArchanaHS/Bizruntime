using System;

namespace DynamicType
{
    class DynamicProgram
    {
        static void method()
        {
            dynamic mydynamicVar = 100;
            Console.WriteLine("value: {0}, Type:{1}", mydynamicVar, mydynamicVar.GetType());

            dynamic mydynamicVar1 = "Hello World!..";
            Console.WriteLine("value: {0}, Type:{1}", mydynamicVar1, mydynamicVar1.GetType());
            dynamic mydynamicVar2= true;
            Console.WriteLine("value: {0}, Type:{1}", mydynamicVar2, mydynamicVar2.GetType());
            dynamic mydynamicVar3 = DateTime.Now;
            Console.WriteLine("value: {0}, Type:{1}", mydynamicVar3, mydynamicVar3.GetType());
        }
        static void Main(string[] args)
        {
            method();
        }
    }
}
