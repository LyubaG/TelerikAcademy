//Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class RandomNumbers
{
    static Random randomGen = new Random(); //to get the most random random number :)
    
    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.Write(randomGen.Next(100, 201) + "  ");
        }
        Console.WriteLine();
    }
}

