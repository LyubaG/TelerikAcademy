//Problem 16.* Print Long Sequence
//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
//You might need to learn how to use loops in C# (search in Internet).

using System;

class LongSequence
{
    static void Main()
    {
        int n = 2;
        while (n < 1002)
        {
            if (n % 2 == 0)
                Console.Write("{0}, ", n);
            else
                Console.Write("{0}, ", -n);
            n++;
        }

        /* Option 2:
        for (int n = 2; n <= 1001; n++)
        {
            {
                if (n % 13 == 1) //13 numbers/line
                {
                    Console.WriteLine(-n);
                }
                else
                {
                    if (((n / 2) * 2) == n)
                        Console.Write("{0}, ", n);
                    else
                        Console.Write("{0}, ", -n);
                }
            } */
    }
}
