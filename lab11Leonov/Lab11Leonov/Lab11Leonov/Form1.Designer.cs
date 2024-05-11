namespace Lab11Leonov
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.varianceTextBox = new System.Windows.Forms.TextBox();
            this.meanTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chiTextBox = new System.Windows.Forms.TextBox();
            this.varianceEd = new System.Windows.Forms.NumericUpDown();
            this.meanEd = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numOfTrials = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varianceEd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meanEd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfTrials)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(260, 14);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(928, 677);
            this.chart1.TabIndex = 33;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(16, 192);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 69);
            this.button1.TabIndex = 32;
            this.button1.Text = "Simulate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // varianceTextBox
            // 
            this.varianceTextBox.Location = new System.Drawing.Point(112, 441);
            this.varianceTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.varianceTextBox.Name = "varianceTextBox";
            this.varianceTextBox.ReadOnly = true;
            this.varianceTextBox.Size = new System.Drawing.Size(136, 26);
            this.varianceTextBox.TabIndex = 31;
            // 
            // meanTextBox
            // 
            this.meanTextBox.Location = new System.Drawing.Point(112, 389);
            this.meanTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.meanTextBox.Name = "meanTextBox";
            this.meanTextBox.ReadOnly = true;
            this.meanTextBox.Size = new System.Drawing.Size(136, 26);
            this.meanTextBox.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 446);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Variance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 394);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Mean";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 281);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "=========================";
            // 
            // chiTextBox
            // 
            this.chiTextBox.Location = new System.Drawing.Point(112, 335);
            this.chiTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chiTextBox.Name = "chiTextBox";
            this.chiTextBox.ReadOnly = true;
            this.chiTextBox.Size = new System.Drawing.Size(136, 26);
            this.chiTextBox.TabIndex = 26;
            // 
            // varianceEd
            // 
            this.varianceEd.Location = new System.Drawing.Point(112, 125);
            this.varianceEd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.varianceEd.Name = "varianceEd";
            this.varianceEd.Size = new System.Drawing.Size(138, 26);
            this.varianceEd.TabIndex = 25;
            // 
            // meanEd
            // 
            this.meanEd.Location = new System.Drawing.Point(112, 72);
            this.meanEd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.meanEd.Name = "meanEd";
            this.meanEd.Size = new System.Drawing.Size(138, 26);
            this.meanEd.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 340);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Chi square";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Variance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mean";
            // 
            // numOfTrials
            // 
            this.numOfTrials.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numOfTrials.Location = new System.Drawing.Point(154, 14);
            this.numOfTrials.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numOfTrials.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numOfTrials.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOfTrials.Name = "numOfTrials";
            this.numOfTrials.Size = new System.Drawing.Size(96, 26);
            this.numOfTrials.TabIndex = 20;
            this.numOfTrials.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Number of trials";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 701);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.varianceTextBox);
            this.Controls.Add(this.meanTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chiTextBox);
            this.Controls.Add(this.varianceEd);
            this.Controls.Add(this.meanEd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numOfTrials);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varianceEd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meanEd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfTrials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox varianceTextBox;
        private System.Windows.Forms.TextBox meanTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox chiTextBox;
        private System.Windows.Forms.NumericUpDown varianceEd;
        private System.Windows.Forms.NumericUpDown meanEd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numOfTrials;
        private System.Windows.Forms.Label label1;
    }
}

