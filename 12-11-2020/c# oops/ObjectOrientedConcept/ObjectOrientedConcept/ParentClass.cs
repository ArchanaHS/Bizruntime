using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedConcept
{
   public class ParentClass
    { 
        public ParentClass()
        {
            Console.WriteLine("The parent class constructor is calling...");
        }
        public ParentClass(string Message)
        {
            Console.WriteLine(Message);
        }
    }
    public class Childclass : ParentClass
    {
        public Childclass():base("derived class controlling parent class")
        {
            Console.WriteLine("The child class constructor is calling...");
        }
    }
}
