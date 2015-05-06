//Problem 7. Point in a Circle
//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;

class CirclePoint
{
    static void Main()
    {
        double distance, radius = 2;
        Console.WriteLine("Enter your point's coordinate x: ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("...and y: ");
        double y = double.Parse(Console.ReadLine());
        distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        bool insideCircle = (distance <= radius);
        Console.WriteLine("The point is inside the circle ---> " + insideCircle);
    }
}

