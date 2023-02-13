using System;

namespace Shapes2
{
    public class Triangle : IShape
    {
        public int triangleBase;
        public int height;

        public Triangle(int triangleBase, int height)
        {
            this.triangleBase = triangleBase;
            this.height = height;
        }

        public double Area()
        {
            return triangleBase * height / 2;
        }

        public override string ToString()
        {
            return $"Fläche Triangle: {Area()}";
        }
    }
}