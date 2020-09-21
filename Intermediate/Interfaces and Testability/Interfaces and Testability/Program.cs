﻿using System;
namespace Interfaces_and_Testability
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order();
            orderProcessor.Process(order);
        }
    }
}
