using System;
namespace Hometasks.Hometask6
{
	internal class TriangleBuilder
	{
		public TriangleBuilder() {}

		public Triangle CreateTriangle(double firstside, double secondside, double thirdside)
		{
			if ((firstside == secondside) && (firstside == thirdside))
			{
				return new EqualsideTriangle(firstside, secondside, thirdside);
			}
			else
			if ((firstside != secondside) && (secondside != thirdside) && (thirdside != firstside))
			{
				if (Math.Round(Math.Pow(firstside, 2), 2) == (Math.Round((Math.Pow(secondside, 2) + Math.Pow(thirdside, 2)), 2)))
                {
					return new RightTriangle(firstside, secondside, thirdside);
				}
				if (Math.Round(Math.Pow(secondside, 2), 2) == (Math.Round((Math.Pow(firstside, 2) + Math.Pow(thirdside, 2)), 2)))

                {
					return new RightTriangle(firstside, secondside, thirdside);
				}
				if (Math.Round(Math.Pow(thirdside, 2), 2) == (Math.Round((Math.Pow(firstside, 2) + Math.Pow(secondside, 2)), 2)))
                {
					return new RightTriangle(firstside, secondside, thirdside);
				}
				else
					return new Triangle(firstside, secondside, thirdside);
			}
			else
			{
				return new IsoscaleTriangle(firstside, secondside, thirdside);
			}
        }
	}
}

