//Problem 11.* Number as Words
//• Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

//Examples:
//numbers         number as words
//0               Zero 
//9               Nine 
//10              Ten 
//12              Twelve 
//19              Nineteen 
//25              Twenty five 
//98              Ninety eight 
//98              Ninety eight 
//273             Two hundred and seventy three 
//400             Four hundred 
//501             Five hundred and one 
//617             Six hundred and seventeen 
//711             Seven hundred and eleven 
//999             Nine hundred and ninety nine 

using System;

class Number_as_Words
{
    static void Main()
    {
        Console.Write("Tell me a number (integer in the range 0 to 999):  ");
        int number;
        while (!(int.TryParse(Console.ReadLine(), out number)))
        {
            Console.WriteLine("You can do better. Do it: ");
        }
        if (number < 0 || number > 999) Console.WriteLine("The number's out of range.");
        if (number == 0) Console.WriteLine("Zero");

        int hundreds = number / 100; //use int to make sure it only keeps what's on the right side of the decimal point
        int tens = (number % 100) / 10;
        int units = number % 10;

        if (hundreds >= 1 && hundreds <= 9)
        {
            switch (hundreds)
            {
                case 1:
                    Console.Write("One hundred ");
                    break;
                case 2:
                    Console.Write("Two hundred ");
                    break;
                case 3:
                    Console.Write("Three hundred ");
                    break;
                case 4:
                    Console.Write("Four hundred ");
                    break;
                case 5:
                    Console.Write("Five hundred ");
                    break;
                case 6:
                    Console.Write("Six hundred ");
                    break;
                case 7:
                    Console.Write("Seven hundred ");
                    break;
                case 8:
                    Console.Write("Eight hundred ");
                    break;
                case 9:
                    Console.Write("Nine hundred ");
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
            if ((tens == 0 && units > 0) || tens >= 1)
            {
                Console.Write("and ");
            }
        }
        if (tens == 1)
        {
            switch (units)
            {
                case 0:
                    Console.WriteLine("ten");
                    break;
                case 1:
                    Console.WriteLine("eleven");
                    break;
                case 2:
                    Console.WriteLine("twelve");
                    break;
                case 3:
                    Console.WriteLine("thirteen");
                    break;
                case 4:
                    Console.WriteLine("fourteen");
                    break;
                case 5:
                    Console.WriteLine("fifteen");
                    break;
                case 6:
                    Console.WriteLine("sixteen");
                    break;
                case 7:
                    Console.WriteLine("seventeen");
                    break;
                case 8:
                    Console.WriteLine("eighteen");
                    break;
                case 9:
                    Console.WriteLine("nineteen");
                    break;
            }
        }
        if (tens > 1 && units != 0)
        {
            switch (tens)
            {
                case 2:
                    Console.Write("twenty-");
                    break;
                case 3:
                    Console.Write("thirty-");
                    break;
                case 4:
                    Console.Write("fourty-");
                    break;
                case 5:
                    Console.Write("fifty-");
                    break;
                case 6:
                    Console.Write("sixty-");
                    break;
                case 7:
                    Console.Write("seventy-");
                    break;
                case 8:
                    Console.Write("eighty-");
                    break;
                case 9:
                    Console.Write("ninety-");
                    break;
            }
        }

        if (tens > 1 && units == 0)
        {
            switch (tens)
            {
                case 2:
                    Console.Write("twenty");
                    break;
                case 3:
                    Console.Write("thirty-");
                    break;
                case 4:
                    Console.Write("fourty");
                    break;
                case 5:
                    Console.Write("fifty");
                    break;
                case 6:
                    Console.Write("sixty");
                    break;
                case 7:
                    Console.Write("seventy");
                    break;
                case 8:
                    Console.Write("eighty");
                    break;
                case 9:
                    Console.Write("ninety");
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }


        if (tens != 1)
        {
            switch (units)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }
        Console.ReadLine();
    }
}

