﻿using System;

namespace Abstract_classes_and_members
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("Copy shape into clipboard");
        }

        public void Select()
        {
            Console.WriteLine("Select the shape");
        }
    }
}