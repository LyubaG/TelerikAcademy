//Problem 15.* Number calculations
//    Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
//    Use generic method (read in Internet about generic methods in C#).

using System;
using System.Collections.Generic;
using System.Linq;

class GenericCalcMethod
{
    static void Main()
    {
        GenericCalculate calc = new GenericCalculate();
        int maxValue = calc.CalculateMaxValue(2, 4, 5, 11, 7, 456, 1, 2, -2, -4, 0);
        Console.WriteLine("Max value {0}", maxValue);
        int minValue = calc.CalculateMinValue(2, 4, 5, 34, 7, 98, 1, 17, -2, -4, 0);
        Console.WriteLine("Min value {0}", minValue);
        var average = calc.CalculateAverage(3, 4.7, 5.3, 6, 7.1, -3);
        Console.WriteLine("Average {0}", average);
        var product = calc.CalculateProduct(2, 4, 5, 8, 7, 98, 1, 2, -2, -4, 0);
        Console.WriteLine("Product {0}", product);
        var sum = calc.CalculateSum(3, 4.7, 5.3, 6, 7.1, -3);
        Console.WriteLine("Sum {0}", sum);
    }

    public class GenericCalculate
    {
        public T CalculateMaxValue<T>(params T[] numbers) where T : IComparable
        {
            T max = default(T);
            T currentNumber = default(T);
            for (int i = 0; i < numbers.Length; i++)
            {
                currentNumber = numbers[i];
                if (currentNumber.CompareTo(max) > 0)
                {
                    max = currentNumber;
                }
            }
            return max;
        }
        public T CalculateMinValue<T>(params T[] numbers) where T : IComparable
        {
            T min = default(T);
            T currentNumber = default(T);
            for (int i = 0; i < numbers.Length; i++)
            {
                currentNumber = numbers[i];
                if (currentNumber.CompareTo(min) < 0)
                {
                    min = currentNumber;
                }
            }
            return min;
        }
        public T CalculateAverage<T>(params T[] numbers) where T : IComparable<T>
        {
            T sum = default(T);
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += (dynamic)numbers[i];
            }
            T average = sum / (dynamic)numbers.Length;
            return average;
        }
        public T CalculateProduct<T>(params T[] productNumbers) where T : IComparable<T>
        {
            T product = default(T);
            for (int row = 0; row < productNumbers.Length; row++)
            {
                product *= (dynamic)productNumbers[row];
            }
            return product;
        }
        public T CalculateSum<T>(params T[] numbers) where T : IComparable<T>
        {
            T sum = default(T);
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += (dynamic)numbers[i];
            }
            return sum;
        }
    }

}
//generic method uses T values, e.g.:
//    private static void Calculations<T1>(int[] arr) where T1 : IEnumerable
//    {
//        throw new NotImplementedException();
//    }
//