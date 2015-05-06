//Problem 12. Parse URL
//  Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] 
//  and extracts from it the [protocol], [server] and [resource] elements.
//Example:
//URL 	
//http://telerikacademy.com/Courses/Courses/Details/212 	
//Information
//[protocol] = http
//[server] = telerikacademy.com
//[resource] = /Courses/Courses/Details/212

using System;
using System.Collections.Generic;

class UrlSplit
{
    static void Main()
    {
        Console.WriteLine("URL: ");
        string address = Console.ReadLine();
        int protEndIndex = address.IndexOf("://");
        string protocol = address.Substring(0, address.Length - address.Substring(protEndIndex).Length);
        int servEndIndex = address.IndexOf("/", protEndIndex + 3);
        string server = address.Substring(protEndIndex + 3, address.Length - address.Substring(servEndIndex).Length - (protEndIndex + 3));
        string resource = address.Substring(servEndIndex + 1);
        Console.WriteLine("\n[protocol] = " + protocol + "\n[server] = " + server + "\n[resource] = " + resource);
        Console.WriteLine();
    }
}
//another option
//using System.Text.RegularExpressions;
//string url = "http://telerikacademy.com/Courses/Courses/Details/212";
//var fragments = Regex.Match(url, "(.*)://(.*?)(/.*)").Groups;
//Console.WriteLine(fragments[1]);
//Console.WriteLine(fragments[2]);
//Console.WriteLine(fragments[3]);