using System;

namespace Shapes
{
    public class Circle : IShape
    {
        public int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            return Math.PI * radius * radius;
        }
        
    }
}