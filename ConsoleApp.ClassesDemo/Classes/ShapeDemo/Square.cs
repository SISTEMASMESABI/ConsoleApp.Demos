namespace ConsoleApp.ClassesDemo
{
    public class Square : Polygon
    {
        public Square(int width)
        {
            Width = width;
        }
        public override int Area()
        {
            //Math.Pow(Width, 2);
            return Width * Width;
        }
    }
}
