using System;

namespace Indexer
{
    class IndexProgram
    {
       
        static void Main(string[] args)
        {
                StringDataStore strStore = new StringDataStore();
                //creating an instance for class StringDataStore.

                strStore[0] = "One";
                strStore[1] = "Two";
                strStore[2] = "Three";
                strStore[3] = "Four";
                strStore[4] = "Five";
                strStore[5]= "six"

                for (int i = 0; i < 10; i++)
                    Console.WriteLine(strStore[i]);

             }
        }
    public class StringDataStore
    {
        private string[] strArr = new string[10];
	//class StringDataStore Defines the private strArr array.
        public string this[int index]
        {
            get
            {
                 if (index < 0 || index >= strArr.Length)

                    throw new IndexOutOfRangeException("Cannot store more than 10 objects");

                    return strArr[index];
            }

            set
            {
                if (index < 0 || index >= strArr.Length)

                    throw new IndexOutOfRangeException("Cannot store more than 10 objects"); 

                    strArr[index] = value;
            }
        }
    }
}
