using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WorkingWithFilesE2_Read_file_display_longest_word
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"D:\My Documents\getmytext.txt";

            if (File.Exists(path))
            {
                var content = File.ReadAllText(path);
                var words = content.Split(' ');

                string longestWord = "";

                foreach(var word in words)
                {
                    if(word.Length > longestWord.Length)
                    {
                        longestWord = word;
                    }
                }

                Console.WriteLine(longestWord);
            }
        }
    }
}
