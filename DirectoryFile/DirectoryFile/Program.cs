using System;
using System.IO;


namespace DirectoryFile
{
    class DirectoryProgram
    {
        public void DirectoryMethod()
        {
            string sourceDirectory = @"c:current";
            string ArchiveDirectoty = @"c:archive";

            try
            {
                var TextFile = Directory.EnumerateFiles(sourceDirectory, "*.txt");
                foreach(string currentFile in TextFile)
                {
                    string filename = currentFile.Substring(sourceDirectory.Length + 1);
                    Directory.Move(currentFile, Path.Combine(ArchiveDirectoty, filename));
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            DirectoryProgram df = new DirectoryProgram();
            df.DirectoryMethod();
            
        }
    }
}
