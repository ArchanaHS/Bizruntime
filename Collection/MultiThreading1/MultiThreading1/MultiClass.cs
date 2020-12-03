using System;
using System.Collections.Generic;
using System.Text;

namespace MultiThreading1
{
    class MultiClass
    {
        public void Test1()
        {
            for(int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test1 :" + i);
            }
        }
        public void Test2()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test2 :" + i);
            }
        }
        public void Test3()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test3:" + i);
            }
        }
    }
}
