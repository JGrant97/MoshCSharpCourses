using System;

namespace ControlFlowE5
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 100;
            int counter = 0;

            for (int i = 1; i <= max; i++)
            {
                if (i % 3 == 0)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
