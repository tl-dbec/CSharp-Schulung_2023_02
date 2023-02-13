using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(side: 4);
            Console.WriteLine(square.ToString());

            var circle = new Circle(radius: 2);
            //double area = circle.Area();
            Console.WriteLine(circle.ToString());

            var triangle = new Triangle(triangleBase: 6, height: 4);
            Console.WriteLine(triangle.ToString());

            var areaSum = square.Area();
            areaSum = areaSum + circle.Area();
            areaSum = areaSum + triangle.Area();

            Console.WriteLine($"Area Sum: {areaSum}");

            //var areaSum2 = 0.0;
            //foreach (var shape in shapes)
            //{
            //    areaSum2 = areaSum2 + shape.Area();
            //}

            var shapes = new List<IShape>();
            shapes.Add(square);
            shapes.Add(circle);
            shapes.Add(triangle);


            var areaSum2 = 0.0;
            foreach (var shape in shapes)
            {
                areaSum2 = areaSum2 + shape.Area();
            }

            Console.WriteLine($"Area Sum2: {areaSum2}");

            Console.ReadLine();
        }
    }
}
