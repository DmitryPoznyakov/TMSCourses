using System;
namespace Hometasks.Hometask6
{
    internal class Triangle : anyfigure
    {
        public double firstside;
        public double secondside;
        public double thirdside;

        public Triangle(double firstside, double secondside, double thirdside)
        {
            this.firstside = firstside;
            this.secondside = secondside;
            this.thirdside = thirdside;
        }

        public override double GetSquare()
        {
            Console.WriteLine("Get square of Scalene triangle by Heron formula");
            double SemiPerimetr = (firstside + secondside + thirdside) / 2;
            return  Math.Sqrt(SemiPerimetr * (SemiPerimetr - firstside) * (SemiPerimetr - secondside) * (SemiPerimetr * thirdside));
        }
    }
}

