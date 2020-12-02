using System;

namespace StringConvertion
{
    class stringconvertion { 
    static void Main(string[] args)
    {
        int i = 75;
        float f = 53.005f;
        double d = 2345.7652;
        bool b = true;
            //convertion.
        Console.WriteLine(i.ToString());
        Console.WriteLine(f.ToString());
        Console.WriteLine(d.ToString());
        Console.WriteLine(b.ToString());
            Console.WriteLine(Convert.ToChar(i));
            Console.WriteLine(Convert.ToInt32(f));
        Console.ReadKey();

            
    }
}
}