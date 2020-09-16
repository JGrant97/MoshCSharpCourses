using System;
using System.Collections.Generic;
using System.Linq;

namespace ControlFlowE9_Max_num
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a series of number. i.e. 1,2,3,4");
            var input = Console.ReadLine();
            var segments = new List<int>();
            segments = input.Split(',').Select(Int32.Parse).ToList();

            int max = segments.Max();
            Console.WriteLine(max);
        }
    }
}
