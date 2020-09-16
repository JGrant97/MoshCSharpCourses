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

            if (TimeValid(time) == false)
            {
                Console.WriteLine("Invalid time");
            }
            else
            {
                Console.WriteLine("Ok");
            }

        }

        public static bool TimeValid (string time)
        {
            DateTime hour;
            string[] timeFormat = new[] { "HH:mm" };
            var isValid = false;

            if (!DateTime.TryParseExact(time,
                            timeFormat,
                            CultureInfo.InvariantCulture,
                            DateTimeStyles.None,
                            out hour) || String.IsNullOrEmpty(time))
            {
                isValid = false;
            }
            else
            {
                isValid = true;
            }

            return isValid;
        }
    }
}
