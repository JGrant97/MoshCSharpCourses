using System;
using System.Globalization;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new Nullable<int>();
            Console.WriteLine("Has value? " + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());
        }
    }
}
