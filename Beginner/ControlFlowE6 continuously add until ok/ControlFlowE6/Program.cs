using System;
using System.Linq;
using System.Collections.Generic;

namespace ControlFlowE6
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var num = 0;
            List<int> numArray = new List<int>();
 
            var i = 1;
            bool isInt = true;
            while (isInt == true)
            {
                Console.WriteLine("Enter a number or type ok to exit and get total");
                var input = Console.ReadLine();

                if (input.Any(Char.IsDigit))
                {
                    num = Convert.ToInt32(input);
                    numArray.Add(num);
                }
                if (input.Equals("ok") || input.Equals("OK"))
                {
                    isInt = false;
                    int total = numArray.Sum();
                    Console.WriteLine("\nExit");
                    Console.WriteLine("\nTotal value is: " + total);
                    break;
                }
                i++;
            }
        }
    }
}
