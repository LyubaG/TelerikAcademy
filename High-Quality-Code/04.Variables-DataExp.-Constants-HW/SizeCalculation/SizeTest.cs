namespace SizeCalculation
{
    using System;

    public class SizeTest
    {
        public static void Main()
        {
            var startingSize = new Size(12, 5.3);
            var sizeAfterRotation = startingSize.GetRotatedSize(42.7);

            Console.WriteLine(startingSize);
            Console.WriteLine(sizeAfterRotation);
        }
    }
}
