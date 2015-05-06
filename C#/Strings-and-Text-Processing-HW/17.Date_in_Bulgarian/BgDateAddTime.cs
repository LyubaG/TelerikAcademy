//Problem 17. Date in Bulgarian
//    Write a program that reads a date and time given in the format: day.month.year hour:minute:second and 
//prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

using System;
using System.Globalization;
using System.Threading;

class BgDateAddTime
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        Console.Write("Enter the date (dd.MM.yyyy HH:mm:ss): ");
        //test: 28.02.2015 17:05:00
        DateTime inputDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy H:m:s", CultureInfo.CurrentCulture);
        inputDate = inputDate.AddHours(6.5);
        Console.WriteLine(inputDate.ToString("dddd, dd.MM.yyyy HH:mm:ss"));
    }
}
