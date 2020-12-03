using System;
using System.Collections.Concurrent;

class ConcurrentDicFunction
{
   
    public void Dictionary()
    {
        int NUMITEMS = 64;
        int initialCapacity = 101;

        int numProcs = Environment.ProcessorCount;
        int concurrencyLevel = numProcs * 2;

       //creating concurrentDictionary instance with arguments.
        ConcurrentDictionary<int, int> cd = new ConcurrentDictionary<int, int>(concurrencyLevel, initialCapacity);

        //initializing dictionary.
        for (int i = 0; i < NUMITEMS; i++)
            cd[i] = i * i;

        Console.WriteLine("The square of 23 is {0} (should be {1})", cd[23], 23 * 23);

    }
    static void Main()
    {
        ConcurrentDicFunction cd = new ConcurrentDicFunction();
        cd.Dictionary();


    }
}