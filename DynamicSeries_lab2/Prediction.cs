using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSeries_lab2
{
    class Prediction
    {
        private double A0 { get; }
        private double A1 { get; }
        private double Gamma { get; }
        private List<double> Series { get; }
        private bool IsLinear { get; }
        private Fourier Fourier { get; }

        public Prediction(double a0, double a1, List<double> series, bool isLinear, Fourier fourier)
        {
            A0 = a0;
            A1 = a1;
            Series = series;
            IsLinear = isLinear;
            Fourier = fourier;
        }

        public Prediction(double a0, double a1, double gamma, List<double> series, bool isLinear, Fourier fourier) : 
            this(a0, a1, series, isLinear, fourier)
        {
            Gamma = gamma;
        }

        public double PredictValue(int index)
        {
            double value = IsLinear ? (A0 + A1 * index) : (Gamma * Math.Pow(A0, Math.Pow(A1, index)));
            value += Fourier.CountNewY(index);
            return value;
        }
    }
}
