using System;

namespace Shapes
{
    public class Square : IShape
    {
        public int side;

        public Square(int side)
        {
            this.side = side;
        }

        public double Area()
        {
            return side * side;
        }
    }
}