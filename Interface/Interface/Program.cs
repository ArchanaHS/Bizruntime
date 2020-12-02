using System;

namespace Interface

{
    //interface
    interface Firstinterface
    {
        void mymethod();//method interface
    }
    interface Secondinterface
    {
        void myothermethod();//method interface
    }
    //implement multiple interface.
    class Democlass : Firstinterface, Secondinterface
    {
        public void mymethod()
        {
            Console.WriteLine("abc");
        }
        public void myothermethod()
        {
            Console.WriteLine("abcd");
        }
        class program
        {
            static void Main(string[] args)
            {
                Democlass myobj = new Democlass();//object declaration
                myobj.mymethod();
                myobj.myothermethod();//calling method.
            }
        }

    }
}