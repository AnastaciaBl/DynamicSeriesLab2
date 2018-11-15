namespace DynamicSeries_lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.tbWindow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chSmoothing = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chNormal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbA1 = new System.Windows.Forms.TextBox();
            this.tbA0 = new System.Windows.Forms.TextBox();
            this.chLinearTrend = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbWithoutSmoothing = new System.Windows.Forms.RadioButton();
            this.btnCount = new System.Windows.Forms.Button();
            this.rbWithSmoothing = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chNotLinear = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNotLinearA1 = new System.Windows.Forms.TextBox();
            this.tbNotLinearA0 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chSmoothing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chNormal)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chLinearTrend)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chNotLinear)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(105, 8);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(135, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open file...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // tbWindow
            // 
            this.tbWindow.Location = new System.Drawing.Point(528, 10);
            this.tbWindow.Name = "tbWindow";
            this.tbWindow.Size = new System.Drawing.Size(100, 20);
            this.tbWindow.TabIndex = 1;
            this.tbWindow.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Window:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(699, 380);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chSmoothing);
            this.tabPage1.Controls.Add(this.chNormal);
            this.tabPage1.Controls.Add(this.btnOpenFile);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbWindow);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(691, 354);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Smoothing";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chSmoothing
            // 
            chartArea1.Name = "ChartArea1";
            this.chSmoothing.ChartAreas.Add(chartArea1);
            this.chSmoothing.Location = new System.Drawing.Point(355, 36);
            this.chSmoothing.Name = "chSmoothing";
            series1.ChartArea = "ChartArea1";
            series1.CustomProperties = "PointWidth=1";
            series1.Name = "Series1";
            this.chSmoothing.Series.Add(series1);
            this.chSmoothing.Size = new System.Drawing.Size(333, 311);
            this.chSmoothing.TabIndex = 4;
            this.chSmoothing.Text = "chart2";
            // 
            // chNormal
            // 
            chartArea2.Name = "ChartArea1";
            this.chNormal.ChartAreas.Add(chartArea2);
            this.chNormal.Location = new System.Drawing.Point(6, 37);
            this.chNormal.Name = "chNormal";
            series2.ChartArea = "ChartArea1";
            series2.CustomProperties = "PointWidth=1";
            series2.Name = "Series1";
            this.chNormal.Series.Add(series2);
            this.chNormal.Size = new System.Drawing.Size(343, 311);
            this.chNormal.TabIndex = 3;
            this.chNormal.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.chLinearTrend);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(691, 354);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Find linear trend";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbA1);
            this.groupBox2.Controls.Add(this.tbA0);
            this.groupBox2.Location = new System.Drawing.Point(433, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 104);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Linear coefficients";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "A1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "A0:";
            // 
            // tbA1
            // 
            this.tbA1.Location = new System.Drawing.Point(53, 60);
            this.tbA1.Name = "tbA1";
            this.tbA1.Size = new System.Drawing.Size(182, 20);
            this.tbA1.TabIndex = 1;
            // 
            // tbA0
            // 
            this.tbA0.Location = new System.Drawing.Point(53, 34);
            this.tbA0.Name = "tbA0";
            this.tbA0.Size = new System.Drawing.Size(182, 20);
            this.tbA0.TabIndex = 0;
            // 
            // chLinearTrend
            // 
            chartArea3.Name = "ChartArea1";
            this.chLinearTrend.ChartAreas.Add(chartArea3);
            this.chLinearTrend.Location = new System.Drawing.Point(6, 6);
            this.chLinearTrend.Name = "chLinearTrend";
            series3.ChartArea = "ChartArea1";
            series3.CustomProperties = "PointWidth=1";
            series3.Name = "Series1";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.CustomProperties = "LineTension=1";
            series4.Name = "Series2";
            this.chLinearTrend.Series.Add(series3);
            this.chLinearTrend.Series.Add(series4);
            this.chLinearTrend.Size = new System.Drawing.Size(422, 342);
            this.chLinearTrend.TabIndex = 4;
            this.chLinearTrend.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbWithoutSmoothing);
            this.groupBox1.Controls.Add(this.btnCount);
            this.groupBox1.Controls.Add(this.rbWithSmoothing);
            this.groupBox1.Location = new System.Drawing.Point(433, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 136);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose series";
            // 
            // rbWithoutSmoothing
            // 
            this.rbWithoutSmoothing.AutoSize = true;
            this.rbWithoutSmoothing.Checked = true;
            this.rbWithoutSmoothing.Location = new System.Drawing.Point(17, 51);
            this.rbWithoutSmoothing.Name = "rbWithoutSmoothing";
            this.rbWithoutSmoothing.Size = new System.Drawing.Size(110, 17);
            this.rbWithoutSmoothing.TabIndex = 1;
            this.rbWithoutSmoothing.TabStop = true;
            this.rbWithoutSmoothing.Text = "without smoothing";
            this.rbWithoutSmoothing.UseVisualStyleBackColor = true;
            this.rbWithoutSmoothing.Click += new System.EventHandler(this.rbWithoutSmoothing_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(17, 82);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(218, 38);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // rbWithSmoothing
            // 
            this.rbWithSmoothing.AutoSize = true;
            this.rbWithSmoothing.Location = new System.Drawing.Point(17, 28);
            this.rbWithSmoothing.Name = "rbWithSmoothing";
            this.rbWithSmoothing.Size = new System.Drawing.Size(95, 17);
            this.rbWithSmoothing.TabIndex = 0;
            this.rbWithSmoothing.Text = "with smoothing";
            this.rbWithSmoothing.UseVisualStyleBackColor = true;
            this.rbWithSmoothing.Click += new System.EventHandler(this.rbWithSmoothing_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.chNotLinear);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(691, 354);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Find no linear trend";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chNotLinear
            // 
            chartArea4.Name = "ChartArea1";
            this.chNotLinear.ChartAreas.Add(chartArea4);
            this.chNotLinear.Location = new System.Drawing.Point(6, 6);
            this.chNotLinear.Name = "chNotLinear";
            series5.ChartArea = "ChartArea1";
            series5.CustomProperties = "PointWidth=1";
            series5.Name = "Series1";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.CustomProperties = "LineTension=1";
            series6.Name = "Series2";
            this.chNotLinear.Series.Add(series5);
            this.chNotLinear.Series.Add(series6);
            this.chNotLinear.Size = new System.Drawing.Size(422, 342);
            this.chNotLinear.TabIndex = 5;
            this.chNotLinear.Text = "chart1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbNotLinearA1);
            this.groupBox3.Controls.Add(this.tbNotLinearA0);
            this.groupBox3.Location = new System.Drawing.Point(434, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 104);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Coefficients";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "A1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "A0:";
            // 
            // tbNotLinearA1
            // 
            this.tbNotLinearA1.Location = new System.Drawing.Point(53, 60);
            this.tbNotLinearA1.Name = "tbNotLinearA1";
            this.tbNotLinearA1.Size = new System.Drawing.Size(182, 20);
            this.tbNotLinearA1.TabIndex = 1;
            // 
            // tbNotLinearA0
            // 
            this.tbNotLinearA0.Location = new System.Drawing.Point(53, 34);
            this.tbNotLinearA0.Name = "tbNotLinearA0";
            this.tbNotLinearA0.Size = new System.Drawing.Size(182, 20);
            this.tbNotLinearA0.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 383);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chSmoothing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chNormal)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chLinearTrend)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chNotLinear)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox tbWindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chSmoothing;
        private System.Windows.Forms.DataVisualization.Charting.Chart chNormal;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbWithoutSmoothing;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.RadioButton rbWithSmoothing;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbA1;
        private System.Windows.Forms.TextBox tbA0;
        private System.Windows.Forms.DataVisualization.Charting.Chart chLinearTrend;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNotLinearA1;
        private System.Windows.Forms.TextBox tbNotLinearA0;
        private System.Windows.Forms.DataVisualization.Charting.Chart chNotLinear;
    }
}

