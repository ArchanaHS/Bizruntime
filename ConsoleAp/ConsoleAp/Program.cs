using System;

namespace ConsoleAp
{
    class Vechicle  //base class
    {
        public string brand = "ford";//field
        public void honk()//method
        {
            Console.WriteLine("Tuuu, tuuu!!!");
        }
        class car:Vechicle//inheritance
        {
            public string modelname = "Mustang";//car field.
        }
        class program
    
    {
        static void Main(string[] args)
        {
                car mycar = new car();//creating an object.
                mycar.honk();//call the method
                Console.WriteLine(mycar.brand+""+mycar.modelname);
        }
    }
}
}
