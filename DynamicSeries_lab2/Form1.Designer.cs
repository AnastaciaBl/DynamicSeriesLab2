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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.tbWindow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chNormal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chSmoothing = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rbWithSmoothing = new System.Windows.Forms.RadioButton();
            this.rbWithoutSmoothing = new System.Windows.Forms.RadioButton();
            this.btnCount = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chSmoothing)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(691, 354);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Find trend";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chNormal
            // 
            chartArea9.Name = "ChartArea1";
            this.chNormal.ChartAreas.Add(chartArea9);
            this.chNormal.Location = new System.Drawing.Point(6, 37);
            this.chNormal.Name = "chNormal";
            series9.ChartArea = "ChartArea1";
            series9.Name = "Series1";
            this.chNormal.Series.Add(series9);
            this.chNormal.Size = new System.Drawing.Size(343, 311);
            this.chNormal.TabIndex = 3;
            this.chNormal.Text = "chart1";
            // 
            // chSmoothing
            // 
            chartArea10.Name = "ChartArea1";
            this.chSmoothing.ChartAreas.Add(chartArea10);
            this.chSmoothing.Location = new System.Drawing.Point(355, 36);
            this.chSmoothing.Name = "chSmoothing";
            series10.ChartArea = "ChartArea1";
            series10.Name = "Series1";
            this.chSmoothing.Series.Add(series10);
            this.chSmoothing.Size = new System.Drawing.Size(333, 311);
            this.chSmoothing.TabIndex = 4;
            this.chSmoothing.Text = "chart2";
            // 
            // rbWithSmoothing
            // 
            this.rbWithSmoothing.AutoSize = true;
            this.rbWithSmoothing.Location = new System.Drawing.Point(17, 19);
            this.rbWithSmoothing.Name = "rbWithSmoothing";
            this.rbWithSmoothing.Size = new System.Drawing.Size(95, 17);
            this.rbWithSmoothing.TabIndex = 0;
            this.rbWithSmoothing.Text = "with smoothing";
            this.rbWithSmoothing.UseVisualStyleBackColor = true;
            this.rbWithSmoothing.Click += new System.EventHandler(this.rbWithSmoothing_Click);
            // 
            // rbWithoutSmoothing
            // 
            this.rbWithoutSmoothing.AutoSize = true;
            this.rbWithoutSmoothing.Checked = true;
            this.rbWithoutSmoothing.Location = new System.Drawing.Point(17, 42);
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
            this.btnCount.Location = new System.Drawing.Point(27, 65);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbWithoutSmoothing);
            this.groupBox1.Controls.Add(this.btnCount);
            this.groupBox1.Controls.Add(this.rbWithSmoothing);
            this.groupBox1.Location = new System.Drawing.Point(557, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 104);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose series";
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
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chSmoothing)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}

