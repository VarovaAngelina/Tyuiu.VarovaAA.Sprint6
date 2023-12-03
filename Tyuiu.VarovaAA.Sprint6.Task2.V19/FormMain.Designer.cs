
namespace Tyuiu.VarovaAA.Sprint6.Task2.V19
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_VAA = new System.Windows.Forms.GroupBox();
            this.groupBoxInput_VAA = new System.Windows.Forms.GroupBox();
            this.groupBoxOutput_VAA = new System.Windows.Forms.GroupBox();
            this.buttonSpravka_VAA = new System.Windows.Forms.Button();
            this.buttonDone_VAA = new System.Windows.Forms.Button();
            this.textBoxVarStart_VAA = new System.Windows.Forms.TextBox();
            this.textBoxVarStop_VAA = new System.Windows.Forms.TextBox();
            this.labelRes_VAA = new System.Windows.Forms.Label();
            this.labelTask_VAA = new System.Windows.Forms.Label();
            this.labelVarStart_VAA = new System.Windows.Forms.Label();
            this.labelVarStop_VAA = new System.Windows.Forms.Label();
            this.dataGridViewFunction_VAA = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunction_VAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_VAA.SuspendLayout();
            this.groupBoxInput_VAA.SuspendLayout();
            this.groupBoxOutput_VAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_VAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_VAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_VAA
            // 
            this.groupBoxTask_VAA.Controls.Add(this.labelTask_VAA);
            this.groupBoxTask_VAA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_VAA.Name = "groupBoxTask_VAA";
            this.groupBoxTask_VAA.Size = new System.Drawing.Size(547, 246);
            this.groupBoxTask_VAA.TabIndex = 0;
            this.groupBoxTask_VAA.TabStop = false;
            this.groupBoxTask_VAA.Text = "Условие";
            // 
            // groupBoxInput_VAA
            // 
            this.groupBoxInput_VAA.Controls.Add(this.labelVarStop_VAA);
            this.groupBoxInput_VAA.Controls.Add(this.labelVarStart_VAA);
            this.groupBoxInput_VAA.Controls.Add(this.textBoxVarStop_VAA);
            this.groupBoxInput_VAA.Controls.Add(this.textBoxVarStart_VAA);
            this.groupBoxInput_VAA.Location = new System.Drawing.Point(13, 266);
            this.groupBoxInput_VAA.Name = "groupBoxInput_VAA";
            this.groupBoxInput_VAA.Size = new System.Drawing.Size(316, 74);
            this.groupBoxInput_VAA.TabIndex = 1;
            this.groupBoxInput_VAA.TabStop = false;
            this.groupBoxInput_VAA.Text = "Ввод данных";
            // 
            // groupBoxOutput_VAA
            // 
            this.groupBoxOutput_VAA.Controls.Add(this.chartFunction_VAA);
            this.groupBoxOutput_VAA.Controls.Add(this.dataGridViewFunction_VAA);
            this.groupBoxOutput_VAA.Controls.Add(this.labelRes_VAA);
            this.groupBoxOutput_VAA.Location = new System.Drawing.Point(567, 13);
            this.groupBoxOutput_VAA.Name = "groupBoxOutput_VAA";
            this.groupBoxOutput_VAA.Size = new System.Drawing.Size(634, 327);
            this.groupBoxOutput_VAA.TabIndex = 2;
            this.groupBoxOutput_VAA.TabStop = false;
            this.groupBoxOutput_VAA.Text = "Вывод данных";
            // 
            // buttonSpravka_VAA
            // 
            this.buttonSpravka_VAA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSpravka_VAA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSpravka_VAA.Location = new System.Drawing.Point(335, 266);
            this.buttonSpravka_VAA.Name = "buttonSpravka_VAA";
            this.buttonSpravka_VAA.Size = new System.Drawing.Size(79, 74);
            this.buttonSpravka_VAA.TabIndex = 3;
            this.buttonSpravka_VAA.Text = "Справка";
            this.buttonSpravka_VAA.UseVisualStyleBackColor = false;
            this.buttonSpravka_VAA.Click += new System.EventHandler(this.buttonSpravka_VAA_Click);
            // 
            // buttonDone_VAA
            // 
            this.buttonDone_VAA.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonDone_VAA.Location = new System.Drawing.Point(420, 266);
            this.buttonDone_VAA.Name = "buttonDone_VAA";
            this.buttonDone_VAA.Size = new System.Drawing.Size(140, 74);
            this.buttonDone_VAA.TabIndex = 4;
            this.buttonDone_VAA.Text = "Выполнить";
            this.buttonDone_VAA.UseVisualStyleBackColor = false;
            this.buttonDone_VAA.Click += new System.EventHandler(this.buttonDone_VAA_Click);
            this.buttonDone_VAA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_VAA_MouseDown);
            this.buttonDone_VAA.MouseEnter += new System.EventHandler(this.buttonDone_VAA_MouseEnter);
            this.buttonDone_VAA.MouseLeave += new System.EventHandler(this.buttonDone_VAA_MouseLeave);
            // 
            // textBoxVarStart_VAA
            // 
            this.textBoxVarStart_VAA.Location = new System.Drawing.Point(7, 45);
            this.textBoxVarStart_VAA.Name = "textBoxVarStart_VAA";
            this.textBoxVarStart_VAA.Size = new System.Drawing.Size(147, 22);
            this.textBoxVarStart_VAA.TabIndex = 0;
            // 
            // textBoxVarStop_VAA
            // 
            this.textBoxVarStop_VAA.Location = new System.Drawing.Point(163, 45);
            this.textBoxVarStop_VAA.Name = "textBoxVarStop_VAA";
            this.textBoxVarStop_VAA.Size = new System.Drawing.Size(147, 22);
            this.textBoxVarStop_VAA.TabIndex = 1;
            // 
            // labelRes_VAA
            // 
            this.labelRes_VAA.AutoSize = true;
            this.labelRes_VAA.Location = new System.Drawing.Point(7, 22);
            this.labelRes_VAA.Name = "labelRes_VAA";
            this.labelRes_VAA.Size = new System.Drawing.Size(80, 17);
            this.labelRes_VAA.TabIndex = 1;
            this.labelRes_VAA.Text = "Результат:";
            // 
            // labelTask_VAA
            // 
            this.labelTask_VAA.AutoSize = true;
            this.labelTask_VAA.Location = new System.Drawing.Point(7, 22);
            this.labelTask_VAA.Name = "labelTask_VAA";
            this.labelTask_VAA.Size = new System.Drawing.Size(514, 34);
            this.labelTask_VAA.TabIndex = 0;
            this.labelTask_VAA.Text = "Протаулировать функцию (Sin(x))/(x + 1,7) - Cos(x) * 4x - 6 на заданном\r\nдиапазон" +
    "е. Результат вывести в DataGridView и построить график функции.\r\n";
            // 
            // labelVarStart_VAA
            // 
            this.labelVarStart_VAA.AutoSize = true;
            this.labelVarStart_VAA.Location = new System.Drawing.Point(7, 22);
            this.labelVarStart_VAA.Name = "labelVarStart_VAA";
            this.labelVarStart_VAA.Size = new System.Drawing.Size(87, 17);
            this.labelVarStart_VAA.TabIndex = 2;
            this.labelVarStart_VAA.Text = "Старт шага:";
            // 
            // labelVarStop_VAA
            // 
            this.labelVarStop_VAA.AutoSize = true;
            this.labelVarStop_VAA.Location = new System.Drawing.Point(163, 21);
            this.labelVarStop_VAA.Name = "labelVarStop_VAA";
            this.labelVarStop_VAA.Size = new System.Drawing.Size(89, 17);
            this.labelVarStop_VAA.TabIndex = 3;
            this.labelVarStop_VAA.Text = "Конец шага:";
            // 
            // dataGridViewFunction_VAA
            // 
            this.dataGridViewFunction_VAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_VAA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewFunction_VAA.Location = new System.Drawing.Point(7, 43);
            this.dataGridViewFunction_VAA.Name = "dataGridViewFunction_VAA";
            this.dataGridViewFunction_VAA.RowHeadersVisible = false;
            this.dataGridViewFunction_VAA.RowHeadersWidth = 51;
            this.dataGridViewFunction_VAA.RowTemplate.Height = 24;
            this.dataGridViewFunction_VAA.Size = new System.Drawing.Size(175, 278);
            this.dataGridViewFunction_VAA.TabIndex = 2;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.Width = 75;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(x)";
            this.Y.MinimumWidth = 6;
            this.Y.Name = "Y";
            this.Y.Width = 75;
            // 
            // chartFunction_VAA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_VAA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_VAA.Legends.Add(legend1);
            this.chartFunction_VAA.Location = new System.Drawing.Point(188, 43);
            this.chartFunction_VAA.Name = "chartFunction_VAA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_VAA.Series.Add(series1);
            this.chartFunction_VAA.Size = new System.Drawing.Size(437, 277);
            this.chartFunction_VAA.TabIndex = 3;
            this.chartFunction_VAA.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 352);
            this.Controls.Add(this.buttonDone_VAA);
            this.Controls.Add(this.buttonSpravka_VAA);
            this.Controls.Add(this.groupBoxOutput_VAA);
            this.Controls.Add(this.groupBoxInput_VAA);
            this.Controls.Add(this.groupBoxTask_VAA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 2 | Вариант 19 |  Варова А. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_VAA.ResumeLayout(false);
            this.groupBoxTask_VAA.PerformLayout();
            this.groupBoxInput_VAA.ResumeLayout(false);
            this.groupBoxInput_VAA.PerformLayout();
            this.groupBoxOutput_VAA.ResumeLayout(false);
            this.groupBoxOutput_VAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_VAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_VAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_VAA;
        private System.Windows.Forms.GroupBox groupBoxInput_VAA;
        private System.Windows.Forms.GroupBox groupBoxOutput_VAA;
        private System.Windows.Forms.Button buttonSpravka_VAA;
        private System.Windows.Forms.Button buttonDone_VAA;
        private System.Windows.Forms.Label labelTask_VAA;
        private System.Windows.Forms.Label labelVarStop_VAA;
        private System.Windows.Forms.Label labelVarStart_VAA;
        private System.Windows.Forms.TextBox textBoxVarStop_VAA;
        private System.Windows.Forms.TextBox textBoxVarStart_VAA;
        private System.Windows.Forms.Label labelRes_VAA;
        private System.Windows.Forms.DataGridView dataGridViewFunction_VAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_VAA;
    }
}

