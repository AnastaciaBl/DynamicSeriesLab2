using System;
using System.Collections.Generic;

namespace DynamicSeries_lab2
{
    public class SeriesQuality
    {
        private double Average { get; set; }
        private double SSR { get; set; }
        private double SSE { get; set; }
        private double SST { get; set; }
        private double MSR { get; set; }
        private double MSE { get; set; }
        public const int AmountOfRegressionParameters = 2;
        public double FTest { get; set; }
        public double R2 { get; set; }

        public SeriesQuality(List<double> series, double a0Cof, double a1Cof)
        {
            FindAverage(series);
            FindSSR(series, a0Cof, a1Cof);
            FindSSE(series, a0Cof, a1Cof);
            FindSST();
            FindMSR();
            FindMSE(series.Count);
            CountFTestValue(series.Count);
            FindR2();
        }

        private void FindAverage(List<double> series)
        {
            double sum = 0;
            series.ForEach(s => sum += s);
            Average = sum / series.Count;
        }

        private double FindElementOfSeriesUsingRegression(double a0Cof, double a1Cof, int x)
        {
            return a0Cof + a1Cof * x;
        }

        private void FindSSR(List<double> series, double a0Cof, double a1Cof)
        {
            for (int i = 0; i < series.Count; i++)
                SSR += Math.Pow(FindElementOfSeriesUsingRegression(a0Cof, a1Cof, i + 1) - Average, 2);
        }

        private void FindSSE(List<double> series, double a0Cof, double a1Cof)
        {
            for (int i = 0; i < series.Count; i++)
                SSE += Math.Pow(series[i] - FindElementOfSeriesUsingRegression(a0Cof, a1Cof, i + 1), 2);
        }
        private void FindSST()
        {
            SST = SSR + SSE;
        }

        private void FindMSR()
        {
            MSR = SSR / (AmountOfRegressionParameters - 1);
        }

        private void FindMSE(int amountOfElements)
        {
            MSE = SSE / (amountOfElements - AmountOfRegressionParameters);
        }

        private void CountFTestValue(int amountOfElements)
        {
            FTest = Math.Round(MSR * (amountOfElements - AmountOfRegressionParameters) / MSE * (AmountOfRegressionParameters - 1), 4);
        }

        private double CountQuantileFishera(int v1, int v2)
        {
            return 0;
        }

        private double CountQuantileStudenta(int v1)
        {
            return 0;
        }

        public string IsAdequate(int amountOfElementsInSeries)
        {
            return FTest > CountQuantileFishera(AmountOfRegressionParameters - 1,
                       amountOfElementsInSeries - AmountOfRegressionParameters)
                ? "адекватная"
                : "неадекватная";
        }

        private void FindR2()
        {
            R2 = Math.Round(SSR / SST, 4);
        }

        public string IsSignificant(int amountOfElementsInSeries)
        {
            double t = Math.Sqrt(R2) * Math.Sqrt(amountOfElementsInSeries - 2) / Math.Sqrt(1 - R2);
            return Math.Abs(t) > CountQuantileStudenta(amountOfElementsInSeries - 2)
                ? "значимая"
                : "не значимая";
        }
    }
}
