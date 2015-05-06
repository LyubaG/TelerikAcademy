//Problem 18. Extract e-mails
//    Write a program for extracting all email addresses from given text.
//    All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Collections.Generic;
using System.Linq;

class EMailAddresses
{
    private static char[] punctuation = "*&#~!`$%^()-+=|\\/[]{}?<>';,:".ToCharArray();

    static void Main()
    {
        string exampleTxt = "Bum bam pow wow mamma.mia@abv.bg is blah brum drun, and fakemama@yahoo.com. Boom bam @ the bridge: hail#mary@heaven.com and god@hallelujah.";
        string[] words = exampleTxt.Split(' ');
        List<string> emails = new List<string>();
        //take care of separator punctuation at the end of the words
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i].TrimEnd(new char[] { '!', '?', ';', ':', '.', ',' });   //more chars can be included here, but those are the main in-sentence separators
        }

        foreach (var word in words.Where(word => word.Contains("@") && word.Contains(".") && ContainsOneCharacterInstance(word, "@")))
        {
            if (ContainsPunctuation(word))
            {
                continue;
            }
            if (word.IndexOf('@') < word.LastIndexOf('.'))
            {
                if (word.Contains("_") && word.IndexOf('@') < word.LastIndexOf('_')) // '_' is allowed in e-mail addresses
                {
                    continue;
                }
                else
                    emails.Add(word);
            }

        }
        foreach (var item in emails)
        {
            Console.WriteLine(item);
        }
    }

    static bool ContainsOneCharacterInstance(string word, string ch)
    {
        var intersection = word.Intersect(ch).ToList();
        if (intersection.Count != 1)
            return false; // Make sure there is only one character in the text
        // Get a count of all of the one found character
        if (1 == word.Count(t => t == intersection[0]))
            return true;

        return false;
    }

    static bool ContainsPunctuation(string word)
    {
        var intersection = word.Intersect(punctuation).ToList();
        if (intersection.Count > 0)
        {
            return true;
        }
        return false;
    }
}


//if (word.LastIndexOfAny(new char[] { '!', '?', ';', ':', '.', ',' }) != word.Length - 1)   