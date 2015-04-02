namespace _01.Shapes
{
    using System;
    using System.Collections.Generic;

    class MainProgram
    {
        static void Main()
        {
            Shape[] shapes = new Shape[] 
            {
                new Triangle(4.5, 2.3),
                new Rectangle(2.3, 4.8),
                new Square(6.5),
                new Triangle(1.3, 5.2),
                new Rectangle(7.3, 4.9),
                new Square(4.5)
            };

            foreach (var currentShape in shapes)
            {
                Console.WriteLine("{0}'s surface is {1} cm", currentShape.GetType().Name, currentShape.CalculateSurface());
            }
        }
    }
}
