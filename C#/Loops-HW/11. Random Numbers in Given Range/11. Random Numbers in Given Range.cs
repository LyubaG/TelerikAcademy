//Problem 11. Random Numbers in Given Range
//• Write a program that enters  3  integers  n ,  min  and  max 
//( min != max ) and prints  n  random numbers in the range  [min...max] .

//Examples:
//n       min         max         random numbers
//5       0           1           1 0 0 1 1 
//10      10          15          12 14 12 15 10 12 14 13 13 11 

//Note: The above output is just an example. Due to randomness, your program most 
//probably will produce different results.

using System;

class Random_Numbers_in_Given_Range
{
    static void Main()
    {
        Console.WriteLine("Enter how many random numbers you want: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the minimal value: ");
        int min = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the maximal value: ");
        int max = int.Parse(Console.ReadLine());
        if (min != max && min < max)
        {
            Random randomGen = new Random();
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", randomGen.Next(min, max + 1)); // the upper bound is exclusive, hence the +1 (very frustrating!)
            }
        }
        else
            Console.WriteLine("Your input is incorrect.");
    }
}
