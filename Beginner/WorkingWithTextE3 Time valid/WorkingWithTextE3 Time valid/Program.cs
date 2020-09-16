using System;
using System.Globalization;

namespace WorkingWithTextE3_Time_valid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a 24 hour time");
            var time = Console.ReadLine();

            DateTime hour;
            string[] timeFormat = new[] {"HH:mm"};
            if (!DateTime.TryParseExact(time,
                            timeFormat,
                            CultureInfo.InvariantCulture,
                            DateTimeStyles.None,
                            out hour) || String.IsNullOrEmpty(time))
            {
                Console.WriteLine("Invalid time");
            }
            else
            {
                Console.WriteLine("Ok");
            }

        }
    }
}
