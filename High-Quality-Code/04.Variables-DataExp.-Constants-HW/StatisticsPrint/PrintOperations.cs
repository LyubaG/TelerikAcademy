namespace StatisticsPrint
{
    using System;
    using System.Linq;

    public class PrintOperations
    {
        public static void Main()
        {
            double[] dataSet = new double[] { 12.2, -23.0, 5.4, 4.5, 0.0, 18.2, -10.9, 150.5 };
            PrintStatistics(dataSet);
        }

        public static void PrintStatistics(double[] numbers)
        {
            Console.WriteLine("The 'statistics' are: ");
            PrintMin(numbers);
            PrintMax(numbers);
            PrintAverage(numbers);
        }

        public static void PrintMin(double[] numbers)
        {
            double smallestNumber = numbers.Min();
            Console.WriteLine("The smallest number is {0}.", smallestNumber);
        }

        private static void PrintMax(double[] numbers)
        {
            double largestNumber = numbers.Max();
            Console.WriteLine("The largest number is {0}.", largestNumber);
        }

        private static void PrintAverage(double[] numbers)
        {
            double average = numbers.Average();
            Console.WriteLine("The average of the numbers set is {0}.", average);
        }
    }
}
