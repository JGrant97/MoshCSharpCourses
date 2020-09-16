using System;

namespace ControlFlowE7_Factorial_of_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            var num = Convert.ToInt32(Console.ReadLine());
            var fact = num;

            if(num < 0)
            {
                Console.WriteLine("Please enter a valid number");
            }
            else
            {
                for(int i = num -1; i >= 1; i--)
                {
                    fact = fact * i;
                }
                Console.WriteLine("\nFactorial of {0}! is {1}", num, fact);
            }    
        }
    }
}
