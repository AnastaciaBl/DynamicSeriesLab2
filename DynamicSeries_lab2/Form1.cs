﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace DynamicSeries_lab2
{
    public partial class Form1 : Form
    {
        public DynamicSeries Series { get; set; }
        public DynamicSeries SeriesAfterSmoothing { get; set; }
        public LinearRegression LinearRegression { get; set; }
        public NotLinearRegression NotLinearRegression { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        #region SmoothingTab
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            using (var openFile = new OpenFileDialog())
            {
                openFile.RestoreDirectory = true;
                openFile.Filter = "Text files (*.csv)|*.csv";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    using (var reader = new StreamReader(openFile.FileName))
                    {
                        var fields = reader.ReadLine();
                        var data = new List<string>();
                        while (!reader.EndOfStream)
                        {
                            data.Add(reader.ReadLine());
                        }
                        Series = new DynamicSeries(fields, data);
                        SeriesAfterSmoothing = MovingAverage.SmoothOverDynamicSeries(Series, Convert.ToInt32(tbWindow.Text));
                        FillNormalChart();
                        FillSmoothingChart();
                    }                    
                }
            }
        }

        private void FillNormalChart()
        {
            chNormal.Series[0].Points.Clear();
            for (int i = 0; i < Series.AmountOfElements; i++)
            {
                chNormal.Series[0].Points.AddXY(Series.Index[i], Series.Value[i]);
            }
        }

        private void FillSmoothingChart()
        {
            chSmoothing.Series[0].Points.Clear();
            for (int i = 0; i < SeriesAfterSmoothing.AmountOfElements; i++)
            {
                chSmoothing.Series[0].Points.AddXY(SeriesAfterSmoothing.Index[i], SeriesAfterSmoothing.Value[i]);
            }
        }
        #endregion

        #region LinearRegressionTab
        private void btnCount_Click(object sender, EventArgs e)
        {
            //linear trend
            FillLinearTrendChart(rbWithSmoothing.Checked);
            tbA0.Text = Math.Round(LinearRegression.A0, 4).ToString();
            tbA1.Text = Math.Round(LinearRegression.A1, 4).ToString();
            //not linear trend
            /*NotLinearRegression = new NotLinearRegression(LinearRegression.A0, LinearRegression.A1);
            FillNotLinearRegressionChart(rbWithSmoothing.Checked);
            tbNotLinearA0.Text = NotLinearRegression.A0.ToString();
            tbNotLinearA1.Text = NotLinearRegression.A1.ToString();*/
        }

        private void rbWithoutSmoothing_Click(object sender, EventArgs e)
        {
            rbWithoutSmoothing.Checked = true;
            rbWithSmoothing.Checked = false;
        }

        private void rbWithSmoothing_Click(object sender, EventArgs e)
        {
            rbWithSmoothing.Checked = true;
            rbWithoutSmoothing.Checked = false;
        }

        private void FillLinearTrendChart(bool withSmoothing)
        {
            chLinearTrend.Series[0].Points.Clear();
            chLinearTrend.Series[1].Points.Clear();
            if (withSmoothing)
            {
                LinearRegression = new LinearRegression(SeriesAfterSmoothing.Value);
                for (int i = 0; i < SeriesAfterSmoothing.AmountOfElements; i++)
                {
                    chLinearTrend.Series[0].Points.AddXY(SeriesAfterSmoothing.Index[i], SeriesAfterSmoothing.Value[i]);
                }
            }
            else
            {
                LinearRegression = new LinearRegression(Series.Value);
                for (int i = 0; i < SeriesAfterSmoothing.AmountOfElements; i++)
                {
                    chLinearTrend.Series[0].Points.AddXY(Series.Index[i], Series.Value[i]);
                }
            }
            for (int i = 0; i < SeriesAfterSmoothing.AmountOfElements; i++)
            {
                chLinearTrend.Series[1].Points.AddXY(Series.Index[i], LinearRegression.A0 + LinearRegression.A1*(i+1));
            }
        }
        #endregion

        #region NotLinearRegressionTab
        public void FillNotLinearRegressionChart(bool isSmoothing)
        {
            chNotLinear.Series[0].Points.Clear();
            chNotLinear.Series[1].Points.Clear();
            if (isSmoothing)
            {
                for (int i = 0; i < SeriesAfterSmoothing.AmountOfElements; i++)
                    chNotLinear.Series[0].Points.AddXY(SeriesAfterSmoothing.Index[i], SeriesAfterSmoothing.Value[i]);
            }
            else
            {
                for (int i = 0; i < SeriesAfterSmoothing.AmountOfElements; i++)
                    chNotLinear.Series[0].Points.AddXY(Series.Index[i], Series.Value[i]);
            }

            for (int i = 0; i < Series.AmountOfElements; i++)
                chNotLinear.Series[1].Points.AddXY(Series.Index[i], NotLinearRegression.A0 + NotLinearRegression.A1 * (i + 1));
        }
        #endregion
    }
}
