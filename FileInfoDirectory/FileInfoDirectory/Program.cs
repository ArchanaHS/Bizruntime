using System;
using System.IO;

namespace FileInfoDirectory
{
    class DirectoryinfoProgram
    {
        public void Method()
        {
            DirectoryInfo di = new DirectoryInfo(@"c:\Mydir");
            try
            {
                if (di.Exists)
                {
                    Console.WriteLine("THe path exists already....");
                    return;
                }
                //creating a directory.
                di.Create();
                Console.WriteLine("The directory was created successfully...");

                //delete the directory.
                di.Delete();
                Console.WriteLine("the directory was deleted successfully...");
            }
            catch (Exception e)
            {
                Console.WriteLine("The process Failed :{0}", e.ToString());
            }
            finally { }
        }
        static void Main(string[] args)
        {
            DirectoryinfoProgram df = new DirectoryinfoProgram();
            df.Method();
            
            
        }
    }
}

