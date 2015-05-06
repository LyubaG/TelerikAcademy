//Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;

class CheckDigit
{
    static void Main()
    {
        Console.Write("Enter an integer:");
        int num = int.Parse(Console.ReadLine());
        num /= 100;
        num %= 10;
        bool seventh = num == 7; 
        Console.WriteLine("Your integer's third digit from right to left is 7 --> {0}", seventh);
    }
}
