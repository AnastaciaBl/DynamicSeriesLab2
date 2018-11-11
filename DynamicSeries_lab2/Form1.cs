using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DynamicSeries_lab2
{
    public partial class Form1 : Form
    {
        public DynamicSeries Series { get; set; }
        public DynamicSeries SeriesAfterSmoothing { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

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

        private void btnCount_Click(object sender, EventArgs e)
        {
            if(rbWithoutSmoothing.Checked)
            {

            }
            else
            {

            }
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
    }
}
