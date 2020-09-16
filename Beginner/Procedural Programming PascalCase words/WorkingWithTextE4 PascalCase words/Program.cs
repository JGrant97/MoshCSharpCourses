using System;
using System.Collections.Generic;
using System.Linq;

namespace WorkingWithTextE4_PascalCase_words
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some words seperated by a space.");
            var input = Console.ReadLine();

            var pascal = TextUtility.Pascalcase(input);
            Console.WriteLine("\nYour word in pascal case: " + pascal);
        }
    }
}
