using System;
namespace Hometasks.Hometask6
{
	internal class RectangleBuilder
	{
		public RectangleBuilder() { }

		public Rectangle CreateRectangle(double xSide, double ySide)
		{
			if (xSide == ySide)
				return new Square(xSide, ySide);
			else
				return new Rectangle(xSide, ySide);
		}
	}
}

