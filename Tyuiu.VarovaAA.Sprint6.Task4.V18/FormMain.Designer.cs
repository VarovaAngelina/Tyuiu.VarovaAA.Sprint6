
namespace Tyuiu.VarovaAA.Sprint6.Task4.V18
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxTask_VAA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_VAA = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_VAA = new System.Windows.Forms.GroupBox();
            this.textBoxVarStart_VAA = new System.Windows.Forms.TextBox();
            this.textBoxVarStop_VAA = new System.Windows.Forms.TextBox();
            this.labelStart_VAA = new System.Windows.Forms.Label();
            this.labelStop_VAA = new System.Windows.Forms.Label();
            this.buttonDone_VAA = new System.Windows.Forms.Button();
            this.buttonSave_VAA = new System.Windows.Forms.Button();
            this.buttonHelp_VAA = new System.Windows.Forms.Button();
            this.groupBoxOutPut_VAA = new System.Windows.Forms.GroupBox();
            this.textBoxRes_VAA = new System.Windows.Forms.TextBox();
            this.chartFunction_VAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_VAA.SuspendLayout();
            this.groupBoxInPut_VAA.SuspendLayout();
            this.groupBoxOutPut_VAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_VAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_VAA
            // 
            this.groupBoxTask_VAA.Controls.Add(this.textBoxTask_VAA);
            this.groupBoxTask_VAA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_VAA.Name = "groupBoxTask_VAA";
            this.groupBoxTask_VAA.Size = new System.Drawing.Size(785, 100);
            this.groupBoxTask_VAA.TabIndex = 0;
            this.groupBoxTask_VAA.TabStop = false;
            this.groupBoxTask_VAA.Text = "Условие:";
            // 
            // textBoxTask_VAA
            // 
            this.textBoxTask_VAA.Location = new System.Drawing.Point(7, 22);
            this.textBoxTask_VAA.Multiline = true;
            this.textBoxTask_VAA.Name = "textBoxTask_VAA";
            this.textBoxTask_VAA.ReadOnly = true;
            this.textBoxTask_VAA.Size = new System.Drawing.Size(772, 72);
            this.textBoxTask_VAA.TabIndex = 0;
            this.textBoxTask_VAA.Text = resources.GetString("textBoxTask_VAA.Text");
            this.textBoxTask_VAA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBoxInPut_VAA
            // 
            this.groupBoxInPut_VAA.Controls.Add(this.labelStop_VAA);
            this.groupBoxInPut_VAA.Controls.Add(this.labelStart_VAA);
            this.groupBoxInPut_VAA.Controls.Add(this.textBoxVarStop_VAA);
            this.groupBoxInPut_VAA.Controls.Add(this.textBoxVarStart_VAA);
            this.groupBoxInPut_VAA.Location = new System.Drawing.Point(804, 13);
            this.groupBoxInPut_VAA.Name = "groupBoxInPut_VAA";
            this.groupBoxInPut_VAA.Size = new System.Drawing.Size(224, 100);
            this.groupBoxInPut_VAA.TabIndex = 1;
            this.groupBoxInPut_VAA.TabStop = false;
            this.groupBoxInPut_VAA.Text = "Ввод данных";
            // 
            // textBoxVarStart_VAA
            // 
            this.textBoxVarStart_VAA.Location = new System.Drawing.Point(7, 54);
            this.textBoxVarStart_VAA.Name = "textBoxVarStart_VAA";
            this.textBoxVarStart_VAA.Size = new System.Drawing.Size(100, 22);
            this.textBoxVarStart_VAA.TabIndex = 0;
            // 
            // textBoxVarStop_VAA
            // 
            this.textBoxVarStop_VAA.Location = new System.Drawing.Point(114, 54);
            this.textBoxVarStop_VAA.Name = "textBoxVarStop_VAA";
            this.textBoxVarStop_VAA.Size = new System.Drawing.Size(100, 22);
            this.textBoxVarStop_VAA.TabIndex = 1;
            // 
            // labelStart_VAA
            // 
            this.labelStart_VAA.AutoSize = true;
            this.labelStart_VAA.Location = new System.Drawing.Point(7, 31);
            this.labelStart_VAA.Name = "labelStart_VAA";
            this.labelStart_VAA.Size = new System.Drawing.Size(87, 17);
            this.labelStart_VAA.TabIndex = 2;
            this.labelStart_VAA.Text = "Старт шага:";
            this.labelStart_VAA.Click += new System.EventHandler(this.labelStart_VAA_Click);
            // 
            // labelStop_VAA
            // 
            this.labelStop_VAA.AutoSize = true;
            this.labelStop_VAA.Location = new System.Drawing.Point(114, 31);
            this.labelStop_VAA.Name = "labelStop_VAA";
            this.labelStop_VAA.Size = new System.Drawing.Size(89, 17);
            this.labelStop_VAA.TabIndex = 3;
            this.labelStop_VAA.Text = "Конец шага:";
            // 
            // buttonDone_VAA
            // 
            this.buttonDone_VAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDone_VAA.Location = new System.Drawing.Point(1034, 35);
            this.buttonDone_VAA.Name = "buttonDone_VAA";
            this.buttonDone_VAA.Size = new System.Drawing.Size(104, 62);
            this.buttonDone_VAA.TabIndex = 2;
            this.buttonDone_VAA.Text = "Выполнить";
            this.buttonDone_VAA.UseVisualStyleBackColor = false;
            this.buttonDone_VAA.Click += new System.EventHandler(this.buttonDone_VAA_Click);
            // 
            // buttonSave_VAA
            // 
            this.buttonSave_VAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonSave_VAA.Location = new System.Drawing.Point(1144, 35);
            this.buttonSave_VAA.Name = "buttonSave_VAA";
            this.buttonSave_VAA.Size = new System.Drawing.Size(104, 62);
            this.buttonSave_VAA.TabIndex = 3;
            this.buttonSave_VAA.Text = "Сохранить";
            this.buttonSave_VAA.UseVisualStyleBackColor = false;
            this.buttonSave_VAA.Click += new System.EventHandler(this.buttonSave_VAA_Click);
            // 
            // buttonHelp_VAA
            // 
            this.buttonHelp_VAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonHelp_VAA.Location = new System.Drawing.Point(1315, 35);
            this.buttonHelp_VAA.Name = "buttonHelp_VAA";
            this.buttonHelp_VAA.Size = new System.Drawing.Size(104, 62);
            this.buttonHelp_VAA.TabIndex = 4;
            this.buttonHelp_VAA.Text = "Справка";
            this.buttonHelp_VAA.UseVisualStyleBackColor = false;
            this.buttonHelp_VAA.Click += new System.EventHandler(this.buttonHelp_VAA_Click);
            // 
            // groupBoxOutPut_VAA
            // 
            this.groupBoxOutPut_VAA.Controls.Add(this.textBoxRes_VAA);
            this.groupBoxOutPut_VAA.Location = new System.Drawing.Point(13, 120);
            this.groupBoxOutPut_VAA.Name = "groupBoxOutPut_VAA";
            this.groupBoxOutPut_VAA.Size = new System.Drawing.Size(268, 468);
            this.groupBoxOutPut_VAA.TabIndex = 5;
            this.groupBoxOutPut_VAA.TabStop = false;
            this.groupBoxOutPut_VAA.Text = "Вывод:";
            // 
            // textBoxRes_VAA
            // 
            this.textBoxRes_VAA.Location = new System.Drawing.Point(7, 22);
            this.textBoxRes_VAA.Multiline = true;
            this.textBoxRes_VAA.Name = "textBoxRes_VAA";
            this.textBoxRes_VAA.ReadOnly = true;
            this.textBoxRes_VAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRes_VAA.Size = new System.Drawing.Size(255, 440);
            this.textBoxRes_VAA.TabIndex = 0;
            this.textBoxRes_VAA.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // chartFunction_VAA
            // 
            chartArea5.Name = "ChartArea1";
            this.chartFunction_VAA.ChartAreas.Add(chartArea5);
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            this.chartFunction_VAA.Legends.Add(legend5);
            this.chartFunction_VAA.Location = new System.Drawing.Point(288, 120);
            this.chartFunction_VAA.Name = "chartFunction_VAA";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartFunction_VAA.Series.Add(series5);
            this.chartFunction_VAA.Size = new System.Drawing.Size(1131, 468);
            this.chartFunction_VAA.TabIndex = 6;
            this.chartFunction_VAA.Text = "chart1";
            title5.BorderWidth = 2;
            title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title5.ForeColor = System.Drawing.Color.RoyalBlue;
            title5.Name = "Title1";
            title5.Text = "График функции (2x - 3)/(Cos(x) + x) + 5";
            this.chartFunction_VAA.Titles.Add(title5);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 603);
            this.Controls.Add(this.chartFunction_VAA);
            this.Controls.Add(this.groupBoxOutPut_VAA);
            this.Controls.Add(this.buttonHelp_VAA);
            this.Controls.Add(this.buttonSave_VAA);
            this.Controls.Add(this.buttonDone_VAA);
            this.Controls.Add(this.groupBoxInPut_VAA);
            this.Controls.Add(this.groupBoxTask_VAA);
            this.MinimumSize = new System.Drawing.Size(1450, 650);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 18 |  Варова А. А.";
            this.groupBoxTask_VAA.ResumeLayout(false);
            this.groupBoxTask_VAA.PerformLayout();
            this.groupBoxInPut_VAA.ResumeLayout(false);
            this.groupBoxInPut_VAA.PerformLayout();
            this.groupBoxOutPut_VAA.ResumeLayout(false);
            this.groupBoxOutPut_VAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_VAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_VAA;
        private System.Windows.Forms.TextBox textBoxTask_VAA;
        private System.Windows.Forms.GroupBox groupBoxInPut_VAA;
        private System.Windows.Forms.Label labelStop_VAA;
        private System.Windows.Forms.Label labelStart_VAA;
        private System.Windows.Forms.TextBox textBoxVarStop_VAA;
        private System.Windows.Forms.TextBox textBoxVarStart_VAA;
        private System.Windows.Forms.Button buttonDone_VAA;
        private System.Windows.Forms.Button buttonSave_VAA;
        private System.Windows.Forms.Button buttonHelp_VAA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_VAA;
        private System.Windows.Forms.TextBox textBoxRes_VAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_VAA;
    }
}

