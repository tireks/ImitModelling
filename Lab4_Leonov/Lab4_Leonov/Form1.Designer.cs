namespace Lab4_Leonov
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editDensity = new System.Windows.Forms.NumericUpDown();
            this.editResolution = new System.Windows.Forms.NumericUpDown();
            this.btnStopStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editResolution)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(193, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 430);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(595, 430);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.editDensity);
            this.panel1.Controls.Add(this.editResolution);
            this.panel1.Controls.Add(this.btnStopStart);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 431);
            this.panel1.TabIndex = 2;
            // 
            // editDensity
            // 
            this.editDensity.Location = new System.Drawing.Point(98, 45);
            this.editDensity.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.editDensity.Name = "editDensity";
            this.editDensity.Size = new System.Drawing.Size(69, 20);
            this.editDensity.TabIndex = 4;
            this.editDensity.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // editResolution
            // 
            this.editResolution.Location = new System.Drawing.Point(98, 19);
            this.editResolution.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.editResolution.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.editResolution.Name = "editResolution";
            this.editResolution.Size = new System.Drawing.Size(69, 20);
            this.editResolution.TabIndex = 3;
            this.editResolution.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btnStopStart
            // 
            this.btnStopStart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStopStart.Location = new System.Drawing.Point(6, 83);
            this.btnStopStart.Name = "btnStopStart";
            this.btnStopStart.Size = new System.Drawing.Size(161, 43);
            this.btnStopStart.TabIndex = 2;
            this.btnStopStart.Text = "Старт/Стоп";
            this.btnStopStart.UseVisualStyleBackColor = false;
            this.btnStopStart.Click += new System.EventHandler(this.btnStopStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Плотность";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Разрешение";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editResolution)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown editDensity;
        private System.Windows.Forms.NumericUpDown editResolution;
        private System.Windows.Forms.Button btnStopStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;
    }
}

