using System;

namespace ControlFlowE4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter speed limit");
            int limit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter speed of vehicle");
            int speed = Convert.ToInt32(Console.ReadLine());

            int speedDifference = speed - limit;

            int points = 0;

            if(speed <= limit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("\nSpeeding");
                //for (int i = 5; i <= speedDifference; i += 1)
                //{
                //    if (i % 5 == 0)
                //    {
                //        points++;
                //    }
                //}

                var i = 5;
                while(i <= speedDifference)
                {
                    if(i % 5 == 0)
                    {
                        points++;
                    }
                    i++;
                }

                if(points > 12)
                {
                    Console.WriteLine("\nLicense Suspended");
                }
            }
            Console.WriteLine("\nYou have " + points + " points.");
        }
    }
}
