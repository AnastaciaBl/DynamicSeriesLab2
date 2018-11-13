using System;
using System.Collections.Generic;

namespace DynamicSeries_lab2
{
    public class LinearRegression
    {
        public double A0 { get; set; }
        public double A1 { get; set; }

        public LinearRegression(List<double> values)
        {
            FindCoefficients(values, values.Count);
        }

        private void FindCoefficients(List<double> values, int amountOfElements)
        {
            double simpleSum = FindSimpleSum(values);
            double complexSum = FindComplexSum(values, amountOfElements);
            A0 = FindFirstParameter(simpleSum, complexSum, amountOfElements);
            A1 = FindSecondParameter(simpleSum, complexSum, amountOfElements);
        }

        private double FindFirstParameter(double simpleSum, double complexSum, int amountOfElements)
        {
            double param;
            double n2 = amountOfElements * amountOfElements;
            double n4 = Math.Pow(amountOfElements, 4);
            param = (2 * n2 + 2) * (simpleSum * (2 * amountOfElements + 1) - 3 * complexSum) / (n4 - n2);
            return param;
        }

        private double FindSecondParameter(double simpleSum, double complexSum, int amountOfElements)
        {
            double param = 6 * (2 * complexSum - simpleSum * (amountOfElements + 1)) /
                    (Math.Pow(amountOfElements, 3) - amountOfElements);
            return param;
        }

        private double FindSimpleSum(List<double> values)
        {
            double sum = 0;
            values.ForEach(v => sum += v);
            return sum;
        }

        private double FindComplexSum(List<double> values, int amountOfElements)
        {
            double sum = 0;
            for (int i = 0; i < amountOfElements; i++)
            {
                sum += values[i] * (i + 1);
            }
            return sum;
        }
    }
}
