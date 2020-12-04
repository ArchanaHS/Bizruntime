using System;

namespace Classdeclaration
{
    public class Myclass

    {
        public string myfield = string.Empty;

        public Myclass()
        {

        }
        public void Mymethod(int parameter1, string parameter2)
        {
            Console.WriteLine("First Parameter {0}, second parameter {1}",
                                                    parameter1, parameter2);
        }

        public int MyAutoImplementedProperty { get; set; }

        private int myPropertyVar;

        public int MyProperty
        {
            get { return myPropertyVar; }
            set { myPropertyVar = value; }
        }

        static void Main(string[] args)
        {
            Myclass obj = new Myclass();
            obj.Mymethod(10, "hello");
        }
    }
}

