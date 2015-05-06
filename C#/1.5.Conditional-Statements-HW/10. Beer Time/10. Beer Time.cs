//Problem 10.* Beer Time
//• A beer time is after  1:00 PM  and before  3:00 AM .
//• Write a program that enters a time in format “hh:mm tt”
//(an hour in range [01...12], a minute in range [00…59] and AM / PM 
//designator) and prints  beer time  or  non-beer time  according to
//the definition above or  invalid time  if the time cannot be parsed.
//Note: You may need to learn how to parse dates and times. 

//Examples:
//time        result
//1:00 PM     beer time 
//4:30 PM     beer time 
//10:57 PM    beer time 
//8:30 AM     non-beer time 
//02:59 AM    beer time 
//03:00 AM    non-beer time 
//03:26 AM    non-beer time 

using System;
using System.Globalization;
using System.Threading;

class Beer_Time
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Enter the time in the format hh:mm tt (where tt is am/pm).");
        string input = Console.ReadLine();
        DateTime time;
        DateTime beerTimeStart = DateTime.Parse("1:00 PM");
        DateTime beerTimeEnd = DateTime.Parse("3:00 AM");
        if (DateTime.TryParse(input, out time))
        {
            if (time >= beerTimeStart || time < beerTimeEnd) //Note: && is not used because of the zeroing of time at midnight...
            {
                Console.WriteLine("Beer time hip hip hooray!");
            }
            else Console.WriteLine("Oh, dear, enjoy some tea for now...");
        }
        else Console.WriteLine("Invalid input.");

    }
}

