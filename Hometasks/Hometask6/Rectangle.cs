using System;
namespace Hometasks.Hometask6
{
	internal class Rectangle : anyfigure
	{
		public double xSide;
		public double ySide;
		public double RectangleSquare;


        public Rectangle(double xSide, double ySide)
		{
			this.xSide = xSide;
			this.ySide = ySide;
		}

		public override double GetSquare()
		{
			Console.WriteLine($"The square of rectangle is: ");
			return RectangleSquare = xSide * ySide;

        }
	}
}

