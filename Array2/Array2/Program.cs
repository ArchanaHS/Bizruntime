using System;

namespace Array2
{
    class Array
    {
        static void Main(string[] args)
        {
            char[] array = { 'H', 'e', 'l', 'l', 'o' };
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
