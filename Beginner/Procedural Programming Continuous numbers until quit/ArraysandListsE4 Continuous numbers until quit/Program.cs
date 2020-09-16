using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysandListsE4_Continuous_numbers_until_quit
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Please enter a number or type quit to exit");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }

                numbers.Add(Convert.ToInt32(input));
            }

            Console.WriteLine("\nUnique values: ");
            foreach(var num in GetUniqueNumbers(numbers))
            {
                Console.WriteLine(num);
            }
        }

        public static List<int> GetUniqueNumbers(List<int> numbers)
        {
            var unique = new List<int>();
            foreach (var num in numbers)
            {
                if (!unique.Contains(num))
                {
                    unique.Add(num);
                }
            }
            unique.Sort();

            return unique;
        }
    }
}
