using System;
namespace Hometasks.Hometask6
{
	internal class Hometask6
	{
        static void Main(string[] args)
        {
            // Task1
            Triangle triangle = new TriangleBuilder().CreateTriangle(6, 8, 6);

            Triangle triangle2 = new TriangleBuilder().CreateTriangle(6, 6, 6);

            Triangle triangle3 = new TriangleBuilder().CreateTriangle(5, 7, 10);

            Triangle triangle4 = new TriangleBuilder().CreateTriangle(6, 8, 10);

            Rectangle rectangle = new RectangleBuilder().CreateRectangle(6, 5);

            Rectangle rectangle2 = new RectangleBuilder().CreateRectangle(6, 6);

            var SquareArray = new anyfigure [] {triangle, triangle2, triangle3, triangle4, rectangle, rectangle2 };
            foreach (var figuresquare in SquareArray)
            {
                    Console.WriteLine(figuresquare.GetSquare() + "\n");
            }
        }
      
           
        
    }
}

