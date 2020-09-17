using System;

namespace Classes_Stop_Watch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            Console.WriteLine("Type start to start the stopwatch.");
            var input = Console.ReadLine();

            while(true)
            {
                if (input.Contains("start".ToLower()))
                {
                    stopwatch.Start(DateTime.Now.TimeOfDay);
                    Console.WriteLine("Type stop to stop the stopwatch.");
                    input = Console.ReadLine();
                    if (input.Contains("stop".ToLower()))
                    {

                        Console.WriteLine("it took {0} seconds to complete the task", stopwatch.Stop().TotalSeconds);
                        Console.WriteLine("\nType start to start the stopwatch again.");
                        input = Console.ReadLine();

                    }
                }
            }
        }
    }
}
