using System;

namespace DynamicSeries_lab2
{
    public class NotLinearRegression
    {
        public double A0 { get; set; }
        public double A1 { get; set; }

        public NotLinearRegression(double a0, double a1)
        {
            A0 = FindFirstParameter(a0);
            A1 = FindSecondParameter(a1);
        }

        private double FindFirstParameter(double a0)
        {
            return Math.Pow(Math.E, Math.Pow(Math.E, a0));
        }

        private double FindSecondParameter(double a1)
        {
            return Math.Pow(Math.E, a1);
        }
    }
}
