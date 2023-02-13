namespace Shapes2
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

        public override string ToString()
        {
            return $"Fläche Square: {Area()}";
        }
    }
}