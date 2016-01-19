namespace Methods
{
    using System;

    internal class GoodMethodsTest
    {
        private static void Main()
        {
            Console.WriteLine(Methods.CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(Methods.NumberToDigitName(5));

            Console.WriteLine(Methods.FindMax(5, -1, 3, 2, 14, 2, 3));

            Methods.PrintNumberWithPrecision(1.3);
            Methods.PrintNumberAsPercentage(0.75);
            Methods.PrintNumberAlignedRight(2.30);

            bool horizontal = Methods.IsLineHorizontal(-1, 2.5);
            bool vertical = Methods.IsLineVertical(3, 3);

            Console.WriteLine(Methods.CalculateDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal: " + horizontal);
            Console.WriteLine("Vertical: " + vertical);

            Student lisa = new Student("Kuma", "Lisa", new DateTime(2001, 12, 6), "Ist schlau");
            Student meca = new Student("Baba", "Meca", new DateTime(1996, 6, 23), "Loves honey");

            Console.WriteLine("{0} older than {1} -> {2}", lisa.FirstName, lisa.FirstName, lisa.IsOlderThan(meca));
        }
    }
}