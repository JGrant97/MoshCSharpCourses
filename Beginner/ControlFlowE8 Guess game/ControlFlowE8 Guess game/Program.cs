using System;

namespace ControlFlowE8_Guess_game
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var randNum = random.Next(1, 10);
            int guess = 0;


            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("Guess the number");
                var num = Convert.ToInt32(Console.ReadLine());

                if (num == randNum)
                {
                    Console.WriteLine("You won!");
                    break;
                }
                else
                {
                    guess++;
                }
                if(guess >= 4)
                {
                    Console.WriteLine("You lost");
                    break;
                }
            }
        }
    }
}
