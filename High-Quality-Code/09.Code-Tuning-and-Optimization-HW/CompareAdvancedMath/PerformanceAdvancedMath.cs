namespace CompareAdvancedMath
{
    using System;
    using System.Diagnostics;

    public class PerformanceAdvancedMath
    {
        const int IterationCount = (int)1E7;
        static readonly Stopwatch stopwatch = new Stopwatch();

        static void DisplayExecutionTime(string title, Action action)
        {
            Console.Write("{0, -20}", title);
            stopwatch.Restart();
            action();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }
        
        public static void Main()
        {
            unchecked
            {
                {
                    DisplayExecutionTime("Square root float", () =>
                    {
                        for (float i = 1; i < IterationCount; i++)
                            Math.Sqrt(i);
                    });
                    DisplayExecutionTime("Square root double", () =>
                    {
                        for (double i = 1; i < IterationCount; i++)
                            Math.Sqrt(i);
                    });
                    DisplayExecutionTime("Square root decimal", () =>
                    {
                        for (decimal i = 1; i < IterationCount; i++)
                            Math.Sqrt((double)i); // well, not an ideal operation...
                    });
                }
                Console.WriteLine();
                {
                    DisplayExecutionTime("Ln float", () =>
                    {
                        for (float i = 1; i < IterationCount; i++)
                            Math.Log(i);
                    });
                    DisplayExecutionTime("Ln double", () =>
                    {
                        for (double i = 1; i < IterationCount; i++)
                            Math.Log(i);
                    });
                    DisplayExecutionTime("Ln decimal", () =>
                    {
                        for (decimal i = 1; i < IterationCount; i++)
                            Math.Log((double)i);
                    });
                }
                Console.WriteLine();
                {
                    DisplayExecutionTime("Sin float", () =>
                    {
                        for (float i = 1; i < IterationCount; i++)
                            Math.Sin(i);
                    });
                    DisplayExecutionTime("Sin double", () =>
                    {
                        for (double i = 1; i < IterationCount; i++)
                            Math.Sin(i);
                    });
                    DisplayExecutionTime("Sin decimal", () =>
                    {
                        for (decimal i = 1; i < IterationCount; i++)
                            Math.Sin((double)i);
                    });
                }
            }
        }
    }
}
