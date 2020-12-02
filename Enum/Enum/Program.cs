using System;

namespace Enum
{
    class Program
    {
        enum level
        {
            Low,
            Medium,
            High,
        }
        static void Main(string[] args)
        {
            level myVar = level.Medium;
            switch(myVar)
            {
                case level.Low:
                    Console.WriteLine("low level");
                    break;
                case level.Medium:
                    Console.Write("medium level");
                    break;
                case level.High:
                    Console.WriteLine("High level");
                    break;
                    
            }
        }
    }
}
