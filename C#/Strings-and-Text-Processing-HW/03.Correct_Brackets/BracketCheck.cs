//Problem 3. Correct brackets
//    Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

using System;
using System.Collections.Generic;
using System.Linq;

class BracketCheck
{
    static void Main()
    {
        Console.WriteLine("Enter expression:");
        string input = Console.ReadLine();
        bool isCorrect = true;
        int bracketStack = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(') bracketStack++;
            else if (input[i] == ')') bracketStack--;
            if (bracketStack < 0)
            {
                isCorrect = false;
                break;
            }
        }
        Console.WriteLine(isCorrect);
    }
}
