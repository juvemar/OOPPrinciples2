namespace _01.Shapes
{
    public class Square : Shape
    {
        //constructors
        public Square(double side)
            : base(side, side)
        {

        }

        //methods
        public override double CalculateSurface()
        {
            return this.Height * this.Width;
        }
    }
}
