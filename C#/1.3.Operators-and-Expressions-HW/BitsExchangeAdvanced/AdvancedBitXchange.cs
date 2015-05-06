//Problem 16.** Bit Exchange (Advanced)
//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
//The first and the second sequence of bits may not overlap.

using System;

class AdvancedBitXchange
{
    static void Main()
    {
        Console.Write("enter your number: ");
        long n = long.Parse(Console.ReadLine());
        Console.Write("enter the bit position p = ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("enter the bit position q = ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("enter the length k = ");
        int k = int.Parse(Console.ReadLine());

        Console.WriteLine("Binary representation of your number: {0} ", (Convert.ToString(n, 2).PadLeft(32, '0')));

        if (p + k >= 32)
        {
            Console.WriteLine("Out of range");
        }
        else if (p < q && ((p + q) < k))
        {
            Console.WriteLine("Overlapping");
        }
        else
        {
            for (int i = 0; i < k; i++)
            {
                int maskOne = (int)(n & (1 << p)) >> p; //for first set of bits
                int maskTwo = (int)(n & (1 << q)) >> q;
                               
                if (maskOne == 0)
                {
                    n = n & (~(1 << q));
                }
                else if (maskOne == 1)
                {
                    n = n | (1 << q);
                }

                if (maskTwo == 0)
                {
                    n = n & (~(1 << p));
                }
                else if (maskTwo == 1)
                {
                    n = n | (1 << p);
                }

                p++;
                q++;
            }

            Console.WriteLine("New number is (in binary form): {0}", (Convert.ToString(n, 2).PadLeft(32, '0')));
            Console.WriteLine("And its decimal value: " + n);
        }
    }
}
