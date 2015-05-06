//Problem 13. Check a Bit at Given Position
//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.

using System;

class UnknownBitBoolean
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        uint num = uint.Parse(Console.ReadLine());
        Console.WriteLine("And the value of which bit (right to left) you'd like to know: ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        bool bitIsOne = ((num & mask) == mask);
        Console.Write("The bit at position {0} (right to left) is 1. --> Statement is: {1}. ", p, bitIsOne);
        Console.ReadLine();

    }
}
