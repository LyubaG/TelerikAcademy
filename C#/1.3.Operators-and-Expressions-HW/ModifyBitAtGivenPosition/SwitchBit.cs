//Problem 14. Modify a Bit at Given Position
//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.

using System;


class SwitcBit
{
    static void Main()
    {

        Console.Write("Enter an integer: ");
        uint n = uint.Parse(Console.ReadLine());
        int num = (int)n;
        int bit = 0;
        Console.WriteLine("And the value of which bit (right to left) you'd like to modify: ");
        byte p = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value to which you want to modify the bit (0 or 1): ");
        byte v = byte.Parse(Console.ReadLine());
        if (v != 0 && v != 1) Console.WriteLine("That's not a valid entry. The console is sad and wants to close.");
        else
        {
            if (v == 0)
            {
                int mask = ~(1 << p);
                bit = num & mask;
            }
            if (v == 1)
            {
                int mask = 1 << p;
                bit = num | mask;
            }

            Console.Write("The decimal value of your number with a modified bit is {0}. ", bit);
        }
        Console.ReadLine();

    }
}