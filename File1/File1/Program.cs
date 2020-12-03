using System;
using System.IO;

namespace File1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               using(var sr= new StreamReader("text.txt"))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine("The file could not be found..");
                Console.WriteLine(e.Message);
            }
            }
        }
    }
