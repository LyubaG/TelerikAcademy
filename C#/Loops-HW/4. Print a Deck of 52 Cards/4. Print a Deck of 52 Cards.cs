//Problem 4. Print a Deck of 52 Cards
//• Write a program that generates and prints all possible cards from a standard
//deck of 52 cards (without the jokers). The cards should be printed using the 
//classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//◦ The card faces should start from 2 to A.
//◦ Print each card face in its four possible suits: clubs, diamonds, hearts and 
//spades. Use 2 nested for-loops and a switch-case statement.

//output
//2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds
//3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds
//…  
//K of spades, K of clubs, K of hearts, K of diamonds
//A of spades, A of clubs, A of hearts, A of diamonds

//Note: You may use the suit symbols instead of text.

using System;
using System.Globalization;
using System.Threading;

class Print_a_Deck_of_52_Cards
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        char club = '\u2663';
        char diamond = '\u2666';
        char heart = '\u2665';
        char spade = '\u2660';

        for (int num = 2; num < 15; num++)
        {
            for (int symbol = 1; symbol <= 4; symbol++)
            {
                switch (num)
                {
                    case 2:
                        Console.Write("2 of ");
                        break;
                    case 3:
                        Console.Write("3 of ");
                        break;
                    case 4:
                        Console.Write("4 of ");
                        break;
                    case 5:
                        Console.Write("5 of ");
                        break;
                    case 6:
                        Console.Write("6 of ");
                        break;
                    case 7:
                        Console.Write("7 of ");
                        break;
                    case 8:
                        Console.Write("8 of ");
                        break;
                    case 9:
                        Console.Write("9 of ");
                        break;
                    case 10:
                        Console.Write("10 of ");
                        break;
                    case 11:
                        Console.Write("J of ");
                        break;
                    case 12:
                        Console.Write("Q of ");
                        break;
                    case 13:
                        Console.Write("K of ");
                        break;
                    case 14:
                        Console.Write("A of ");
                        break;
                    default:
                        break;
                }
                switch (symbol)
                {
                    case 1:
                        Console.Write(spade + " ");
                        break;
                    case 2:
                        Console.Write(club + " ");
                        break;
                    case 3:
                        Console.Write(heart + " ");
                        break;
                    case 4:
                        Console.WriteLine(diamond + " ");
                        break;
                    default:
                        break;
                }

            }
        }
    }
}

