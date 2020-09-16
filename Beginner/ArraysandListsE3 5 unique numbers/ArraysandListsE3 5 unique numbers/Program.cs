using System;
using System.Collections.Generic;

namespace ArraysandListsE3_5_unique_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
          
            var numList = new List<int>();
            var enterNum = true;

           

            while (enterNum == true)
            {
                Console.WriteLine("Please enter 5 unique numbers.");
                var number = Convert.ToInt32(Console.ReadLine());

                if (numList.Contains(number))
                {
                    
                    Console.WriteLine("Error: you have already used this number. Please try again!");
                }

                if (!numList.Contains(number))
                {
                    numList.Add(number);
                }

                if (numList.Count == 5)
                {
                    numList.Sort();
                    Console.WriteLine("\nYour numbers sorted");
                    foreach (int num in numList)
                    {
                        Console.WriteLine(num);
                    }
                    enterNum = false;
                }
            }
        }
    }
}
