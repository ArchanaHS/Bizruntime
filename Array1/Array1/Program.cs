using System;

namespace Array1
{
    class ArrayApllication
    {  
        static void Main(string[] args)
        {
           
            int[] n = new int[10];
            //array object
               //  n is array of 10 digits.

            //initialize elements of array n.
            for (int i = 0; i < 5; i++) 
                n[i] = i + 100;

            //output each array element value.
            //The in keyword used along with foreach loop is used to iterate over the iterable-item.
            foreach (int j in n)
            {
                int i = j - 100;
                Console.WriteLine(" Element[{0}]={1}",i,j);
            }
            Console.ReadKey();
        }
       
    }
}
