//Write methods that calculate the surface of a triangle by given:
//    Side and an altitude to it;
//    Three sides;
//    Two sides and an angle between them;
//Use System.Math.

//Example:
//input                     | output 
//* a = 23.2, h = 5         | 58    |
//* a = 11, b =12, c = 13   | 61.48 |
//* a = 10, b = 7, C = 25°  | 14.79 |

using System;

class TriangleAreaFormulas
{
    static void Main()
    {
        Console.WriteLine("If you have the traingle's side and altitude, press 1.\nIf you have the triangle's 3 sides, press 2.\nIf you have the triangle's 2 sides and angle in-between, press 3.");
        ConsoleKeyInfo choice = Console.ReadKey();
        if (choice.KeyChar == '1')
        {
            TriangleAreaBySideAltitude();
        }
        if (choice.KeyChar == '2')
        {
            TriangleAreaByThreeSides();
        }
        if (choice.KeyChar == '3')
        {
            TriangleAreaBySidesAngle();
        }
    }

    private static void TriangleAreaBySidesAngle()
    {
        Console.WriteLine();
        Console.Write("Triangle side a = ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Triangle side b = ");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Angle = ");
        double angle = double.Parse(Console.ReadLine());
        double grrr = Math.Sin(angle * Math.PI / 180);
        double area = (sideA * sideB) / 2 * Math.Sin(angle * Math.PI / 180);
        Console.WriteLine("The area is: " + Math.Round(area,2));
    }

    private static void TriangleAreaByThreeSides()
    {
        Console.WriteLine();
        Console.Write("Triangle side a = ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Triangle side b = ");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Triangle side c = ");
        double sideC = double.Parse(Console.ReadLine());
        double semiPerimeter = (sideA + sideB + sideC) / 2;
        double area = Math.Sqrt(semiPerimeter * (semiPerimeter - sideC) * (semiPerimeter - sideB) * (semiPerimeter - sideA));
        Console.WriteLine("The area is: " + Math.Round(area, 2));
    }

    private static void TriangleAreaBySideAltitude()
    {
        Console.WriteLine();
        Console.Write("Triangle side a = ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Triangle altitude h = ");
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine("The area is: " + Math.Round((sideA * h / 2),2));
    }
}