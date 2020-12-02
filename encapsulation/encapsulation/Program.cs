using System;

namespace MyApplication
{
    class Program
    {

        static void Main(string[] args)
        {
            Person myObj = new Person();//creating an object.
            myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);
        }
    }

    class Person
    {
        private string name;//member

  // field hide from other function or object.
        public string Name    // property
        {
            get { return name; }
            set { name = value; }
        }
    }
}
