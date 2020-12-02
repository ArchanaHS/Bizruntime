using System;

namespace Abstraction
{
   abstract class Animal//abstract class
    {
        public abstract void Animalsound();//abstract method.

        public void sleep()
        {
            Console.WriteLine("Zzzz");
        }
        //inheritance.
        class pig : Animal
        {
            public override void Animalsound()
                
            {
                Console.WriteLine("pig says: wee wee");
            }
        }
        class program
        {
            static void Main(string[] args)
            {
                pig mypig = new pig();//object declaration.
                mypig.Animalsound();//calling method.
                mypig.sleep();
            }
        }
    }
}
