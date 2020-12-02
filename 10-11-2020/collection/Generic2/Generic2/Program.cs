using System;

namespace Generic2
{
    class GenericProgram
    {
       
        
        static void Main(string[] args)
        {
            //creating object for printer class.
            Printer prt = new Printer();

            prt.Print<int> (100);
            prt.Print(200);// type infer

            prt.Print<string>("Hello");
            prt.Print("World!");

        }
    }
    class Printer
    {
        //Generic Method.
        public void Print<T>(T data)
        {
            Console.WriteLine(data);
        }
    }
}
  