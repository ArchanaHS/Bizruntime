using System;
//first set of namespace.
namespace first_space
{
   
    class namespace_cl
    {

        public void func()
        {
            Console.WriteLine("Inside first_space");
        }
    }
}
//second set of namespace.
namespace second_space
{

    class namespace_cl
    {

        public void func()
        {
            Console.WriteLine("Inside second_space");
        }
    }
}

class TestClass
{

    static void Main(string[] args)
    {
        first_space.namespace_cl fc = new first_space.namespace_cl();//creating an object 
        second_space.namespace_cl sc = new second_space.namespace_cl();
        fc.func();//calling function
        sc.func();
        Console.ReadKey();
    }
}