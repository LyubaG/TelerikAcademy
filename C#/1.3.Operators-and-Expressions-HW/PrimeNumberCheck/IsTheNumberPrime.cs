//Problem 8. Prime Number Check
//Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive

using System;

class IsTheNumberPrime
{
    static void Main()
    {
        Console.WriteLine("Enter a positive integer smaller than 101:");
        int num = int.Parse(Console.ReadLine());
        while (num <= 0 || num > 100)
        {
            Console.WriteLine("Oh dear...I asked for something else... Get it right this time: ");
            num = int.Parse(Console.ReadLine());
        }

        bool isItPrime = num != 1; //to make sure it says 1 is not prime

        for (int count = 2; count <= Math.Sqrt(num); count++) //count is largest when, squared, it results in the number; so if count s larger than the Sqrt, the other count gets smaller, smaller than Sqrt, and we only need to find the smallest division count to get a 'false'
        {
            if ( (num % count == 0) )
            {
                isItPrime = false;
            }

        }
        Console.WriteLine("Your number is prime? --> " + isItPrime);

    }
}
