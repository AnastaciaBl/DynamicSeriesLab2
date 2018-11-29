using System.Collections.Generic;
using System.Linq;

namespace DynamicSeries_lab2
{
    public static class MovingAverage
    {
        public static DynamicSeries SmoothOverDynamicSeries(DynamicSeries series, int window)
        {
            int amountOfIntervals = series.AmountOfElements / window;
            int amountOfLastElements = series.AmountOfElements - amountOfIntervals * window;
            var averages = FindAverageOfIntervals(amountOfIntervals, window, series.Value);
            var newValues = CreateNewAverageValues(averages, series.AmountOfElements, window);
            if (amountOfLastElements != 0)
            {
                var smoothing = FindSmoothingOnLastElements(amountOfLastElements, series.Value, window);
                AddLastElements(newValues, smoothing, amountOfLastElements);
            }            
            return new DynamicSeries(newValues, series.Index, series.Window);
        }

        private static double[] FindAverageOfIntervals(int amountOfIntervals, int window, List<double> values)
        {
            var averages = new double[amountOfIntervals];
            int index = 0;
            for (int i = 0; i < amountOfIntervals; i++)
            {
                int counter = 0;
                var elementsInInterval = new List<double>();
                while(counter < window)
                {
                    elementsInInterval.Add(values[index]);
                    index++;
                    counter++;
                }
                averages[i] = CountAverage(elementsInInterval, window);
            }
            return averages;
        }

        private static double FindSmoothingOnLastElements(int amountOfLastElements, List<double> values, int window)
        {
            double smoothing = (values[values.Count - 1] - values[values.Count - amountOfLastElements]) / (window - 1);
            return smoothing;
        }

        private static double CountAverage(List<double> elements, int window)
        {
            double average = 0;
            elements.ForEach(e => average += e);
            average = average / window;
            return average;
        }

        private static List<double> CreateNewAverageValues(double[] averages, int amountOfElements, int window)
        {
            var newValues = new List<double>();
            int index = 0;
            for (int i = 0; i < averages.Length; i++)
            {
                int counter = 0;
                while(counter < window && index != amountOfElements)
                {
                    newValues.Add(averages[i]);
                    index++;
                    counter++;
                }
            }
            return newValues;
        }

        private static void AddLastElements(List<double> values, double smoothing, int amountOfElements)
        {
            double valueOfLastElementInInterval = values.Last();
            for (int i = 0; i < amountOfElements; i++)
            {
                values.Add(valueOfLastElementInInterval + smoothing);
            }
        }
    }
}
