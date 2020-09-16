using System;

namespace ControlFlowE3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter image width");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter image height");
            int height = Convert.ToInt32(Console.ReadLine());

            if(width > height)
            {
                Console.WriteLine("Image is landscape");
            }
            else
            {
                Console.WriteLine("Image is portrait");
            }    
        }
    }
}
