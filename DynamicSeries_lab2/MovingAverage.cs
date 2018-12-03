using System.Collections.Generic;

namespace DynamicSeries_lab2
{
    public static class MovingAverage
    {
        private const int Period = 7;
        private static DynamicSeries Series { get; set; }

        public static DynamicSeries SmoothOverDynamicSeries(DynamicSeries series)
        {
            Series = series;
            var newValues = new List<double>();
            AddFirstThreeValues(newValues, 0);
            AddMiddleValues(newValues, 3 * Period, Series.AmountOfElements - 3 * Period);
            AddLastThreeValues(newValues, Series.AmountOfElements - 3 * Period);
            return new DynamicSeries(newValues, series.Index, series.Window);
        }

        private static void AddFirstThreeValues(List<double> list, int startIndex)
        {
            double u1 = (1.0 / 126) * (117 * Series.Value[startIndex] + 24 * Series.Value[startIndex + 1] -
                                       12 * Series.Value[startIndex + 2] - 12 * Series.Value[startIndex + 3] +
                                       3 * Series.Value[startIndex + 4] + 12 * Series.Value[startIndex + 5] -
                                       6 * Series.Value[startIndex + 6]);
            startIndex += Period;
            double u2 = (1.0 / 126) * (24 * Series.Value[startIndex] + 57 * Series.Value[startIndex + 1] +
                                       48 * Series.Value[startIndex + 2] + 18 * Series.Value[startIndex + 3] -
                                       12 * Series.Value[startIndex + 4] - 21 * Series.Value[startIndex + 5] +
                                       12 * Series.Value[startIndex + 6]);
            startIndex += Period;
            double u3 = (1.0 / 126) * (-12 * Series.Value[startIndex] + 48 * Series.Value[startIndex + 1] +
                                       57 * Series.Value[startIndex + 2] + 36 * Series.Value[startIndex + 3] +
                                       6 * Series.Value[startIndex + 4] - 12 * Series.Value[startIndex + 5] +
                                       3 * Series.Value[startIndex + 6]);
            AddValues(list, u1);
            AddValues(list, u2);
            AddValues(list, u3);
        }

        private static void AddLastThreeValues(List<double> list, int startIndex)
        {
            double u1 = (1.0 / 42) * (1 * Series.Value[startIndex] - 4 * Series.Value[startIndex + 1] +
                                       2 * Series.Value[startIndex + 2] + 12 * Series.Value[startIndex + 3] +
                                       19 * Series.Value[startIndex + 4] + 16 * Series.Value[startIndex + 5] -
                                       4 * Series.Value[startIndex + 6]);
            startIndex += Period;
            double u2 = (1.0 / 42) * (4 * Series.Value[startIndex] - 7 * Series.Value[startIndex + 1] -
                                       4 * Series.Value[startIndex + 2] + 6 * Series.Value[startIndex + 3] +
                                       16 * Series.Value[startIndex + 4] + 19 * Series.Value[startIndex + 5] +
                                       8 * Series.Value[startIndex + 6]);
            startIndex += Period;
            double u3 = (1.0 / 42) * (-2 * Series.Value[startIndex] + 4 * Series.Value[startIndex + 1] +
                                       1 * Series.Value[startIndex + 2] - 4 * Series.Value[startIndex + 3] -
                                       4 * Series.Value[startIndex + 4] + 8 * Series.Value[startIndex + 5] +
                                       39 * Series.Value[startIndex + 6]);
            AddValues(list, u1);
            AddValues(list, u2);
            AddValues(list, u3);
        }

        private static void AddMiddleValues(List<double> list, int startIndex, int endIndex)
        {
            int amountOfLevels = (endIndex - startIndex) / Period;
            for(int i=0;i<amountOfLevels;i++)
            {
                double u = (1.0 / 21) * (-2 * Series.Value[startIndex] + 3 * Series.Value[startIndex + 1] +
                                          6 * Series.Value[startIndex + 2] + 7 * Series.Value[startIndex + 3] +
                                          6 * Series.Value[startIndex + 4] + 3 * Series.Value[startIndex + 5] -
                                          2 * Series.Value[startIndex + 6]);
                AddValues(list, u);
                startIndex += Period;
            }

            for (; startIndex < endIndex; startIndex++)
                list.Add(Series.Value[startIndex]);
        }

        private static void AddValues(List<double> list, double value)
        {
            for (int i = 0; i < Period; i++)
                list.Add(value);
        }
    }
}
