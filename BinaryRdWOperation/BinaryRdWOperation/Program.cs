using System;
using System.IO;

namespace BinaryRdWOperation
{
    class Program
    {
        public static void WriteBinary()
        {
            string fileName = "e:\\binaryfile.dat";
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                writer.Write(2.5);
                writer.Write("this is string data");
                writer.Write(true);
            }
            Console.WriteLine("Data written successfully...");
        }
        public static void ReadBinary()
        {
            using (BinaryReader rd = new BinaryReader(File.Open("e:\\binaryfile.dat", FileMode.Open)))
            {
                Console.WriteLine("Double Value : " + rd.ReadDouble());
                Console.WriteLine("String Value : " + rd.ReadString());
                Console.WriteLine("Boolean Value : " + rd.ReadBoolean());
            }

        }
        static void Main(string[] args)
        {
            WriteBinary();
            ReadBinary();

        }
    }
    }

