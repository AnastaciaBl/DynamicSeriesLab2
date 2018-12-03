using System;

namespace DynamicSeries_lab2
{
    public static class Quantile
    {
        public static double CountQuantileFishera(int v1, int v2)
        {
            double answer = 0;
            double sigma = 1.0 / v1 + 1.0 / v2;
            double delta = 1.0 / v1 - 1.0 / v2;
            double u = 1.96;

            answer += u * Math.Sqrt(sigma / 2) - (1.0 / 6) * sigma * (u * u + 2);
            answer += Math.Sqrt(sigma / 2) *
                      ((sigma / 24) * (u * u + 3 * u) + (1.0 / 72) * (delta * delta / sigma) * (u * u * u + 11 * u));
            answer -= (delta * sigma / 120) * (u * u * u * u + 9 * u * u + 8);
            answer += (Math.Pow(delta, 3) / 3240 * sigma) * (3 * u * u * u * u + 7 * u * u - 16);
            answer += Math.Sqrt(sigma / 2) * ((sigma * sigma / 1920) * (Math.Pow(u, 5) + 20 * u * u * u + 15 * u) +
                                              (Math.Pow(delta, 4) / 2880) * (Math.Pow(u, 5) + 44 * u * u * u + 183 * u) +
                                              (Math.Pow(delta, 4) / 155520 * sigma * sigma) * (9 * Math.Pow(u, 5) - 284 * u * u * u - 1513 * u));
            return Math.Round(Math.Exp(2 * answer), 4);
        }

        public static double CountQuantileStudenta(int v)
        {
            double answer = 0;
            double u = 1.96;
            //double v = data.AmountOfElements - 2;
            answer += u;
            answer += 1 / v * 0.25 * (Math.Pow(u, 3) + u);
            answer += 1 / Math.Pow(v, 2) * 1.0 / 96 * (5 * Math.Pow(u, 5) + 16 * Math.Pow(u, 3) + 3 * u);
            answer += 1 / Math.Pow(v, 3) * 1.0 / 384 * (3 * Math.Pow(u, 7) + 19 * Math.Pow(u, 5) + 17 * Math.Pow(u, 3) -
                                                        15 * u);
            answer += 1 / Math.Pow(v, 4) * 1.0 / 92160 * (79 * Math.Pow(u, 9) + 779 * Math.Pow(u, 7) + 1482 * Math.Pow(u, 5) -
                                                          1920 * Math.Pow(u, 3) - 945 * u);
            return Math.Round(answer, 4);
        }
    }
}
