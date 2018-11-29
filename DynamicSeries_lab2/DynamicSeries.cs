using System;
using System.Collections.Generic;

namespace DynamicSeries_lab2
{
    public class DynamicSeries
    {
        public List<string> Index { get; private set; }
        public List<double> Value { get; private set; }
        public readonly int AmountOfElements;
        public int Window { get; private set; }

        public DynamicSeries()
        {
            Index = new List<string>();
            Value = new List<double>();
        }

        public DynamicSeries(string fields, List<string> data) : this()
        {
            FillData(data);
            AmountOfElements = data.Count;
            FindWindow();
        }

        public DynamicSeries(List<double> values, List<string> index, int period) : this()
        {
            values.ForEach(v => Value.Add(v));
            index.ForEach(i => Index.Add(i));
            AmountOfElements = values.Count;
            Window = period;
        }

        private void FillData(List<string> data)
        {
            for (int i = 0; i < data.Count; i++)
            {
                var temp = data[i].Split(',');
                try
                {
                    temp[1] = temp[1].Replace('.', ',');
                    Value.Add(Convert.ToDouble(temp[1]));
                    Index.Add(temp[0]);
                }
                catch
                { }
            }
        }

        private void FindWindow()
        {
            int index = 0;
            if (Value[0] < Value[1])
            {
                while (Value[index]<Value[index+1])
                {
                    index++;
                }
                Window = index;
                while (Value[index]>Value[index+1])
                {
                    index++;
                }
                while (Value[index] < Value[index + 1])
                {
                    index++;
                }

                Window = index - Window;
            }
            else
            {
                while (Value[index] > Value[index + 1])
                {
                    index++;
                }
                Window = index;
                while (Value[index] < Value[index + 1])
                {
                    index++;
                }
                while (Value[index] > Value[index + 1])
                {
                    index++;
                }

                Window = index - Window;
            }
        }
    }
}
