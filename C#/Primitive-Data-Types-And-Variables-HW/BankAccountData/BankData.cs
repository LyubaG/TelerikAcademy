//Problem 11. Bank Account Data
//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class BankData
{
    static void Main()
    {
        string firstName = "Baba";
        string middleName = "Masha";
        string lastName = "Metsa";
        object fullName = firstName + " " + middleName + " " + lastName;
        decimal balance = 8000.12m; //m means literal for the decimal type
        string bankName = "Forest Bank";
        string iban = "BG11FORB12345789547";
        string bic = "BLAHFORB";
        ulong cardNumber1 = 121212343434000u;
        ulong cardNumber2 = 121212343434001u;
        ulong cardNumber3 = 121212343434002u;
        Console.WriteLine("Account holder: " + fullName 
        + "\nBalance: " + balance + " BGN\nBank: " + bankName
        + "\nIBAN: " + iban
        + "\nBIC: " + bic
        + "\nCredit Card 1: " + cardNumber1
        + "\nCredit Card 2: " + cardNumber2
        + "\nCredit Card 3: " + cardNumber3);
    }
}

