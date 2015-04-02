namespace _01.Shapes
{
    using System;
    public abstract class Shape
    {
        //fields
        private double height;
        private double width;

        //construcors
        public Shape(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        //properties
        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height cannot be a non-positive number!");
                }
                this.height = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width cannot be a non-positive number!");
                }
                this.width = value;
            }
        }

        //methods
        public abstract double CalculateSurface();
    }
}
