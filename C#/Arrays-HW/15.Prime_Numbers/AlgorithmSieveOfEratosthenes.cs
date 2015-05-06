//Problem 15. Prime numbers
//    Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.


using System;
using System.Collections.Generic;
using System.Linq;

class AlgorithmSieveOfEratosthenes
{
    static void Main()
    {
        long[] numbers = new long[10000000];
        for (long i = 0; i < 10000000; i++)
        {
            numbers[i] = i + 1;
        }

        long divider;
        long upperLimit = (long)Math.Sqrt(10000000);

        for (long i = 2; i < upperLimit && numbers[i] != 0; i += 2)
        {
            if (numbers[i] != 0)
            {
                divider = numbers[i];
                for (long j = (numbers[i] * numbers[i]) - 1; j < numbers.Length && numbers[j] != 0; j += 2)
                {
                    if (numbers[j] % divider == 0)
                    {
                        numbers[j] = 0;
                    }
                }
            }
        }

        Console.Write("2  ");
        for (long i = 2; i < numbers.Length; i += 2)
        {
            if (numbers[i] != 0)
            {
                Console.Write(numbers[i] + " ");
            }
        }

    }
}
