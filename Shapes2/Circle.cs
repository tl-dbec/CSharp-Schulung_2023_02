using System;

namespace Shapes2
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

            // alternative:
            //return Math.PI * Math.Pow(radius, 2);
        }

        public override string ToString()
        {
            return $"Fläche Circle {Area()}";
        }

        //internal void Area()
        //{
        //    throw new NotImplementedException();
        //}
    }
}