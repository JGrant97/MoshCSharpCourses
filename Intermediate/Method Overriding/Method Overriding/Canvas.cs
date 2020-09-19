using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Overriding
{
    class Canvas
    {
        public void DrawShapers(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
