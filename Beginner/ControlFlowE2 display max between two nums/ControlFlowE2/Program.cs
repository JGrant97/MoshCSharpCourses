using System;

namespace ControlFlowE2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            var num1 = Convert.ToInt32(Console.ReadLine());
            var num2 = Convert.ToInt32(Console.ReadLine());

            var result = Math.Max(num1, num2);


            Console.WriteLine(result);
        }
    }
}
