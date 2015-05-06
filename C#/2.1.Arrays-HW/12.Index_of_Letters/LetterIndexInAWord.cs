//Problem 12. Index of letters
//    Write a program that creates an array containing all letters from the alphabet (A-Z).
//    Read a word from the console and print the index of each of its letters in the array.

using System;


    class LetterIndexInAWord
    {
        static void Main()
        {
            char[] letters = new char[26];
            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = (char)(i + 65);
            }

            Console.Write("Enter your word (preferably in capital letters): ");
            string word = Console.ReadLine();

            foreach (char letter in word)
            {
                Console.WriteLine("'{0}' index: {1} ", letter, Array.IndexOf(letters, char.ToUpperInvariant(letter)));
            }
        }
    }

