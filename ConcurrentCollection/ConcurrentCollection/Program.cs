using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

class BlockingCollectionDemo
{
    static async Task Main()
    {
        await AddTakeDemo.BC_AddTakeCompleteAdding();
        TryTakeDemo.BC_TryTake();
        FromToAnyDemo.BC_FromToAny();

        await ConsumingEnumerableDemo.BC_GetConsumingEnumerable();
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
class AddTakeDemo
{
    //add,task,completeadding method is demonstrating.
    public static async Task BC_AddTakeCompleteAdding()
    {
        using (BlockingCollection<int> bc = new BlockingCollection<int>())
        {
            //creating task t1.storing some value.
            Task t1 = Task.Run(() =>
            {
                bc.Add(1);
                bc.Add(2);
                bc.Add(3);
                bc.CompleteAdding();
            });

            // creating task t2.
            Task t2 = Task.Run(() =>
            {
                try
                {
                    
                    while (true) 
                        Console.WriteLine(bc.Take());
                }
                catch (InvalidOperationException)
                {
                    
                    Console.WriteLine("That's All!");
                }
            });

            await Task.WhenAll(t1, t2);
        }
    }
}

class TryTakeDemo
{
 
    //add,complteadding,tryTake,iscomplete is demonstrating
    public static void BC_TryTake()
    {
  
        using (BlockingCollection<int> bc = new BlockingCollection<int>())
        {
            int NUMITEMS = 10000;
            for (int i = 0; i < NUMITEMS; i++) bc.Add(i);
            
            bc.CompleteAdding();
            int outerSum = 0;

            
            Action action = () =>
            {
                int localItem;
                int localSum = 0;

                while (bc.TryTake(out localItem)) localSum += localItem;
                //tryTake-> try remove item from blocking collection.
                Interlocked.Add(ref outerSum, localSum);
            };

            
            Parallel.Invoke(action, action, action);

            Console.WriteLine("Sum[0..{0}) = {1}, should be {2}", NUMITEMS, outerSum, ((NUMITEMS * (NUMITEMS - 1)) / 2));
            Console.WriteLine("bc.IsCompleted = {0} (should be true)", bc.IsCompleted);
        }
    }
}

class FromToAnyDemo
{
   
    public static void BC_FromToAny()
    {
        BlockingCollection<int>[] bcs = new BlockingCollection<int>[2];

        bcs[0] = new BlockingCollection<int>(5); // collection bounded to 5 items
        bcs[1] = new BlockingCollection<int>(5); 

        //add an element
        int numFailures = 0;
        for (int i = 0; i < 10; i++)
        {
            if (BlockingCollection<int>.TryAddToAny(bcs, i) == -1) numFailures++;
        }
        Console.WriteLine("TryAddToAny: {0} failures (should be 0)", numFailures);

        //retrive an element.
        int numItems = 0;
        int item;
        while (BlockingCollection<int>.TryTakeFromAny(bcs, out item) != -1) numItems++;
        Console.WriteLine("TryTakeFromAny: retrieved {0} items (should be 10)", numItems);
    }
}

class ConsumingEnumerableDemo
{
    
    public static async Task BC_GetConsumingEnumerable()
    {
        using (BlockingCollection<int> bc = new BlockingCollection<int>())
        {
            
            await Task.Run(async () =>
            {
                for (int i = 0; i < 10; i++)
                {
                    bc.Add(i);
                    await Task.Delay(100); 
                }

                
                bc.CompleteAdding();
            });

            
            foreach (var item in bc.GetConsumingEnumerable())
            {
                Console.WriteLine(item);
            }
        }
    }
}