using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace FileInfoDirectory
{
    public class CopyDirectory

    {


        public static void CopyAll(DirectoryInfo source, DirectoryInfo Target)
        {

            try
            {
                if (source.FullName.ToLower() == Target.FullName.ToLower())
                {
                    return;
                }
                if (Directory.Exists(Target.FullName) == false)
                {
                    Directory.CreateDirectory(Target.FullName);
                }


                foreach (FileInfo fi in source.GetFiles())
                {
                    Console.WriteLine(@"coping :{0}\{1}", Target.FullName, fi.Name);
                    fi.CopyTo(Path.Combine(Target.ToString(), fi.Name), true);
                }
                foreach (DirectoryInfo diSourceSubDirectory in source.GetDirectories())
                {
                    DirectoryInfo NextTargetSubDir = Target.CreateSubdirectory(diSourceSubDirectory.Name);
                    CopyAll(diSourceSubDirectory, NextTargetSubDir);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Cannot find the directory..");
            }
        }
        static void Main()
        {

            string sourceDirectory = @"c:\sourceDirectory";
            string targetDirectory = @"c:\targetDirectory";
            DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
            DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);

            CopyAll(diSource, diTarget);
        }
    }
}

