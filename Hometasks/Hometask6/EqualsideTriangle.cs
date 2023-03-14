using System;
namespace Hometasks.Hometask6
{
	internal class EqualsideTriangle : Triangle

        
    {
        public EqualsideTriangle(double firstside, double secondside, double thirdside) : base(firstside, secondside, thirdside)
        {

        }


            public override double GetSquare()
        {
            Console.WriteLine("Get square EqualsideTriangle");
            return Math.Pow(firstside, 2)* Math.Sqrt(3)/4;
        }
    }
}

