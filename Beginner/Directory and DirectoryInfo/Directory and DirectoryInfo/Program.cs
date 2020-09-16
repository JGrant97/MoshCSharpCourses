using System;
using System.IO;

namespace Directory_and_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\temp\folder1");

            var files = Directory.GetFiles(@"D:\My Documents\GitHub\C#\tuts\Beginner", "*.sln", SearchOption.AllDirectories);

            foreach(var file in files)
            {
               // Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(@"D:\My Documents\GitHub\C#\tuts\Beginner", "*.*", 
                SearchOption.AllDirectories);

            foreach(var directory in directories)
            {
                Console.WriteLine(directory);
            }

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}
