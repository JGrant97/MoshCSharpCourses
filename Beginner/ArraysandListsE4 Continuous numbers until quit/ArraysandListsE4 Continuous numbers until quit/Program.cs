using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysandListsE4_Continuous_numbers_until_quit
{
    class Program
    {
        static void Main(string[] args)
        {
            var entNum = true;
            var numList = new List<int>();

            while (entNum == true)
            {
                Console.WriteLine("Please enter a number");
                var input = Console.ReadLine();

                if(input.Any(Char.IsDigit))
                {
                    int numInput = Convert.ToInt32(input);
                    numList.Add(numInput);
                }
                else if (input == "Quit" || input == "quit")
                {
                    List<int> unique = numList.Distinct().ToList();
                    unique.Sort();

                    Console.WriteLine("Unique values entered");
                    foreach (var num in unique)
                    {
                        Console.WriteLine("\n"+num);
                    }    
                    entNum = false;
                }
            }
        }
    }
}
