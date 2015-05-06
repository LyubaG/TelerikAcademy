//Problem 25. Extract text from HTML
//    Write a program that extracts from given HTML file its title (if available), 
//and its body text without the HTML tags.
//Example input:
//<html>
//  <head><title>News</title></head>
//  <body><p><a href="http://academy.telerik.com">Telerik
//    Academy</a>aims to provide free real-world practical
//    training for young people who want to turn into
//    skilful .NET software engineers.</p></body>
//</html>
//Output:
//Title: News
//Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ExtractFromHtml
{
    static void Main()
    {
        //test text = string htmlText = "<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">Telerik Academy</a> aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body></html>";
        Console.WriteLine("Enter full text: ");
        string text = Console.ReadLine();
        StringBuilder finalText = new StringBuilder();
        int startIndex = text.IndexOf("<title>") + 7;
        int endIndex = text.IndexOf("</title>");
        finalText.Append("Title: " + text.Substring(startIndex, endIndex - startIndex));
        finalText.Append(Environment.NewLine + "Text: ");

        startIndex = text.IndexOf(">", text.IndexOf("<body>")) + 1;
        endIndex = text.IndexOf("<", startIndex);
        while (startIndex != -1 && endIndex != -1)
        {
            finalText.Append(text.Substring(startIndex, endIndex - startIndex));
            startIndex = text.IndexOf(">", endIndex) + 1;
            endIndex = text.IndexOf("<", startIndex);
        }
        Console.WriteLine(finalText);
    }
}