namespace _01.Shapes
{
    public class Triangle : Shape
    {
        //constructors
        public Triangle(double height, double width)
            :base(height, width)
        {

        }

        //methods
        public override double CalculateSurface()
        {
            return (this.Height * this.Width) / 2;
        }
    }
}
