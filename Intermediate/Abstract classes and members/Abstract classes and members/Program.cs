﻿using System;

namespace Abstract_classes_and_members
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var shape = new Shape();



            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}