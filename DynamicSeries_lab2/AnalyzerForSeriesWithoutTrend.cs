using System;
using System.Collections.Generic;

namespace DynamicSeries_lab2
{
    class AnalyzerForSeriesWithoutTrend
    {
        public double KStatisticDifSigns { get; private set; }
        public const double U = 1.96;
        public bool WithoutTrend { get; private set; }
        public List<double> Correlation { get; private set; }
        public List<bool> CorCoefSignificance { get; private set; }

        public AnalyzerForSeriesWithoutTrend(List<double> series)
        {
            int amountOfElements = series.Count;
            Correlation = new List<double>();
            CorCoefSignificance = new List<bool>();
            CriterionOfDifferenceSigns(amountOfElements, series);
            HaveTrend();
            if (WithoutTrend)
                CountCorrelationInSeries(amountOfElements, series);
        }

        private void CriterionOfDifferenceSigns(int amountOfElements, List<double> series)
        {
            //find indicators
            int[] indicators = new int[amountOfElements - 1];
            int amountOfGrowthPoint = 0;
            for (int i = 0; i < indicators.Length; i++)
            {
                if (series[i] < series[i + 1])
                    indicators[i] = 1;
                else
                    indicators[i] = 0;
                amountOfGrowthPoint += indicators[i];
            }
            double M = (amountOfElements - 1) / 2;
            double D = (amountOfElements + 1) / 12;
            KStatisticDifSigns = (amountOfGrowthPoint - M) / Math.Sqrt(D);
        }

        private void HaveTrend()
        {
            WithoutTrend = Math.Abs(KStatisticDifSigns) <= U;
        }

        private void CountCorrelationInSeries(int amountOfElements, List<double> series)
        {
            for (int i = 0; i < amountOfElements / 2; i++)
            {
                var coef = CountCorrelation(i, amountOfElements, series);
                Correlation.Add(coef);
            }
        }

        private double CountCorrelation(int index, int amountOfElements, List<double> series)
        {
            double numerator = 0, denominatorFirstPart = 0, denominatorSecondPart = 0;
            for (int i = 0; i < amountOfElements - index; i++)
            {
                double temp = series[i] - (1.0 / (amountOfElements - index)) * SumOfElements(index, amountOfElements, series);
                numerator += temp * (series[i + index] - (1.0 / (amountOfElements - index)) * SumOfElementsWithShift(index, amountOfElements, series));
                denominatorFirstPart += Math.Pow(series[i] - (1.0 / (amountOfElements - index)) * SumOfElements(index, amountOfElements, series), 2);
                denominatorSecondPart += Math.Pow(series[i + index] - (1.0 / (amountOfElements - index)) * SumOfElementsWithShift(index, amountOfElements, series), 2);
            }
            double koef = 1.0 / (amountOfElements - index);
            numerator = koef * numerator;
            double denominator = Math.Pow(koef * denominatorFirstPart * koef * denominatorSecondPart, 0.5);
            return numerator / denominator;
        }

        private double SumOfElements(int index, int amountOfElements, List<double> series)
        {
            double res = 0;
            for (int i = 0; i < amountOfElements - index; i++)
                res += series[i];
            return res;
        }

        private double SumOfElementsWithShift(int index, int amountOfElements, List<double> series)
        {
            double res = 0;
            for (int i = 0; i < amountOfElements - index; i++)
                res += series[i + index];
            return res;
        }
    }
}
