using System;
namespace Hometasks.Hometask6
{
	internal class RightTriangle : Triangle
	{
        public RightTriangle(double firstside, double secondside, double thirdside) : base(firstside, secondside, thirdside)
        {
        }

        public override double GetSquare()
        {
            if (firstside > secondside)
            {
                if (firstside > thirdside)
                {
                    return GetSquareForRightTriangle(secondside,thirdside);
                }
                else
                {
                    return GetSquareForRightTriangle(firstside,secondside);
                }
            }
            else
            {
                if (secondside > thirdside)
                {
                    return GetSquareForRightTriangle(firstside,thirdside);
                }
                else
                {
                    return GetSquareForRightTriangle(firstside,secondside);
                }
            }
        }

        private double GetSquareForRightTriangle(double firstsid, double secondside)
        {
            Console.WriteLine("Get square RightTriangle: ");
            return 0.5 * firstside * secondside;
        }
	}
}

