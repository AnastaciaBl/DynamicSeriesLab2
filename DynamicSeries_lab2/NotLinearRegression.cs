using System;
using System.Collections.Generic;
using System.Linq;

namespace DynamicSeries_lab2
{
    public class NotLinearRegression
    {
        public double A0 { get; }
        public double A1 { get; }
        public double Gamma { get; }

        public NotLinearRegression(double a0, double a1, DynamicSeries series)
        {
            A0 = FindFirstParameter(a0);
            A1 = FindSecondParameter(a1);
            Gamma = FindGamma(series);
        }

        private double FindFirstParameter(double a0)
        {
            return Math.Pow(Math.E, Math.Pow(Math.E, a0));
        }

        private double FindSecondParameter(double a1)
        {
            return Math.Pow(Math.E, a1);
        }

        private double FindGamma(DynamicSeries series)
        {
            switch (series.AmountOfElements % 3)
            {
                case 0:
                    return FindGammaFirstOption(series);
                case 1:
                    return FindGammaSecondOption(series);
                case 2:
                    return FindGammaThirdOption(series);
            }

            return -1;
        }

        private double FindGammaFirstOption(DynamicSeries series)
        {
            int amountOfElementsInPart = series.AmountOfElements / 3;
            double m1 = FindMedian(series.Value, 0, amountOfElementsInPart);
            double m2 = FindMedian(series.Value, amountOfElementsInPart, amountOfElementsInPart);
            double m3 = FindMedian(series.Value, 2 * amountOfElementsInPart, amountOfElementsInPart);
            return CountGamma(m1, m2, m3);
        }

        private double FindGammaSecondOption(DynamicSeries series)
        {
            int amountOfElementsInPart = series.AmountOfElements / 3;
            double m1 = FindMedian(series.Value, 0, amountOfElementsInPart);
            double m2 = FindMedian(series.Value, amountOfElementsInPart, amountOfElementsInPart + 1);
            double m3 = FindMedian(series.Value, 2 * amountOfElementsInPart + 1, amountOfElementsInPart);
            return CountGamma(m1, m2, m3);
        }

        private double FindGammaThirdOption(DynamicSeries series)
        {
            int amountOfElementsInPart = series.AmountOfElements / 3;
            double m1 = FindMedian(series.Value, 0, amountOfElementsInPart + 1);
            double m2 = FindMedian(series.Value, amountOfElementsInPart + 1, amountOfElementsInPart);
            double m3 = FindMedian(series.Value, 2 * amountOfElementsInPart + 1, amountOfElementsInPart + 1);
            return CountGamma(m1, m2, m3);
        }

        private double FindMedian(List<double> values, int index, int amountOfElements)
        {
            return values.GetRange(index, amountOfElements)
                .OrderBy(v => v)
                .Average();
        }

        private double CountGamma(double m1, double m2, double m3)
        {
            return (m1 * m3 - m2 * m2) / (m1 - 2 * m2 + m3);
        }
    }
}
