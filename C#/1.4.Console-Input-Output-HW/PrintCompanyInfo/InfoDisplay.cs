//Problem 2. Print Company Information
//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.


using System;

class InfoDisplay
{
    static void Main()
    {
        Console.WriteLine("Company name:");
        string compName = Console.ReadLine();
        Console.WriteLine("Company address:");
        string compAddress = Console.ReadLine();
        Console.WriteLine("Phone number:");
        string compPhone = Console.ReadLine();
        Console.WriteLine("Fax number:");
        string compFax = Console.ReadLine();
        Console.WriteLine("Web site:");
        string compWebSite = Console.ReadLine();
        Console.WriteLine("Manager first name:");
        string managFName = Console.ReadLine();
        Console.WriteLine("Manager last name:");
        string managLName = Console.ReadLine();
        Console.WriteLine("Manager age:");
        string managAge = (Console.ReadLine());
        Console.WriteLine("Manager phone:");
        string managPhone = Console.ReadLine();
        Console.Clear();

        string formattedtext = "{0,-35}{1}";
        Console.WriteLine(":::Company details:::");
        Console.WriteLine(formattedtext, "Name: ", compName);
        Console.WriteLine(formattedtext, "Address: ", compAddress);
        Console.WriteLine(formattedtext, "Phone: ", compAddress);
        Console.WriteLine(formattedtext, "Fax: ", compFax);
        Console.WriteLine(formattedtext, "Web site: ", compWebSite);
        Console.WriteLine("\n:::Manager details:::");
        Console.WriteLine(formattedtext, "First name: ", managFName);
        Console.WriteLine(formattedtext, "Last name: ", managLName);
        Console.WriteLine(formattedtext, "Age: ", managAge);
        Console.WriteLine(formattedtext, "Phone number: ", managPhone);

    }
}
