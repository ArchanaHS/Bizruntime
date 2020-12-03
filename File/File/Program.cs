using System;
using System.IO;


namespace FilePrograming
{
    class Program
    {
        const string filename = "App.dat";

        static void Main()
        {
            WriteDefaultValue();
            DisplayValue();
        }
        public static void WriteDefaultValue()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(filename,FileMode.Create)))
            {
                writer.Write(1.250F);
                writer.Write(@"c\:Temp");
                writer.Write(10);
                writer.Write(true);
            }
              
        }
        public static void DisplayValue()
        {
            float aspectRatio;
            string tempDirectory;
            int autoSaveTime;
            bool showStatusBar;

            if (File.Exists(filename))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(filename, FileMode.Open)))
                {
                    aspectRatio = reader.ReadSingle();
                    tempDirectory = reader.ReadString();
                    autoSaveTime = reader.ReadInt32();
                    showStatusBar = reader.ReadBoolean();
                }
                Console.WriteLine("Aspect ratio set to:" + aspectRatio);
                Console.WriteLine("Temp directory is:" + tempDirectory);
                Console.WriteLine("Auto save time set:" + autoSaveTime);
                Console.WriteLine("Show status bar:" + showStatusBar);


            }
        }
    }
}
