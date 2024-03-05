namespace lab2_leonov
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editRateDollar = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPredict = new System.Windows.Forms.Button();
            this.editRate = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editRateDollar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.editRateDollar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnPredict);
            this.panel1.Controls.Add(this.editRate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 441);
            this.panel1.TabIndex = 1;
            // 
            // editRateDollar
            // 
            this.editRateDollar.DecimalPlaces = 2;
            this.editRateDollar.Location = new System.Drawing.Point(102, 96);
            this.editRateDollar.Name = "editRateDollar";
            this.editRateDollar.Size = new System.Drawing.Size(80, 20);
            this.editRateDollar.TabIndex = 6;
            this.editRateDollar.Value = new decimal(new int[] {
            9164,
            0,
            0,
            131072});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Текущий курс доллара: ";
            // 
            // btnPredict
            // 
            this.btnPredict.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPredict.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPredict.Location = new System.Drawing.Point(8, 133);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(174, 47);
            this.btnPredict.TabIndex = 4;
            this.btnPredict.Text = "Спрогнозировать (стоп/старт)";
            this.btnPredict.UseVisualStyleBackColor = false;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // editRate
            // 
            this.editRate.DecimalPlaces = 2;
            this.editRate.Location = new System.Drawing.Point(102, 34);
            this.editRate.Name = "editRate";
            this.editRate.Size = new System.Drawing.Size(80, 20);
            this.editRate.TabIndex = 2;
            this.editRate.Value = new decimal(new int[] {
            9883,
            0,
            0,
            131072});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текущий курс евро: ";
            // 
            // chart1
            // 
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.Minimum = 60D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(188, -3);
            this.chart1.Name = "chart1";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsValueShownAsLabel = true;
            series3.LabelBorderWidth = 6;
            series3.LabelForeColor = System.Drawing.Color.DarkCyan;
            series3.LabelFormat = "C";
            series3.Legend = "Legend1";
            series3.Name = "Euro";
            series3.YValuesPerPoint = 4;
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.IsValueShownAsLabel = true;
            series4.LabelBorderWidth = 6;
            series4.LabelForeColor = System.Drawing.Color.Purple;
            series4.LabelFormat = "C";
            series4.Legend = "Legend1";
            series4.Name = "Dollar";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(600, 440);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 442);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editRateDollar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown editRateDollar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.NumericUpDown editRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
    }
}

