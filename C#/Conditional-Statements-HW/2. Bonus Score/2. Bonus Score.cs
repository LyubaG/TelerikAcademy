//Problem 2. Bonus Score
//• Write a program that applies bonus score to given score in the range  [1…9]  
//by the following rules: ◦ If the score is between  1  and  3 , the program multiplies it by  10 .
//◦ If the score is between  4  and  6 , the program multiplies it by  100 .
//◦ If the score is between  7  and  9 , the program multiplies it by  1000 .
//◦ If the score is  0  or more than  9 , the program prints  “invalid score” .

//Examples:
//score       result
//2           20 
//4           400 
//9           9000 
//-1          invalid score 
//10          invalid score 

using System;
using System.Globalization;
using System.Threading;

class Bonus_Score
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("What's your score?");
        double score = double.Parse(Console.ReadLine());
        double newScore = 0;

        if (score <= 0 || score > 9) Console.WriteLine("Invalid score, man...");
        else
        {
            if (score >= 1 && score <= 3) newScore = score * 10;
            if (score >= 4 && score <= 6) newScore = score * 100;
            if (score >= 7 && score <= 9) newScore = score * 1000;
            Console.WriteLine("With Bonus added: {0}", newScore);
        }
    }
}

