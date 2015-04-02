namespace _01.Shapes
{
    public class Rectangle : Shape
    {
        //constructors
        public Rectangle(double height, double width)
            :base(height, width)
        {

        }

        //methods
        public override double CalculateSurface()
        {
            return this.Height * this.Width;
        }
    }
}
