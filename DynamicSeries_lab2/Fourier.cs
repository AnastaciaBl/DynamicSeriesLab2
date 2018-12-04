using System;
using System.Collections.Generic;
using System.Linq;

namespace DynamicSeries_lab2
{
    public class Fourier
    {
        private DynamicSeries Series { get; }
        private int Period { get; }
        public List<double> Y { get; }
        public int K { get; } = 4;
        public double A0 { get; private set; }
        public List<double> Ak { get; }
        public List<double> Bk { get; }

        public Fourier(DynamicSeries series, int period)
        {
            Series = series;
            Period = period;
            Y = new List<double>();
            Ak = new List<double>();
            Bk = new List<double>();
            CountCoefs();
            FillYList();
        }

        private void CountCoefs()
        {
            A0 = CountA0();
            for (int i = 1; i <= K; i++)
            {
                Ak.Add(CountAk(i));
                Bk.Add(CountBk(i));
            }
        }

        private void FillYList()
        {
            for (int i = 0; i < Series.AmountOfElements; i++)
            {
                Y.Add(CountNewY(i + 1));
            }
        }

        public double CountNewY(int index)
        {
            double sum = 0;
            for (int i = 1; i <= K; i++)
            {
                sum += Ak[i - 1] * Math.Cos(index * ((2 * Math.PI * i) / Period)) +
                       Bk[i - 1] * Math.Sin(index * ((2 * Math.PI * i) / Period));
            }
            return A0 + sum;
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
