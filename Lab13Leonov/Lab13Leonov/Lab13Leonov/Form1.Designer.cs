namespace Lab13Leonov
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn = new System.Windows.Forms.Button();
            this.dollarEdit = new System.Windows.Forms.NumericUpDown();
            this.euroEdit = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dollarEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.euroEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(238, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart1.Name = "chart1";
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.IsValueShownAsLabel = true;
            series7.LabelFormat = "C";
            series7.Legend = "Legend1";
            series7.Name = "Dollar";
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.IsValueShownAsLabel = true;
            series8.LabelFormat = "C";
            series8.Legend = "Legend1";
            series8.Name = "Euro";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(726, 608);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn);
            this.panel1.Controls.Add(this.dollarEdit);
            this.panel1.Controls.Add(this.euroEdit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 612);
            this.panel1.TabIndex = 2;
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn.Location = new System.Drawing.Point(18, 174);
            this.btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(194, 46);
            this.btn.TabIndex = 4;
            this.btn.Text = "Start";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // dollarEdit
            // 
            this.dollarEdit.DecimalPlaces = 2;
            this.dollarEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dollarEdit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.dollarEdit.Location = new System.Drawing.Point(102, 88);
            this.dollarEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dollarEdit.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.dollarEdit.Name = "dollarEdit";
            this.dollarEdit.Size = new System.Drawing.Size(110, 33);
            this.dollarEdit.TabIndex = 3;
            this.dollarEdit.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // euroEdit
            // 
            this.euroEdit.DecimalPlaces = 2;
            this.euroEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.euroEdit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.euroEdit.Location = new System.Drawing.Point(102, 32);
            this.euroEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.euroEdit.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.euroEdit.Name = "euroEdit";
            this.euroEdit.Size = new System.Drawing.Size(110, 33);
            this.euroEdit.TabIndex = 2;
            this.euroEdit.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dollar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Euro";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 613);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dollarEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.euroEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.NumericUpDown dollarEdit;
        private System.Windows.Forms.NumericUpDown euroEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

