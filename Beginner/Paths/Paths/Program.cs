using System;
using System.IO;

namespace Paths
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"D:\My Documents\GitHub\C#\tuts\Beginner\ControlFlowE4 Speed cam\ControlFlowE4.sln";

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File name: " + Path.GetFileName(path));
            Console.WriteLine("File name without extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory name: " + Path.GetDirectoryName(path));

        }
    }
}
