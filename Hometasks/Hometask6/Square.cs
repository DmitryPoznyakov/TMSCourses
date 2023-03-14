using System;
namespace Hometasks.Hometask6
{
	internal class Square : Rectangle
	{
		public Square(double xSide, double ySide) : base(xSide,ySide)
		{
		}

        public override double GetSquare()
        {
            Console.WriteLine($"The square of Square is:");
            return RectangleSquare = Math.Pow(xSide, 2);
        }

    }
}

