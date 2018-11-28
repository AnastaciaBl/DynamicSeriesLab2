using System;
using System.Collections.Generic;
using System.Linq;

namespace DynamicSeries_lab2
{
    class Fourier
    {
        private DynamicSeries Series { get; }
        private int Period { get; }
        public List<double> Y { get; }
        public int K { get; } = 4;

        public Fourier(DynamicSeries series, int period)
        {
            Series = series;
            Period = period;
            Y = new List<double>();
            FillYList();
        }

        private void FillYList()
        {
            double A0 = CountA0();
            for (int i = 0; i < Series.AmountOfElements; i++)
            {
                CountNewY(i + 1, A0);
            }
        }

        private void CountNewY(int index, double a0)
        {
            double sum = 0;
            for (int i = 1; i <= K; i++)
            {
                double aK = CountAk(i);
                double bK = CountBk(i);
                sum += aK * Math.Cos(index * ((2 * Math.PI * i) / Period)) +
                       bK * Math.Sin(index * ((2 * Math.PI * i) / Period));
            }
            Y.Add(a0 + sum);
        }

        private double CountA0()
        {
            return (1.0 / Series.AmountOfElements) * Series.Value.Sum();
        }

        private double CountAk(int k)
        {
            double sum = 0;
            for (int i = 0; i < Series.AmountOfElements; i++)
            {
                sum += Series.Value[i] * Math.Cos((i + 1) * ((2 * k * Math.PI) / Period));
            }

            return (2.0 / Series.AmountOfElements) * sum;
        }

        private double CountBk(int k)
        {
            double sum = 0;
            for (int i = 0; i < Series.AmountOfElements; i++)
            {
                sum += Series.Value[i] * Math.Sin((i + 1) * ((2 * k * Math.PI) / Period));
            }

            return (2.0 / Series.AmountOfElements) * sum;
        }
    }
}
