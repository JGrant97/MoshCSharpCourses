using System;

namespace WorkingWithTextE5_VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word.");
            var input = Console.ReadLine();
            var vowelCout = 0;

            foreach (char c in input)
            {
                if (c.ToString().Contains("a") || c.ToString().Contains("e") || c.ToString().Contains("i") || c.ToString().Contains("o") || c.ToString().Contains("u"))
                {
                    vowelCout++;
                }
            }

            Console.WriteLine("\nYour word contained {0} vowels ", vowelCout);
        }
    }
}
