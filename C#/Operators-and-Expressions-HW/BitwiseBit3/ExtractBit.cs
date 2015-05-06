//Problem 11. Bitwise: Extract Bit #3
//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

using System;

class ExtractBit
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        uint num = uint.Parse(Console.ReadLine());
        int bit = 3;
        int mask = 1 << bit;
        Console.Write("The third bit (right to left) is {0}. For your info, its full binary representation is:\n{1}. ", ((num & mask) == mask ? 1 : 0), (System.Convert.ToString(num, 2).PadLeft(32, '0')));
        Console.ReadLine();
    }
}


//Note to self: does not work with (num & mask) == 1
//\n is new line, PadLeft fills up the binary with zeroes to the left