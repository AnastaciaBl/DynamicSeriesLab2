﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DynamicSeries_lab2
{
    public partial class Form1 : Form
    {
        public DynamicSeries Series { get; set; }
        public DynamicSeries SeriesAfterSmoothing { get; set; }
        public DynamicSeries SeriesAfterExponentialSmoothing { get; set; }
        public LinearRegression LinearRegression { get; set; }
        public NotLinearRegression NotLinearRegression { get; set; }
        public SeriesQuality QualityIndicatorsLinearTrend { get; set; }
        public SeriesQuality QualityIndicatorsNotLinearTrend { get; set; }
        public Fourier Fourier { get; set; }

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
                        int period = Convert.ToInt32(tbWindow.Text);
                        SeriesAfterSmoothing = MovingAverage.SmoothOverDynamicSeries(Series);
                        SeriesAfterExponentialSmoothing = ExponentialSmoothing.SmoothOverDynamicSeries(Series);
                        FillNormalChart();
                        FillFourierChart(period);
                    }                    
                }
            }
        }

        private void FillNormalChart()
        {
            chNormal.Series[0].Points.Clear();
            chNormal.Series[1].Points.Clear(); //moving average
            chNormal.Series[2].Points.Clear(); //exponential
            for (int i = 0; i < Series.AmountOfElements; i++)
            {
                chNormal.Series[0].Points.AddXY(Series.Index[i], Series.Value[i]);
                chNormal.Series[1].Points.AddXY(SeriesAfterSmoothing.Index[i], SeriesAfterSmoothing.Value[i]);
                chNormal.Series[2].Points.AddXY(SeriesAfterExponentialSmoothing.Index[i],
                    SeriesAfterExponentialSmoothing.Value[i]);
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
            NotLinearRegression = rbWithSmoothing.Checked
                ? new NotLinearRegression(LinearRegression.A0, LinearRegression.A1, SeriesAfterSmoothing)
                : new NotLinearRegression(LinearRegression.A0, LinearRegression.A1, Series);
            FillNotLinearRegressionChart(rbWithSmoothing.Checked);
            tbNotLinearA0.Text = NotLinearRegression.A0.ToString();
            tbNotLinearA1.Text = NotLinearRegression.A1.ToString();

            CountQuality(rbWithSmoothing.Checked);
            tbLinearTrendF.Text =
                $"{QualityIndicatorsLinearTrend.FTest}, {QualityIndicatorsLinearTrend.IsAdequate(Series.AmountOfElements)}";
            tbLinearTrendR2.Text =
                $"{QualityIndicatorsLinearTrend.R2}, {QualityIndicatorsLinearTrend.IsSignificant(Series.AmountOfElements)}";

            //tbNotLinearTrendF.Text =
            //    $"{QualityIndicatorsNotLinearTrend.FTest}, {QualityIndicatorsNotLinearTrend.IsAdequate(Series.AmountOfElements)}";
            //tbNotLinearTrendR2.Text =
            //    $"{QualityIndicatorsNotLinearTrend.R2}, {QualityIndicatorsNotLinearTrend.IsSignificant(Series.AmountOfElements)}";

            FillCorrelogramaChart(rbWithSmoothing.Checked);
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
            //Series.AmountOfElements
            for (int i = 0; i < 10; i++)
            {
                double y = NotLinearRegression.Gamma * Math.Pow(NotLinearRegression.A0, Math.Pow(NotLinearRegression.A1, i + 1));
                chNotLinear.Series[1].Points.AddXY(Series.Index[i], y);
            }
        }
        #endregion

        #region Quality
        private void CountQuality(bool withSmoothing)
        {
            if (withSmoothing)
            {
                QualityIndicatorsLinearTrend =
                    new SeriesQuality(SeriesAfterSmoothing.Value, LinearRegression.A0, LinearRegression.A1, true, 0);
                //QualityIndicatorsNotLinearTrend = new SeriesQuality(SeriesAfterSmoothing.Value, NotLinearRegression.A0,
                //    NotLinearRegression.A1, false, NotLinearRegression.Gamma);
            }
            else
            {
                QualityIndicatorsLinearTrend =
                    new SeriesQuality(Series.Value, LinearRegression.A0, LinearRegression.A1, true, 0);
                /*QualityIndicatorsNotLinearTrend = new SeriesQuality(Series.Value, NotLinearRegression.A0,
                    NotLinearRegression.A1, false, NotLinearRegression.Gamma);*/
            }
        }
        #endregion

        #region WithoutTrend
        private void FillCorrelogramaChart(bool withSmoothing)
        {
            chFourier.Series[0].Points.Clear();
            var series = withSmoothing ? SeriesAfterSmoothing.Value : Series.Value;
            var correlogramData = new AnalyzerForSeriesWithoutTrend(series);
            if(correlogramData.WithoutTrend)
                for (int i = 0; i < correlogramData.Correlation.Count; i++)
                    chFourier.Series[0].Points.AddXY(i + 1, correlogramData.Correlation[i]);
        }
        #endregion

        #region Fourier
        private void FillFourierChart(int period)
        {
            chFourier.Series[0].Points.Clear();
            Fourier = new Fourier(SeriesAfterSmoothing, period);
            for (int i = 0; i < Series.AmountOfElements; i++)
            {
                chFourier.Series[0].Points.AddXY(SeriesAfterSmoothing.Index[i], Fourier.Y[i]);
            }
        }
        #endregion

        #region Prediction
        private void rbLinearPrediction_Click(object sender, EventArgs e)
        {
            rbLinearPrediction.Checked = true;
            rbNotLinearPrediction.Checked = false;
        }

        private void rbNotLinearPrediction_Click(object sender, EventArgs e)
        {
            rbLinearPrediction.Checked = false;
            rbNotLinearPrediction.Checked = true;
        }

        private void btnPrediction_Click(object sender, EventArgs e)
        {
            chPrediction.Series[0].Points.Clear();
            chPrediction.Series[1].Points.Clear();

            for (int i = 0; i < SeriesAfterSmoothing.AmountOfElements; i++)
            {
                chPrediction.Series[0].Points.AddXY(i + 1, SeriesAfterSmoothing.Value[i]);
                //chPrediction.Series[1].Points.AddXY(i + 1, SeriesAfterSmoothing.Value[i]);
            }

            var prediction = rbLinearPrediction.Checked
                ? new Prediction(LinearRegression.A0, LinearRegression.A1, SeriesAfterSmoothing.Value, true, Fourier)
                : new Prediction(NotLinearRegression.A0, NotLinearRegression.A1, NotLinearRegression.Gamma,
                    SeriesAfterSmoothing.Value, false, Fourier);
            for (int i=0;i<Convert.ToInt32(tbAmountOfSteps.Text);i++)
                chPrediction.Series[1].Points.AddXY(SeriesAfterSmoothing.AmountOfElements + i, prediction.PredictValue(SeriesAfterSmoothing.AmountOfElements + i + 1));
        }
        #endregion
    }
}
