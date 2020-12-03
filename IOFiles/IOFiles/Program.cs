using System;
using System.IO;

using System.Text;


namespace IOFiles
{
    class IOProgram
    {
        public void Method()
        {
            DirectoryInfo df = new DirectoryInfo(".");
            DirectoryInfo derekdir = new DirectoryInfo(@"\Users\derecbans");

            Console.WriteLine(derekdir.FullName);
            Console.WriteLine(derekdir.Name);
            Console.WriteLine(derekdir.Parent);
            Console.WriteLine(derekdir.Attributes);
            Console.WriteLine(derekdir.CreationTime);


            DirectoryInfo Datedir = new DirectoryInfo(@"C:\Users\hp\Desktop\Bizruntime\17-11-2020\File IO");

            string[] customers =
            {
                "Bob Smith",
                "Sally Smith",
                "Robert Smith"
            };
            string TextfilePath = @"C:\Users\hp\Desktop\Bizruntime\17-11-2020\File IO\textfile1.txt";
            File.WriteAllLines(TextfilePath, customers);

            foreach (string cust in File.ReadAllLines(TextfilePath))
            {
                Console.WriteLine("$Customers :{cust}");
            }

            DirectoryInfo myDatadir = new DirectoryInfo(@"C:\Users\hp\Desktop\Bizruntime\17-11-2020\File IO\c#");

            FileInfo[] txtFiles = myDatadir.GetFiles("*.txt", SearchOption.AllDirectories);
            Console.WriteLine("Matches:{0}", txtFiles.Length);


            foreach (FileInfo file in txtFiles)
            {
                Console.WriteLine(file.Name);
                Console.WriteLine(file.Length);
            }
            string textFilePath2 = @"C:\Users\hp\Desktop\Bizruntime\17-11-2020\File IO\c#";
            FileStream fs = File.Open(textFilePath2,FileMode.Create);

            string RandString = "This is Random string";
            byte[] rsByteArray = Encoding.Default.GetBytes(RandString);


            fs.Write(rsByteArray, 0, rsByteArray.Length);
            fs.Position=0;

            byte[] FileByteArray = new byte[rsByteArray.Length];

            for ( int i = 0; i< rsByteArray.Length; i++){
                FileByteArray[i] = (byte)fs.ReadByte();

            }
            Console.WriteLine(Encoding.Default.GetString(FileByteArray));
            fs.Close();
            Console.ReadLine();

        }
        static void Main(string[] args)
        {
            IOProgram iop = new IOProgram();
            iop.Method();
            

        }
    }
}




