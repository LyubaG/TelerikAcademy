//Problem 8. Extract sentences
//    Write a program that extracts from a given text all sentences containing given word.
//Example:
//The word is: in
//The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.
//Consider that the sentences are separated by . and the words – by non-letter symbols.

using System;
using System.Linq;
using System.Text;

class FindWordInSentence
{
    static void Main()
    {
        Console.WriteLine("Enter text: ");
        string text = Console.ReadLine();
        Console.WriteLine("Enter word: ");
        string soughtWord = Console.ReadLine();
        var finalText = new StringBuilder();
        string[] sentences = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var sentence in sentences)
        {
            int currentIndex = sentence.IndexOf(soughtWord, StringComparison.CurrentCultureIgnoreCase);
            while (currentIndex >= 0)
            {
                if (!char.IsLetter(sentence[currentIndex - 1]) && !char.IsLetter(sentence[currentIndex + soughtWord.Length]))
                {
                    finalText.Append(sentence.Trim());
                    finalText.Append(". ");
                }
                currentIndex = sentence.IndexOf(soughtWord, currentIndex + 1, StringComparison.CurrentCultureIgnoreCase);
            }
        }
        Console.WriteLine();
        Console.WriteLine(finalText);
        Console.WriteLine();
    }
}

//another way:
// string[] sentences = text.Split('.');
//foreach (string sentence in sentences)
//{
//string[] words = sentence.Split(' ');
//if(words.Contains("in"))
//{
//Console.WriteLine(sentence);
//}
//}