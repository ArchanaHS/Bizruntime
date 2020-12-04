using System;

namespace Interface
{
    class InterfaceProgram
    {
        public void method()
        {
            Ifile file1 = new FileInfo();
            FileInfo file2 = new FileInfo();

            file1.ReadFile();
            file1.WriteFile("content");

            file2.ReadFile();
            file2.WriteFile("content");
        }
        static void Main(string[] args)
        {
            InterfaceProgram fl = new InterfaceProgram();
            fl.method();
        }
    }
    interface Ifile
    {
        void ReadFile();
        void WriteFile(string text);
    }
    class FileInfo : Ifile
    {
        public void ReadFile()
        {
            Console.WriteLine("reading a file");
        }
        public void WriteFile(string text)
        {
            Console.WriteLine("Writing to file");
        }
    }
}
