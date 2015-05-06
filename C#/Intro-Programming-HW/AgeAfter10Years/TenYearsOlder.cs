//Problem 15.* Age after 10 Years
//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.


using System;

class TenYrsLater
{
    static void Main ()
    {
        Console.Write("Please state your birthday in the format DD/MM/YYYY: ");
        DateTime dOb = DateTime.Parse(Console.ReadLine()); //what if I use var or dynamic instead DateTime ????
        int ageNow = DateTime.Now.Year - dOb.Year;
        if (DateTime.Now.DayOfYear < dOb.DayOfYear)
            ageNow = ageNow - 1;
        Console.WriteLine("Right now you are {0} years old. In ten years, you will be {1} years old.", ageNow, ageNow + 10);
    }
}

/* Option 2:
 
class TenYearsOlder
{
    static void Main()
    {
        Console.Write("Please enter your birthdate in the format DD/MM/YYYY: ");
        var birthDate = DateTime.Parse(Console.ReadLine());
        int age = DateTime.Today.Year - birthDate.Year;
        if (birthDate > DateTime.Today.AddYears(-age)) age--;
        Console.WriteLine("Right now you are {0} years old. In ten years, you will be {1} years old.", age, age + 10);
    }
}

*/