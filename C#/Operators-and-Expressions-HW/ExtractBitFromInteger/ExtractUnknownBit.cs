//Problem 12. Extract Bit from Integer
//Write an expression that extracts from given integer n the value of given bit at index p.


using System;

class ExtractUnknownBit
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        uint num = uint.Parse(Console.ReadLine());
        Console.WriteLine("And the value of which bit (right to left) you'd like to know: ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        Console.Write("The third bit (right to left) is {0}. ", (num & mask) == mask ? 1 : 0);
        Console.ReadLine();

    }
}

