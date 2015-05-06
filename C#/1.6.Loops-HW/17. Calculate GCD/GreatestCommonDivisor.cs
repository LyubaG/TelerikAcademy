//Problem 17.* Calculate GCD
//• Write a program that calculates the greatest common divisor (GCD)
//of given two integers  a  and  b .
//• Use the Euclidean algorithm (find it in Internet).

//Examples:
//a       b       GCD(a, b)
//3       2       1 
//60      40      20 
//5       -15     5 

using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        Console.Write("Enter the first integer: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Enter the second integer: ");
        int y = int.Parse(Console.ReadLine());
        int remainder = x % y;
        do
        {
            remainder = x % y;
            x = y;
            y = remainder;
            remainder = x % y;
        }
        while (remainder != 0);

        Console.WriteLine("Their greatest common divisor is " + y);
        Console.WriteLine("Oh, Euclid was apparently sooo cool...yeah...");
        Console.ReadLine();
    }
}
