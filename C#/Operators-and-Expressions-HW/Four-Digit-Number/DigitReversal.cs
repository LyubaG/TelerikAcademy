/* Problem 6. Four-Digit Number
Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0.
*/

using System;

class DigitReversal
{
    static void Main()
    {
        Console.Write("Enter a four-digit number (it cannot start with a 0): ");
        string num = (Console.ReadLine());
        double digit1 = Char.GetNumericValue(num, 0); //This method only has double as output.
        double digit2 = Char.GetNumericValue(num, 1);
        double digit3 = Char.GetNumericValue(num, 2);
        double digit4 = Char.GetNumericValue(num, 3);
        Console.WriteLine("The sum of your number's digits is {0}.", digit1 + digit2 + digit3 + digit4);
        Console.WriteLine("In reversed digit order, your number is {0}{1}{2}{3}.", digit4, digit3, digit2, digit1);
        Console.WriteLine("With the last digit in front, your number is {0}{1}{2}{3}.", digit4, digit1, digit2, digit3);
        Console.WriteLine("With the second and third digits exchanged, your number is {0}{1}{2}{3}.", digit1, digit3, digit2, digit4);
    }
}


/* Another method for digit addition (not great for large numbers):
{
    Console.Write("Enter a four-digit number: ");
    int num = int.Parse(Console.ReadLine());
        
    int sum = 0;
    while (num != 0)
    {
        int remainder;
        num = Math.DivRem(num, 10, out remainder); //Math.DivRem doesn't work with short, only int or long
        sum += remainder;
    }
    Console.WriteLine("The sum of the number's digits is {0}.", sum);
 }
 
 And another one:
 
sum = 0;
while (n != 0) 
{
    sum += n % 10;
    n /= 10;
}*/