using System;

namespace MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new[] {3, 7, 9, 2, 14, 6 };

            //Length
            Console.WriteLine("Length: "+number.Length);

            //InfexOf()
            var index = Array.IndexOf(number, 9);
            Console.WriteLine("Index of 9: "+index);

            //CLear()
            Array.Clear(number, 0, 2);

            Console.WriteLine("Effect of Clear()");
            foreach(var n in number)
            {
                Console.WriteLine(n);
            }

            //Copy()
            int[] another = new int[3];
            Array.Copy(number,another, 3);
            Console.WriteLine("Effect of Copy()");
            foreach (var n in another)
            {
                Console.WriteLine(n);
            }

            //Sort()
            Array.Sort(number);
            Console.WriteLine("Effect of Sort()");
            foreach (var n in number)
            {
                Console.WriteLine(n);
            }

            //Reverse()
            Array.Reverse(number);
            Console.WriteLine("Effect of Reverse()");
            foreach (var n in number)
            {
                Console.WriteLine(n);
            }

        }
    }
}
