using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

class CQ_EnqueueDequeuePeek
{
    
    static void Main()
    {
        //creating  instance for ConcurrentQueue collection.
        ConcurrentQueue<int> cq = new ConcurrentQueue<int>();

        //adding an item into cq
        for (int i = 0; i < 10000; i++)
        {
            cq.Enqueue(i);
        }

        
        int result;
        if (!cq.TryPeek(out result))
        {
            Console.WriteLine("CQ: TryPeek failed when it should have succeeded");
        }
        else if (result != 0)
        {
            Console.WriteLine("CQ: Expected TryPeek result of 0, got {0}", result);
        }

        int outerSum = 0;
        
        Action action = () =>
        {
            int localSum = 0;
            int localValue;
            while (cq.TryDequeue(out localValue)) localSum += localValue;
            Interlocked.Add(ref outerSum, localSum);
        };

        //concurrently consuming an action
        Parallel.Invoke(action, action, action, action);

        Console.WriteLine("outerSum = {0}, should be 49995000", outerSum);
    }
}