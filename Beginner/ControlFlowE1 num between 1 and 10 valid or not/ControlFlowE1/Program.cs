using System;

namespace ControlFlowE1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            var input = Console.ReadLine();

            int num;

            if(int.TryParse(input, out num) && num <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
