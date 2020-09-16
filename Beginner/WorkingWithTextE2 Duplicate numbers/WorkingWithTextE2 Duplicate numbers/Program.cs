using System;
using System.Linq;

namespace WorkingWithTextE2_Duplicate_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 5 numbers seperated by a hyphen e.g. 1-2-3-4-5");
            var input = Console.ReadLine();
            var splitNumbers = input.Split('-');

            if(Convert.ToInt32(splitNumbers.Length) != Convert.ToInt32(splitNumbers.Distinct().Count()))
            {
                Console.WriteLine("Contains duplicates");
            }
            else if (String.IsNullOrEmpty(input))
            {
               Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("\nYou entered");
                foreach(var num in splitNumbers)
                {
                    Console.WriteLine(Convert.ToInt32(num));
                }
            }
        }
    }
}
