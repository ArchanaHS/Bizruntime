using System;
using System.IO;

namespace DirectoryinfoOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"F:\javatpoint");
            try
            {

                if (directory.Exists)
                {
                    Console.WriteLine("Directory already exist.");
                    return;
                }
                // Creating a new directory.  
                directory.Create();
                //Delete directory.
                //directory.Delete()'
                Console.WriteLine("The directory is created successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Directory not created: {0}", e.ToString());
                Console.WriteLine("Directory not created: {0}", e.ToString());
            }
        }
    }

}