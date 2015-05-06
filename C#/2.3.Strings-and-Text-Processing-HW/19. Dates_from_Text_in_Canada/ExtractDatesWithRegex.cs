//Problem 19. Dates from text in Canada
//    Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//    Display them in the standard date format for Canada.

using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

class ExtractDatesWithRegex
{
    static void Main()
    {
        string text = "Oioioi 123.10.1234 mmm 12.11.1290 but yes 9.18.1980 and more nonsense 14.08.2015 ";
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
        // Regex pattern = new Regex (@"\b\d{2}.\d{2}.\d{4}\b");
        MatchCollection dates = Regex.Matches(text, @"\b\d{2}.\d{2}.\d{4}\b");
        foreach (Match match in dates)
        {
            DateTime date = new DateTime();
            bool isValidDate = DateTime.TryParseExact(match.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date);
            if (isValidDate)
            {
                Console.WriteLine(date.ToString(CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern));
            }
        }

    }
}