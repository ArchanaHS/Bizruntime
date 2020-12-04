using System;
using System.IO;

namespace FileinfoClass
{
    class Program
    {
       

        static void Main(string[] args)
        {
            try
            {

                string loc = "e:\\abc.txt";

                // Creating FileInfo instance  
                FileInfo file = new FileInfo(loc);

                file.Create();
                Console.WriteLine("File is created Successfuly");

                //Writer
                StreamWriter sw = file.CreateText();
                sw.WriteLine("This text is written to the file by using StreamWriter class.");
                sw.Close();
                //reader.
                StreamReader sr = file.OpenText();
                string data = "";
                while ((data = sr.ReadLine()) != null)
                {
                    Console.WriteLine(data);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Something went wrong: " + e);
            }
        }
       
    }
}
