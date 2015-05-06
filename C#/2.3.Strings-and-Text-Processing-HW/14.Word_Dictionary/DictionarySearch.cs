//Problem 14. Word dictionary
//    A dictionary is stored as a sequence of text lines containing words and their explanations.
//    Write a program that enters a word and translates it by using the dictionary.

//Sample dictionary:
//input 	     output
//.NET 	         platform for applications from Microsoft
//CLR 	         managed execution environment for .NET
//namespace 	hierarchical organization of classes

using System;
using System.Collections.Generic;
using System.Linq;

class DictionarySearch
{
    static void Main()
    {
        var dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        dictionary.Add("cat", "the purpose of the Internet's existence");
        dictionary.Add(".NET", "platform for applications from Microsoft");
        dictionary.Add("CLR", "managed execution environment for .NET");
        dictionary.Add("namespace", "hierarchical organization of classes");

        Console.Write("Word to find: ");
        string soughtWord = Console.ReadLine();
        bool wordFound = false;
        if (dictionary.ContainsKey(soughtWord))
        {
            Console.WriteLine("{0} --> {1}", soughtWord, dictionary[soughtWord]);
            wordFound = true;
        }
        else if (wordFound == false)
        {
            Console.WriteLine("Whoopsie...not found.");
        }
    }
}

//option2:
//string[] dictionary ={".NET: platform for applications from Microsoft",
//                        "CLR: managed execution environment for .NET",
//                        "namespace: hierarchical organization of classes"};
//Console.Write("Enter word: ");
//string soughtWord = Console.ReadLine();
//soughtWord = soughtWord.ToLower();
//int soughtIndex = -1;
//for (int i = 0; i < dictionary.Length; i++)
//{
//    string firstWord = dictionary[i].Substring(0, dictionary[i].IndexOf(':'));
//    firstWord = firstWord.ToLower();
//    if (soughtWord == firstWord)
//    {
//        soughtIndex = i;
//        break;
//    }
//}
//if (soughtIndex >= 0)
//{
//    Console.WriteLine(dictionary[soughtIndex]);
//}
//else
//{
//    Console.WriteLine("Not found");
//}