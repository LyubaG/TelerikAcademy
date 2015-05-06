//Problem 12.* Randomize the Numbers 1…N
//• Write a program that enters in integer  n  and prints the numbers 
//1, 2, …, n  in random order.

//Examples:
//n       randomized numbers 1…n
//3       2 1 3 
//10      3 4 8 2 6 7 9 1 10 5 
//Note: The above output is just an example. Due to randomness, 
//your program most probably will produce different results. 
//You might need to use arrays.

using System;

class RandomizeNumbersInRange
{
    static void Main()
    {
        Console.WriteLine("Enter the max value of the numbers range: ");
        int maxN = int.Parse(Console.ReadLine());
        int[] numbers = new int[maxN];

        Random randomGen = new Random();
        for (int i = 0; i < maxN; i++)
        {
            numbers[i] = i + 1; //fill array
        }
        foreach (int i in numbers) //swap array elements
        {
            int randomNum = randomGen.Next(1, maxN);
            int temp = numbers[randomNum];
            numbers[randomNum] = numbers[i];
            numbers[i] = temp;
        }
        Console.WriteLine(String.Join(" ", numbers));

    }
}
