//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;

class DoubleDivision
{
    static void Main()
    {
        Console.Write("Enter an integer:");
        int num = int.Parse(Console.ReadLine());
        bool division = (num % 7 == 0 && num % 5 == 0 && num != 0); //We don't count 0, as in the problem examples. 
        Console.WriteLine("Your number is divisible by both 7 and 5? " + division);
    }
}
