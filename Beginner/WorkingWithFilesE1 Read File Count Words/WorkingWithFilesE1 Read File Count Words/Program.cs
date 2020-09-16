using System;
using System.IO;

namespace WorkingWithFilesE1_Read_File_Count_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"D:\My Documents\getmytext.txt";
            var wordCount = 0;

            if (File.Exists(path))
            {
                var content = File.ReadAllText(path);

                var words = content.Split(' ');

                foreach (var word in words)
                {
                    wordCount++;
                }

            }

            Console.WriteLine("There are {0} words in this file", wordCount);
        }
    }
}
