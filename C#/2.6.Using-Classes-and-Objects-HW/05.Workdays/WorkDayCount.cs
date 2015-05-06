//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class WorkDayCount
{
    static void Main()
    {
        Console.WriteLine("Give a target date for the workday calculation (year, month, day): ");
        DateTime targetDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("The number of working days b/n today and that date is " + DayCount(targetDate) + " (including today).");
    }

    private static int DayCount ( DateTime endDate)
    {
        int workdayCount = 0;
        DateTime startDate = DateTime.Now;
        if (startDate > endDate)
        {
            DateTime temp = endDate;
            endDate = startDate;
            startDate = temp;
        }
        string[] holidayStrings = { "1/1/2015", "1/2/2015", "3/2/2015", "3/3/2015", "4/10/2015", "4/13/15", "5/1/15", "5/6/15", "9/21/15", 
                                      "9/22/15", "12/24/15", "12/25/15", "12/31/15" };
        DateTime[] holidaySet = Array.ConvertAll(holidayStrings, o =>
        {
            DateTime d = Convert.ToDateTime(o, CultureInfo.InvariantCulture);
            return (DateTime)d;
        }).ToArray();
        //another way to write DateTime arrays; this one is for workdays compensating for public holidays
        DateTime[] extraWorkDays = { new DateTime(2015, 1, 24),
                                new DateTime(2015, 3, 21),
                                new DateTime(2015, 9, 12),
                                new DateTime(2015, 12, 12)};

        while (endDate > startDate)
        {
            if ((!holidaySet.Contains(startDate.Date) &&
                startDate.DayOfWeek != DayOfWeek.Saturday &&
                 startDate.DayOfWeek != DayOfWeek.Sunday)
                || extraWorkDays.Contains(startDate))
            {
                workdayCount++;
            }
            startDate = startDate.AddDays(1);
        }
        return workdayCount;
    }
}


//TimeSpan totalPeriod = targetDate - startDate;
//int totalDays = totalPeriod.Days;
//int fullWeeks = totalDays / 7;
//int workdayCount = 5 * fullWeeks;
//        if (totalDays > fullWeeks)
//{
//    int remainingDays = totalDays % 7;
//    for (int i = 0; i <= remainingDays; i++)
//    {
//        DayOfWeek test = (DayOfWeek)(((int)startDate.DayOfWeek + i) % 7);
//        if (test >= DayOfWeek.Monday && test <= DayOfWeek.Friday)
//            workdayCount++;
//    }

//    //int firstDayOfWeek = startDate.DayOfWeek == DayOfWeek.Sunday ? 7 : (int)startDate.DayOfWeek;
//    //int lastDayOfWeek = targetDate.DayOfWeek == DayOfWeek.Sunday ? 7 : (int)targetDate.DayOfWeek;
//grrrrrr
//}