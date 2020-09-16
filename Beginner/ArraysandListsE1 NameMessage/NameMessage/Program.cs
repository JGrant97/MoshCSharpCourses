using System;
using System.Collections.Generic;
using System.Linq;

namespace NameMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            var entName = true;
            var names = new List<string>();

            while (entName == true)
            {
                Console.WriteLine("Please enter a name!");
                var input = Console.ReadLine();

                if(!string.IsNullOrEmpty(input))
                {
                    names.Add(input);
                }
                else if (string.IsNullOrEmpty(input))
                {
                    var amount = names.Count;
                    if (amount == 0)
                    {
                        Console.WriteLine("No one liked your post");
                    }
                    else if (amount == 1)
                    {
                        Console.WriteLine("{0} liked your post", names.ElementAtOrDefault(0));
                    }
                    else if (amount == 2)
                    {
                        Console.WriteLine("{0} and {1} liked your post", names.ElementAt(0), names.ElementAt(1));
                    }
                    else if (amount >= 3)
                    {
                        Console.WriteLine("{0}, {1} and {2} other/s liked your post", names.ElementAt(0), names.ElementAt(1), amount -2);
                    }
                    entName = false;
                }
            }
        }
    }
}
