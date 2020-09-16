using System;
using System.Collections.Generic;
using System.Linq;

namespace WorkingWithTextE2_Duplicate_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 5 numbers seperated by a hyphen e.g. 1-2-3-4-5");
            var input = Console.ReadLine();

            if (String.IsNullOrEmpty(input))
            {
               Environment.Exit(0);
            }
            else if (isDuplicate(input) == true)
            {
                Console.WriteLine("Contains duplicates");
            }
            else
            {
                Console.WriteLine("\nYou entered");
                foreach(var num in SplitNumbers(input))
                {
                    Console.WriteLine(Convert.ToInt32(num));
                }
            }
        }
        public static List<int> SplitNumbers(String input)
        {
            var splitNumbers = new List<int>();
            foreach (var num in input.Split('-'))
            {
                splitNumbers.Add(Convert.ToInt32(num));
            }
            return splitNumbers;
        }
        public static bool isDuplicate(String input)
        {
            var splitNumbers = SplitNumbers(input);
            var Isduplicate = false;
            if (Convert.ToInt32(splitNumbers.Count) != Convert.ToInt32(splitNumbers.Distinct().Count()))
            {
                Isduplicate = true;
            }
            else
            {
                Isduplicate = false;
            }

            return Isduplicate;
        }
    }
}
