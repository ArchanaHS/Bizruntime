using System;
using System.Collections.Generic;
using System.Text;

namespace Program1
{
    public abstract class customer//abstract class
    {
        int id;
        //abstract class have a field.
        //abstract class by defualt private modifier.
        //can have a access modifier.
        public void print()
        {
            Console.WriteLine("Print..");
        }

    }
    public interface Icustomer
    {
        void print();
        //interface cannot implements its members.
        //interface method by defualt public modifier.
        //not having access modifier.
        //cannot have  a field.
    }
  
}
