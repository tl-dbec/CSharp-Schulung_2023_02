using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(side: 4);
            Console.WriteLine($"Sqaure Area: {square.Area()}");

            var circle = new Circle(radius: 2);
            Console.WriteLine($"Circle Area: {circle.Area()}");

            var triangle = new Triangle(triangleBase: 6, height: 4);
            Console.WriteLine($"Triangle Area: {triangle.Area()}");


            var areaSum = square.Area();
            areaSum = areaSum + circle.Area();
            areaSum = areaSum + triangle.Area();

            var areaSum2 = 0.0;

            //foreach (var shape in myShapes)
            //{
            //    areaSum2 = areaSum2 + shape.Area();
            //}

            var shapes = new List<IShape>();
            shapes.Add(square);
            shapes.Add(circle);
            shapes.Add(triangle);


            foreach (var shape in shapes)
            {
                areaSum2 = areaSum2 + shape.Area();
            }


            Console.WriteLine($"Area Sum: {areaSum}");
            Console.WriteLine($"Area Sum2: {areaSum2}");


            Console.ReadLine();
        }
    }
}
