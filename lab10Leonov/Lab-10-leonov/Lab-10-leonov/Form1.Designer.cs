namespace Lab_10_leonov
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
            this.tableProbData = new System.Windows.Forms.DataGridView();
            this.Clubs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Goals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Looses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableProbData)).BeginInit();
            this.SuspendLayout();
            // 
            // tableProbData
            // 
            this.tableProbData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableProbData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableProbData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clubs,
            this.Goals,
            this.Wins,
            this.Looses,
            this.gg,
            this.Points});
            this.tableProbData.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tableProbData.Location = new System.Drawing.Point(13, 46);
            this.tableProbData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableProbData.Name = "tableProbData";
            this.tableProbData.RowHeadersVisible = false;
            this.tableProbData.RowHeadersWidth = 40;
            this.tableProbData.Size = new System.Drawing.Size(1143, 403);
            this.tableProbData.TabIndex = 5;
            // 
            // Clubs
            // 
            this.Clubs.HeaderText = "Клубы";
            this.Clubs.MinimumWidth = 8;
            this.Clubs.Name = "Clubs";
            // 
            // Goals
            // 
            this.Goals.HeaderText = "Среднее значение забитых голов";
            this.Goals.MinimumWidth = 8;
            this.Goals.Name = "Goals";
            // 
            // Wins
            // 
            this.Wins.HeaderText = "Победы";
            this.Wins.MinimumWidth = 8;
            this.Wins.Name = "Wins";
            this.Wins.ReadOnly = true;
            // 
            // Looses
            // 
            this.Looses.HeaderText = "Проигрыши";
            this.Looses.MinimumWidth = 8;
            this.Looses.Name = "Looses";
            this.Looses.ReadOnly = true;
            // 
            // gg
            // 
            this.gg.HeaderText = "Ничьи";
            this.gg.MinimumWidth = 8;
            this.gg.Name = "gg";
            this.gg.ReadOnly = true;
            // 
            // Points
            // 
            this.Points.HeaderText = "Очки";
            this.Points.MinimumWidth = 8;
            this.Points.Name = "Points";
            this.Points.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(860, 458);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 108);
            this.button1.TabIndex = 4;
            this.button1.Text = "Спрогнозировать результаты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(445, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 56);
            this.label1.TabIndex = 3;
            this.label1.Text = "Футбольный футбол!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 571);
            this.Controls.Add(this.tableProbData);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tableProbData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableProbData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clubs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goals;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wins;
        private System.Windows.Forms.DataGridViewTextBoxColumn Looses;
        private System.Windows.Forms.DataGridViewTextBoxColumn gg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

