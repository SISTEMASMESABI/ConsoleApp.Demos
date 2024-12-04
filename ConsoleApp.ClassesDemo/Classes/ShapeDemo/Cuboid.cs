using ConsoleApp.ClassesDemo.Interfaces;

namespace ConsoleApp.ClassesDemo
{
    public class Cuboid : Polygon, I2DShape, I3DShape
    {

        public Cuboid(double l, double w, double h)
        {
            Length = l;
            Width = w;
            Height = h;
        }
        public double Length { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return 2 * (Width * Length) + Height * Length + Height * Width;
        }

        public double Perimeter()
        {
            return 4 * (Length + Width + Height);
        }

        public double Volume()
        {
            return Length * Width * Height;
        }
    }
}
