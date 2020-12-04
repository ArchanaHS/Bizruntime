using System;

namespace MultipleInterface
{
    class InterfaceProgram
    {
         interface Ifile
        {
            void ReadFile();
        }
        interface IBinaryFile
        {
            void OpenBinaryFile();
            void ReadFile();
        }
        class FileInfo : Ifile, IBinaryFile
        {
            void Ifile.ReadFile()
            {
                Console.WriteLine("reading a text");

            }
            void IBinaryFile.OpenBinaryFile()
            {
                Console.WriteLine("opening binary file");
            }
            void IBinaryFile.ReadFile()
            {
                Console.WriteLine("Reading a text");
            }

            public void Search(string text)
            {
                Console.WriteLine("searching a file");
            }
        }
        public void method()
        {
            Ifile file1 = new FileInfo();
            IBinaryFile file2 = new FileInfo();
            FileInfo file3 = new FileInfo();

            file1.ReadFile();

            file2.OpenBinaryFile();
                file2.ReadFile();

            file3.Search("text to be searched..");
        }
        static void Main(string[] args)
        {
            InterfaceProgram itr = new InterfaceProgram();
            itr.method();
        }
    }
}
