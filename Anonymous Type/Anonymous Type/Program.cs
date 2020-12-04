using System;

namespace Anonymous_Type
{
    class TypeProgram
    {
        private void method()
        {
            var student = new { id = 1, FirstName = "Ajay", SecondName = "Kumar" };
            Console.WriteLine(student.id);
            Console.WriteLine(student.FirstName);
            Console.WriteLine(student.SecondName);
        }



        class NestedAnonymous
        {
            static void method1()
            {
                //Nested Anonymus Type.
                var student1 = new
                {
                    id = 2,
                    FirstName = "vijay",
                    SecondName = "Kumar",
                    Address = new { id = 1, city = "banglore", country = "India" }
                };
                Console.WriteLine(student1.id);
                Console.WriteLine(student1.FirstName);
                Console.WriteLine(student1.SecondName);
                Console.WriteLine(student1.Address);
            }


            static void Main(string[] args)
            {
                TypeProgram obj = new TypeProgram();
                obj.method();
                // NestedAnonymous nst = new NestedAnonymous();
                method1();






            }
        }
    }
}

