using System;

namespace constuctor
{
    class car
    {
        public string model;//create a feild.

        public car()
        {//create a class constructor

            model = "abcd";//initializing the value.
        }

        static void Main(string[] args)
        {
            car ford = new car();// object of the class is created.(call the constructor.)
            Console.WriteLine(ford.model);
        }
    }
}
