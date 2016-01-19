namespace ExamRefactoring_Printing
{
    using System;
    
    public class PrintingMoney
    {
        private const int sheetsPerRealm = 500;

        public static void Main()
        {
            double studentsCount = double.Parse(Console.ReadLine());
            double sheetsPerStudent = double.Parse(Console.ReadLine());
            double priceOfRealm = double.Parse(Console.ReadLine());
            double moneyNeeded = ((studentsCount * sheetsPerStudent) / sheetsPerRealm) * priceOfRealm;
            Console.WriteLine("{0:0.00}", moneyNeeded);
        }
    }
}
