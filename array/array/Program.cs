using System;

namespace arrayApplication
{
    class Array
    {
        static void Main(string[] args)
        {
            
            int [] n = new int[10];
            //array object.
            //n is a array of 10 digits.
            int i, j;

            //initialize element of an array
            for ( i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }
            //outputs the each element of an array.
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}]={1}", j, n[j]);

            }
           
            Console.ReadKey();
        }
    }
}
