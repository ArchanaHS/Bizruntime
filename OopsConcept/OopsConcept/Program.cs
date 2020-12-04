using System;

namespace OopsConcept
{
    class OopsProgram
    {
        static void Main(string[] args)
        {

            var b = new Inheritance.B();
            Console.WriteLine(b.GetValue());

            Person obj = new Person();
            obj.Name = "Ram";
            Console.WriteLine();

        }
}
}
