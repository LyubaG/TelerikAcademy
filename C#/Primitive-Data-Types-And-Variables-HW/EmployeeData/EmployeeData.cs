/* Problem 10. Employee Data
A marketing company wants to keep record of its employees. Each record would have the following characteristics:
    First name
    Last name
    Age (0...100)
    Gender (m or f)
    Personal ID number (e.g. 8306112507)
    Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.
*/

using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Baba";
        string lastName = "Metsa";
        byte age = 8;
        char gender = 'f';
        long idNum = 9702027684;
        int firmID = 27569999;
        Console.WriteLine("First name: {0}\nFamily Name: {1}\nAge: {2}\nGender: {3}\nID Number: {4}\nEmployee Number: {5}", firstName, lastName, age, gender, idNum, firmID);
    }
}
