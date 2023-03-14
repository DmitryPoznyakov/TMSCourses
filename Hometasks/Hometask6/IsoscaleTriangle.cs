using System;
namespace Hometasks.Hometask6
{
    internal class IsoscaleTriangle : Triangle
    {
        public double TriangleHeight;

        public IsoscaleTriangle(double firstside, double secondside, double thirdside) : base(firstside, secondside, thirdside)
        {
        }

        public override double GetSquare()
        {       
                if ((firstside == secondside) && (firstside != thirdside))
                {
                    Console.WriteLine("Get square IsoscelesTriangle: ");
                    TriangleHeight = Math.Sqrt(4 * Math.Pow(firstside, 2) - Math.Pow(thirdside, 2)) / 2;
                    return thirdside * TriangleHeight / 2;
                }
                else if ((firstside == thirdside) && (firstside != secondside))
                {
                    Console.WriteLine("Get square IsoscelesTriangle: ");
                    TriangleHeight = Math.Sqrt(4 * Math.Pow(firstside, 2) - Math.Pow(secondside, 2)) / 2;
                    return secondside * TriangleHeight / 2;
                }

                Console.WriteLine("Get square IsoscelesTriangle: ");
                TriangleHeight = Math.Sqrt(4 * Math.Pow(thirdside, 2) - Math.Pow(firstside, 2)) / 2;
                return firstside * TriangleHeight / 2;
        }
    }
}

