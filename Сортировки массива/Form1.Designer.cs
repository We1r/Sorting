namespace Сортировки_массива
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSorting = new System.Windows.Forms.Button();
            this.textBoxBubble = new System.Windows.Forms.TextBox();
            this.checkBoxBubble = new System.Windows.Forms.CheckBox();
            this.checkBoxInsert = new System.Windows.Forms.CheckBox();
            this.textBoxInsert = new System.Windows.Forms.TextBox();
            this.checkBoxCocktail = new System.Windows.Forms.CheckBox();
            this.textBoxCocktail = new System.Windows.Forms.TextBox();
            this.checkBoxQuick = new System.Windows.Forms.CheckBox();
            this.textBoxQuick = new System.Windows.Forms.TextBox();
            this.checkBoxBOGO = new System.Windows.Forms.CheckBox();
            this.textBoxBOGO = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRandom
            // 
            this.buttonRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRandom.Location = new System.Drawing.Point(33, 108);
            this.buttonRandom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(134, 45);
            this.buttonRandom.TabIndex = 0;
            this.buttonRandom.Text = "Перемешать массив";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(238, 121);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 20);
            this.textBox1.TabIndex = 1;
            // 
            // buttonSorting
            // 
            this.buttonSorting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSorting.Location = new System.Drawing.Point(293, 40);
            this.buttonSorting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSorting.Name = "buttonSorting";
            this.buttonSorting.Size = new System.Drawing.Size(134, 50);
            this.buttonSorting.TabIndex = 2;
            this.buttonSorting.Text = "Сортировать";
            this.buttonSorting.UseVisualStyleBackColor = true;
            this.buttonSorting.Click += new System.EventHandler(this.buttonSorting_Click);
            // 
            // textBoxBubble
            // 
            this.textBoxBubble.Location = new System.Drawing.Point(238, 177);
            this.textBoxBubble.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxBubble.Name = "textBoxBubble";
            this.textBoxBubble.Size = new System.Drawing.Size(258, 20);
            this.textBoxBubble.TabIndex = 3;
            // 
            // checkBoxBubble
            // 
            this.checkBoxBubble.AutoSize = true;
            this.checkBoxBubble.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxBubble.Location = new System.Drawing.Point(12, 177);
            this.checkBoxBubble.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxBubble.Name = "checkBoxBubble";
            this.checkBoxBubble.Size = new System.Drawing.Size(220, 24);
            this.checkBoxBubble.TabIndex = 4;
            this.checkBoxBubble.Text = "Пузырьковая сортировка";
            this.checkBoxBubble.UseVisualStyleBackColor = true;
            // 
            // checkBoxInsert
            // 
            this.checkBoxInsert.AutoSize = true;
            this.checkBoxInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxInsert.Location = new System.Drawing.Point(12, 222);
            this.checkBoxInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxInsert.Name = "checkBoxInsert";
            this.checkBoxInsert.Size = new System.Drawing.Size(204, 24);
            this.checkBoxInsert.TabIndex = 5;
            this.checkBoxInsert.Text = "Сортировка вставками";
            this.checkBoxInsert.UseVisualStyleBackColor = true;
            // 
            // textBoxInsert
            // 
            this.textBoxInsert.Location = new System.Drawing.Point(238, 222);
            this.textBoxInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxInsert.Name = "textBoxInsert";
            this.textBoxInsert.Size = new System.Drawing.Size(258, 20);
            this.textBoxInsert.TabIndex = 6;
            // 
            // checkBoxCocktail
            // 
            this.checkBoxCocktail.AutoSize = true;
            this.checkBoxCocktail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxCocktail.Location = new System.Drawing.Point(12, 267);
            this.checkBoxCocktail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxCocktail.Name = "checkBoxCocktail";
            this.checkBoxCocktail.Size = new System.Drawing.Size(204, 24);
            this.checkBoxCocktail.TabIndex = 7;
            this.checkBoxCocktail.Text = "Шейкерная сортировка";
            this.checkBoxCocktail.UseVisualStyleBackColor = true;
            // 
            // textBoxCocktail
            // 
            this.textBoxCocktail.Location = new System.Drawing.Point(238, 267);
            this.textBoxCocktail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCocktail.Name = "textBoxCocktail";
            this.textBoxCocktail.Size = new System.Drawing.Size(258, 20);
            this.textBoxCocktail.TabIndex = 8;
            // 
            // checkBoxQuick
            // 
            this.checkBoxQuick.AutoSize = true;
            this.checkBoxQuick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxQuick.Location = new System.Drawing.Point(12, 308);
            this.checkBoxQuick.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxQuick.Name = "checkBoxQuick";
            this.checkBoxQuick.Size = new System.Drawing.Size(186, 24);
            this.checkBoxQuick.TabIndex = 9;
            this.checkBoxQuick.Text = "Быстрая сортировка";
            this.checkBoxQuick.UseVisualStyleBackColor = true;
            // 
            // textBoxQuick
            // 
            this.textBoxQuick.Location = new System.Drawing.Point(238, 308);
            this.textBoxQuick.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxQuick.Name = "textBoxQuick";
            this.textBoxQuick.Size = new System.Drawing.Size(258, 20);
            this.textBoxQuick.TabIndex = 10;
            // 
            // checkBoxBOGO
            // 
            this.checkBoxBOGO.AutoSize = true;
            this.checkBoxBOGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxBOGO.Location = new System.Drawing.Point(12, 345);
            this.checkBoxBOGO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxBOGO.Name = "checkBoxBOGO";
            this.checkBoxBOGO.Size = new System.Drawing.Size(76, 24);
            this.checkBoxBOGO.TabIndex = 11;
            this.checkBoxBOGO.Text = "BOGO";
            this.checkBoxBOGO.UseVisualStyleBackColor = true;
            // 
            // textBoxBOGO
            // 
            this.textBoxBOGO.Location = new System.Drawing.Point(238, 345);
            this.textBoxBOGO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxBOGO.Name = "textBoxBOGO";
            this.textBoxBOGO.Size = new System.Drawing.Size(258, 20);
            this.textBoxBOGO.TabIndex = 12;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(256, 393);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(212, 28);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "В порядке убывания";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.Maximum = 20D;
            chartArea2.AxisX.Minimum = 1D;
            chartArea2.AxisY.Interval = 1D;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.Maximum = 20D;
            chartArea2.AxisY.Minimum = 1D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(528, 30);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart1.Name = "chart1";
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.IsXValueIndexed = true;
            series8.LabelBorderWidth = 2;
            series8.Legend = "Legend1";
            series8.MarkerColor = System.Drawing.Color.Red;
            series8.Name = "Series2";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.LabelBorderWidth = 2;
            series9.Legend = "Legend1";
            series9.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series9.Name = "Series3";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.LabelBorderWidth = 2;
            series10.Legend = "Legend1";
            series10.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series10.Name = "Series4";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.LabelBorderWidth = 2;
            series11.Legend = "Legend1";
            series11.MarkerColor = System.Drawing.Color.Cyan;
            series11.Name = "Series5";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.LabelBorderWidth = 2;
            series12.Legend = "Legend1";
            series12.MarkerColor = System.Drawing.Color.Yellow;
            series12.Name = "Series6";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Size = new System.Drawing.Size(543, 340);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(528, 384);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(542, 54);
            this.button1.TabIndex = 15;
            this.button1.Text = "Очистить график";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 446);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBoxBOGO);
            this.Controls.Add(this.checkBoxBOGO);
            this.Controls.Add(this.textBoxQuick);
            this.Controls.Add(this.checkBoxQuick);
            this.Controls.Add(this.textBoxCocktail);
            this.Controls.Add(this.checkBoxCocktail);
            this.Controls.Add(this.textBoxInsert);
            this.Controls.Add(this.checkBoxInsert);
            this.Controls.Add(this.checkBoxBubble);
            this.Controls.Add(this.textBoxBubble);
            this.Controls.Add(this.buttonSorting);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonRandom);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSorting;
        private System.Windows.Forms.TextBox textBoxBubble;
        private System.Windows.Forms.CheckBox checkBoxBubble;
        private System.Windows.Forms.CheckBox checkBoxInsert;
        private System.Windows.Forms.TextBox textBoxInsert;
        private System.Windows.Forms.CheckBox checkBoxCocktail;
        private System.Windows.Forms.TextBox textBoxCocktail;
        private System.Windows.Forms.CheckBox checkBoxQuick;
        private System.Windows.Forms.TextBox textBoxQuick;
        private System.Windows.Forms.CheckBox checkBoxBOGO;
        private System.Windows.Forms.TextBox textBoxBOGO;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
    }
}

