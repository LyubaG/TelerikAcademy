// Note: yes, I know the solution itself is not great, but this gave me a nightmare 
// and was the point where my exam was finished... :/

namespace ExamRefactoring_SaddyKopper
{
    using System;

    public class MathTransformations
    {
        public static void Main()
        {
            string numberInput = Console.ReadLine();
            long globalProduct = 1;
            int transformationsCount = 0;
            int currentSum = 0;
            
            while (true)
            {
                long nextNumber = 0;

                while (numberInput.Length > 0)
                {
                    numberInput = numberInput.Substring(0, numberInput.Length - 1);
                    currentSum = 0;
                    int counter = 0;
                    foreach (char digit in numberInput)
                    {
                        if (counter % 2 == 0)
                        {
                            currentSum += digit - 48;
                        }

                        counter++;
                    }

                    globalProduct = globalProduct * currentSum;
                    nextNumber = globalProduct;
                }

                string nextNumberToText = nextNumber.ToString();

                // If one digit left
                if (nextNumberToText.Length < 2 && transformationsCount < 10) 
                {
                    Console.WriteLine(transformationsCount);
                    Console.WriteLine(nextNumber);
                    break;
                }
                else if (transformationsCount > 9)
                {
                    Console.WriteLine(nextNumber);
                    break;
                }
                else
                {
                    numberInput = nextNumber.ToString();
                    transformationsCount++;
                }
            }
        }
    }
}