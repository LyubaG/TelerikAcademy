//Problem 1. Strings in C#.
//    Describe the strings in C#.
//    What is typical for the string data type?
//    Describe the most important methods of the String class.

using System;

class StringDescription
{
    static void Main()
    {
        //Strings are sequences of characters, made up from Unicode symbols; 
        //they are represented by the string data type (System.String).
        //What's typical about the data type is that string objects are
        //like arrays of characters (char[]) with a fixed length and elements accessible by their 
        //indices; they are read-only (immutable) and are stored in the managed heap (dynamic memory).
        //Strings are a reference type, which correlates to their immutability.
        //The most important string methods are:
        //ToString(formatString) - converts anything to string with formatting
        //String.Format - for use of text templates
        //string.Compare(str1, str2, false) - case-sensitive dictionary-based string comparison
        //string.Compare(str1, str2, true) - case-insensitive dictionary-based string comparison
        //string.Equals(string2) - case sensitive comparison, just as '=='
        //string.String.Concat(str1, str2) - combines strings into a new string
        //IndexOf(string), LastIndexOf(string) - first and last occurence of substring; -1 means not found
        //IndexOf(string str, int startIndex) - first occurrence starting at given position
        //string.Substring(int startIndex, int length) / string.Substring(int startIndex) - extract substring
        //string[] --> string.Split(params char[]) - splits a string by given characters and fills an array
        //Replace(string, string) – replaces all occurrences of given string with another, creates new string
        //Remove(index, length) – deletes part of a string and produces new string as result
        //string.ToUpper / string.ToLower - changes case
        //string.Trim() - trims empty spaces/ string.Trim(chars) / string.TrimStart and string.TrimEnd - only trims one side
    }

}

