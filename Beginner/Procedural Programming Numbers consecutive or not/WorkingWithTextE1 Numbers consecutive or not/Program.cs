using System;
using System.Collections.Generic;
using System.Linq;

namespace WorkingWithTextE1_Numbers_consecutive_or_not
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 5 numbers seperated by a hyphen e.g. 1-2-3-4-5");
            var input = Console.ReadLine();

            if(IsConsecutive(input) == true)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not consecutive");
            }
        }

        public static bool IsConsecutive (string input)
        {
            var splitNumbers = input.Split('-');
            int numIdex = Convert.ToInt32(splitNumbers[0]);
            var cons = true;

            for (var i = 1; i < splitNumbers.Length; i++)
            {
                if (Convert.ToInt32(splitNumbers[i]) - i != numIdex && Convert.ToInt32(splitNumbers[i]) + i != numIdex)
                {
                    cons = false;
                    break;
                }
            }
            return cons;
        }
    }
}
