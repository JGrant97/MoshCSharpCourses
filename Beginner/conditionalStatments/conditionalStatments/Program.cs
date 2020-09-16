using System;

namespace conditionalStatments
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isGoldCustomer = true;

            //float price;
            //if(isGoldCustomer)
            //{
            //    price = 19.95f;
            //}
            //else
            //{
            //    price = 29.95f;
            //}

            float price = (isGoldCustomer) ? 19.96f : 29.95f;

            Console.WriteLine(price);

            var season = Season.Autumn;

            switch(season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn and a beautiful season.");
                    break;

                case Season.Summer:
                    Console.WriteLine("It's perfect to go to the beach.");
                    break;

                default:
                    Console.WriteLine("I don't understand the season");
                    break;
            }
        }
    }
}
