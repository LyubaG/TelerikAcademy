//Problem 18.* Trailing Zeroes in N!
//• Write a program that calculates with how many zeroes the factorial
//of a given number  n  has at its end.
//• Your program should work well for very big numbers, e.g.  n=100000 .

//Examples:
//n       trailing zeroes of n!       explaination
//10      2                           3628800 
//20      4                           2432902008176640000 
//100000  24999                       think why 

using System;

class Trailing_Zeroes_in_Nfact
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        uint num = uint.Parse(Console.ReadLine());
        int zeroCount = 0;
        for (int i = 5; num / i >= 1; i *= 5)
            zeroCount += (int)num / i;
        Console.WriteLine("Trailing zeroes in its Factorial: " + zeroCount);
    }
}

//// Some explanation: 
//A simple method is to first calculate factorial of n, then count trailing 0s in the result 
//(We can count trailing 0s by repeatedly dividing the factorial by 10 till the remainder is 0).
//The above method can cause overflow for a slightly bigger numbers... So the other option is:
//Each trailing zero is the result of a factor 10 in the factorial, which can be written as 
//10 = 2*5 (e.g. 25 has two 5s)...and there are some other conditions...check http://www.programmerinterview.com/index.php/java-questions/find-trailing-zeros-in-factorial/ & http://www.geeksforgeeks.org/count-trailing-zeroes-factorial-number/ 