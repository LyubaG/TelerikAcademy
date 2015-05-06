//Problem 9. Trapezoids
//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class TrapezArea
{
    static void Main()
    {
        Console.WriteLine("What's the trapezoid's side a (in cm)? "); //reminder: careful with commas/points when entering doubles...
        double side1 = double.Parse(Console.ReadLine());
        Console.WriteLine("How about side b? ");
        double side2 = double.Parse(Console.ReadLine());
        Console.WriteLine("And the height? ");
        double h = double.Parse(Console.ReadLine());
        double area = ((side1 + side2) * h ) / 2;
       
        Console.WriteLine("The trapezoid's area is {0}cm^2.", area);
    }
}


//Option that checks for validity:
/*
 * static void Main()
        {
            double a, b,h;
            Console.Write("Enter the first side of the trapezoid:");
            bool isValid_a = double.TryParse(Console.ReadLine(),out a);
            Console.Write("Enter the second side of the trapezoid:");
            bool isValid_b = double.TryParse(Console.ReadLine(),out b);
            Console.Write("Enter the height of the trapezoid:");
            bool isValid_h = double.TryParse(Console.ReadLine(),out h);
 
            if (isValid_a && isValid_b && isValid_h)
            {
                double area = (a + b)*0.5*h;
                Console.WriteLine("The area of the rectange is:{0}", area);
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }
        }
*/