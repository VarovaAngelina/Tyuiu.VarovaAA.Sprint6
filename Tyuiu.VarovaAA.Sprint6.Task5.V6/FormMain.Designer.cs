
namespace Tyuiu.VarovaAA.Sprint6.Task5.V6
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
            this.panelTop_VAA = new System.Windows.Forms.Panel();
            this.panelLeft_VAA = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelFill_VAA = new System.Windows.Forms.Panel();
            this.groupBoxTask_VAA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_VAA = new System.Windows.Forms.TextBox();
            this.buttonDone_VAA = new System.Windows.Forms.Button();
            this.buttonOpenFile_VAA = new System.Windows.Forms.Button();
            this.buttonHelp_VAA = new System.Windows.Forms.Button();
            this.groupBoxOutPut_VAA = new System.Windows.Forms.GroupBox();
            this.chartFunction_VAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewNums_VAA = new System.Windows.Forms.DataGridView();
            this.panelTop_VAA.SuspendLayout();
            this.panelLeft_VAA.SuspendLayout();
            this.panelFill_VAA.SuspendLayout();
            this.groupBoxTask_VAA.SuspendLayout();
            this.groupBoxOutPut_VAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_VAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_VAA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_VAA
            // 
            this.panelTop_VAA.Controls.Add(this.buttonHelp_VAA);
            this.panelTop_VAA.Controls.Add(this.buttonOpenFile_VAA);
            this.panelTop_VAA.Controls.Add(this.buttonDone_VAA);
            this.panelTop_VAA.Controls.Add(this.groupBoxTask_VAA);
            this.panelTop_VAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_VAA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_VAA.Name = "panelTop_VAA";
            this.panelTop_VAA.Size = new System.Drawing.Size(964, 100);
            this.panelTop_VAA.TabIndex = 0;
            // 
            // panelLeft_VAA
            // 
            this.panelLeft_VAA.Controls.Add(this.groupBoxOutPut_VAA);
            this.panelLeft_VAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_VAA.Location = new System.Drawing.Point(0, 100);
            this.panelLeft_VAA.Name = "panelLeft_VAA";
            this.panelLeft_VAA.Size = new System.Drawing.Size(277, 430);
            this.panelLeft_VAA.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(277, 100);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 430);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panelFill_VAA
            // 
            this.panelFill_VAA.Controls.Add(this.chartFunction_VAA);
            this.panelFill_VAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_VAA.Location = new System.Drawing.Point(280, 100);
            this.panelFill_VAA.Name = "panelFill_VAA";
            this.panelFill_VAA.Size = new System.Drawing.Size(684, 430);
            this.panelFill_VAA.TabIndex = 3;
            // 
            // groupBoxTask_VAA
            // 
            this.groupBoxTask_VAA.Controls.Add(this.textBoxTask_VAA);
            this.groupBoxTask_VAA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_VAA.Name = "groupBoxTask_VAA";
            this.groupBoxTask_VAA.Size = new System.Drawing.Size(603, 81);
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
            this.textBoxTask_VAA.Size = new System.Drawing.Size(590, 53);
            this.textBoxTask_VAA.TabIndex = 0;
            this.textBoxTask_VAA.Text = resources.GetString("textBoxTask_VAA.Text");
            // 
            // buttonDone_VAA
            // 
            this.buttonDone_VAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDone_VAA.Location = new System.Drawing.Point(623, 35);
            this.buttonDone_VAA.Name = "buttonDone_VAA";
            this.buttonDone_VAA.Size = new System.Drawing.Size(98, 53);
            this.buttonDone_VAA.TabIndex = 1;
            this.buttonDone_VAA.Text = "Выполнить";
            this.buttonDone_VAA.UseVisualStyleBackColor = false;
            this.buttonDone_VAA.Click += new System.EventHandler(this.buttonDone_VAA_Click);
            // 
            // buttonOpenFile_VAA
            // 
            this.buttonOpenFile_VAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonOpenFile_VAA.Location = new System.Drawing.Point(728, 35);
            this.buttonOpenFile_VAA.Name = "buttonOpenFile_VAA";
            this.buttonOpenFile_VAA.Size = new System.Drawing.Size(97, 53);
            this.buttonOpenFile_VAA.TabIndex = 2;
            this.buttonOpenFile_VAA.Text = "Открыть файл";
            this.buttonOpenFile_VAA.UseVisualStyleBackColor = false;
            this.buttonOpenFile_VAA.Click += new System.EventHandler(this.buttonOpenFile_VAA_Click);
            // 
            // buttonHelp_VAA
            // 
            this.buttonHelp_VAA.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonHelp_VAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonHelp_VAA.Location = new System.Drawing.Point(854, 35);
            this.buttonHelp_VAA.Name = "buttonHelp_VAA";
            this.buttonHelp_VAA.Size = new System.Drawing.Size(98, 53);
            this.buttonHelp_VAA.TabIndex = 3;
            this.buttonHelp_VAA.Text = "Справка";
            this.buttonHelp_VAA.UseVisualStyleBackColor = false;
            this.buttonHelp_VAA.Click += new System.EventHandler(this.buttonHelp_VAA_Click);
            // 
            // groupBoxOutPut_VAA
            // 
            this.groupBoxOutPut_VAA.Controls.Add(this.dataGridViewNums_VAA);
            this.groupBoxOutPut_VAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_VAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_VAA.Name = "groupBoxOutPut_VAA";
            this.groupBoxOutPut_VAA.Size = new System.Drawing.Size(277, 430);
            this.groupBoxOutPut_VAA.TabIndex = 0;
            this.groupBoxOutPut_VAA.TabStop = false;
            this.groupBoxOutPut_VAA.Text = "Вывод данных:";
            // 
            // chartFunction_VAA
            // 
            chartArea5.Name = "ChartArea1";
            this.chartFunction_VAA.ChartAreas.Add(chartArea5);
            this.chartFunction_VAA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            this.chartFunction_VAA.Legends.Add(legend5);
            this.chartFunction_VAA.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_VAA.Name = "chartFunction_VAA";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartFunction_VAA.Series.Add(series5);
            this.chartFunction_VAA.Size = new System.Drawing.Size(684, 430);
            this.chartFunction_VAA.TabIndex = 0;
            this.chartFunction_VAA.Text = "chart1";
            // 
            // dataGridViewNums_VAA
            // 
            this.dataGridViewNums_VAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums_VAA.ColumnHeadersVisible = false;
            this.dataGridViewNums_VAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNums_VAA.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewNums_VAA.Name = "dataGridViewNums_VAA";
            this.dataGridViewNums_VAA.RowHeadersVisible = false;
            this.dataGridViewNums_VAA.RowHeadersWidth = 51;
            this.dataGridViewNums_VAA.RowTemplate.Height = 24;
            this.dataGridViewNums_VAA.Size = new System.Drawing.Size(271, 409);
            this.dataGridViewNums_VAA.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 530);
            this.Controls.Add(this.panelFill_VAA);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelLeft_VAA);
            this.Controls.Add(this.panelTop_VAA);
            this.MinimumSize = new System.Drawing.Size(982, 577);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 6 |  Варова А. А.";
            this.panelTop_VAA.ResumeLayout(false);
            this.panelLeft_VAA.ResumeLayout(false);
            this.panelFill_VAA.ResumeLayout(false);
            this.groupBoxTask_VAA.ResumeLayout(false);
            this.groupBoxTask_VAA.PerformLayout();
            this.groupBoxOutPut_VAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_VAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_VAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_VAA;
        private System.Windows.Forms.Button buttonHelp_VAA;
        private System.Windows.Forms.Button buttonOpenFile_VAA;
        private System.Windows.Forms.Button buttonDone_VAA;
        private System.Windows.Forms.GroupBox groupBoxTask_VAA;
        private System.Windows.Forms.TextBox textBoxTask_VAA;
        private System.Windows.Forms.Panel panelLeft_VAA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_VAA;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelFill_VAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_VAA;
        private System.Windows.Forms.DataGridView dataGridViewNums_VAA;
    }
}

