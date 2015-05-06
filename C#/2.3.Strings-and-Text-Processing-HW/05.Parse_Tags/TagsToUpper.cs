//Problem 5. Parse tags
//    You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//    The tags cannot be nested.
//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class TagsToUpper
{
    static void Main()
    {
        Console.WriteLine("Enter text: ");
        string text = Console.ReadLine();
        int currentIndex = 0;
        var finalText = new StringBuilder();
        while (currentIndex < text.Length)
        {
            int tagIndex = text.IndexOf("<upcase>", currentIndex);
            int endTagIndex = text.IndexOf("</upcase>", currentIndex);
            if (tagIndex < 0 || endTagIndex < 0)
            {
                finalText.Append(text.Substring(currentIndex, text.Length - currentIndex));
                break;
            }
            finalText.Append(text.Substring(currentIndex, tagIndex - currentIndex));
            string tempText = (text.Substring(tagIndex + 8, endTagIndex - tagIndex - 8)).ToUpper();
            finalText.Append(tempText);
            currentIndex = endTagIndex + 9;

        }
        Console.WriteLine(finalText);
        Console.WriteLine();
    }
}
