namespace Currency
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tRate = new System.Windows.Forms.Label();
            this.tDays = new System.Windows.Forms.Label();
            this.UDDays = new System.Windows.Forms.NumericUpDown();
            this.bStart = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bBuy = new System.Windows.Forms.Button();
            this.UDBuy = new System.Windows.Forms.NumericUpDown();
            this.bSell = new System.Windows.Forms.Button();
            this.UDSell = new System.Windows.Forms.NumericUpDown();
            this.UDRate = new System.Windows.Forms.NumericUpDown();
            this.tRUB = new System.Windows.Forms.Label();
            this.tUSD = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDRate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tUSD);
            this.panel1.Controls.Add(this.tRUB);
            this.panel1.Controls.Add(this.UDRate);
            this.panel1.Controls.Add(this.UDSell);
            this.panel1.Controls.Add(this.bSell);
            this.panel1.Controls.Add(this.UDBuy);
            this.panel1.Controls.Add(this.bBuy);
            this.panel1.Controls.Add(this.bStart);
            this.panel1.Controls.Add(this.UDDays);
            this.panel1.Controls.Add(this.tDays);
            this.panel1.Controls.Add(this.tRate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 200);
            this.panel1.TabIndex = 0;
            // 
            // tRate
            // 
            this.tRate.AutoSize = true;
            this.tRate.Location = new System.Drawing.Point(4, 4);
            this.tRate.Name = "tRate";
            this.tRate.Size = new System.Drawing.Size(103, 17);
            this.tRate.TabIndex = 0;
            this.tRate.Text = "Текущий курс:";
            // 
            // tDays
            // 
            this.tDays.AutoSize = true;
            this.tDays.Location = new System.Drawing.Point(4, 46);
            this.tDays.Name = "tDays";
            this.tDays.Size = new System.Drawing.Size(47, 17);
            this.tDays.TabIndex = 2;
            this.tDays.Text = "Дней:";
            // 
            // UDDays
            // 
            this.UDDays.Location = new System.Drawing.Point(114, 46);
            this.UDDays.Name = "UDDays";
            this.UDDays.Size = new System.Drawing.Size(120, 22);
            this.UDDays.TabIndex = 3;
            this.UDDays.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(296, 13);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(103, 50);
            this.bStart.TabIndex = 4;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(0, 200);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.IsValueShownAsLabel = true;
            series4.LabelFormat = "f2";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(800, 415);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // bBuy
            // 
            this.bBuy.Location = new System.Drawing.Point(4, 117);
            this.bBuy.Name = "bBuy";
            this.bBuy.Size = new System.Drawing.Size(85, 34);
            this.bBuy.TabIndex = 5;
            this.bBuy.Text = "Купить";
            this.bBuy.UseVisualStyleBackColor = true;
            this.bBuy.Click += new System.EventHandler(this.bBuy_Click);
            // 
            // UDBuy
            // 
            this.UDBuy.Location = new System.Drawing.Point(114, 124);
            this.UDBuy.Name = "UDBuy";
            this.UDBuy.Size = new System.Drawing.Size(60, 22);
            this.UDBuy.TabIndex = 6;
            // 
            // bSell
            // 
            this.bSell.Location = new System.Drawing.Point(4, 160);
            this.bSell.Name = "bSell";
            this.bSell.Size = new System.Drawing.Size(85, 34);
            this.bSell.TabIndex = 7;
            this.bSell.Text = "Продать";
            this.bSell.UseVisualStyleBackColor = true;
            this.bSell.Click += new System.EventHandler(this.bSell_Click);
            // 
            // UDSell
            // 
            this.UDSell.Location = new System.Drawing.Point(114, 167);
            this.UDSell.Name = "UDSell";
            this.UDSell.Size = new System.Drawing.Size(60, 22);
            this.UDSell.TabIndex = 8;
            // 
            // UDRate
            // 
            this.UDRate.DecimalPlaces = 2;
            this.UDRate.Location = new System.Drawing.Point(114, 4);
            this.UDRate.Name = "UDRate";
            this.UDRate.Size = new System.Drawing.Size(120, 22);
            this.UDRate.TabIndex = 9;
            this.UDRate.Value = new decimal(new int[] {
            7632,
            0,
            0,
            131072});
            // 
            // tRUB
            // 
            this.tRUB.AutoSize = true;
            this.tRUB.Location = new System.Drawing.Point(514, 13);
            this.tRUB.Name = "tRUB";
            this.tRUB.Size = new System.Drawing.Size(37, 17);
            this.tRUB.TabIndex = 10;
            this.tRUB.Text = "RUB";
            // 
            // tUSD
            // 
            this.tUSD.AutoSize = true;
            this.tUSD.Location = new System.Drawing.Point(514, 69);
            this.tUSD.Name = "tUSD";
            this.tUSD.Size = new System.Drawing.Size(37, 17);
            this.tUSD.TabIndex = 11;
            this.tUSD.Text = "USD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 615);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.NumericUpDown UDDays;
        private System.Windows.Forms.Label tDays;
        private System.Windows.Forms.Label tRate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown UDSell;
        private System.Windows.Forms.Button bSell;
        private System.Windows.Forms.NumericUpDown UDBuy;
        private System.Windows.Forms.Button bBuy;
        private System.Windows.Forms.NumericUpDown UDRate;
        private System.Windows.Forms.Label tUSD;
        private System.Windows.Forms.Label tRUB;
    }
}

