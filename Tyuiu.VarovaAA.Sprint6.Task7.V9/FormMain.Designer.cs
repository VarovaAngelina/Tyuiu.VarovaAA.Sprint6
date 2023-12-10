
namespace Tyuiu.VarovaAA.Sprint6.Task7.V9
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButtons_VAA = new System.Windows.Forms.Panel();
            this.panelTask_VAA = new System.Windows.Forms.Panel();
            this.panelIn_VAA = new System.Windows.Forms.Panel();
            this.panelRes_VAA = new System.Windows.Forms.Panel();
            this.buttonOpenFile_VAA = new System.Windows.Forms.Button();
            this.buttonDone_VAA = new System.Windows.Forms.Button();
            this.buttonSaveFile_VAA = new System.Windows.Forms.Button();
            this.buttonHelp_VAA = new System.Windows.Forms.Button();
            this.groupBoxTask_VAA = new System.Windows.Forms.GroupBox();
            this.groupBoxIn_VAA = new System.Windows.Forms.GroupBox();
            this.groupBoxRes_VAA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_VAA = new System.Windows.Forms.TextBox();
            this.dataGridViewIn_VAA = new System.Windows.Forms.DataGridView();
            this.dataGridViewOut_VAA = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_VAA = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton_VAA = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_VAA = new System.Windows.Forms.SaveFileDialog();
            this.panelButtons_VAA.SuspendLayout();
            this.panelTask_VAA.SuspendLayout();
            this.panelIn_VAA.SuspendLayout();
            this.panelRes_VAA.SuspendLayout();
            this.groupBoxTask_VAA.SuspendLayout();
            this.groupBoxIn_VAA.SuspendLayout();
            this.groupBoxRes_VAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_VAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_VAA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons_VAA
            // 
            this.panelButtons_VAA.Controls.Add(this.buttonHelp_VAA);
            this.panelButtons_VAA.Controls.Add(this.buttonSaveFile_VAA);
            this.panelButtons_VAA.Controls.Add(this.buttonDone_VAA);
            this.panelButtons_VAA.Controls.Add(this.buttonOpenFile_VAA);
            this.panelButtons_VAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_VAA.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_VAA.Name = "panelButtons_VAA";
            this.panelButtons_VAA.Size = new System.Drawing.Size(800, 74);
            this.panelButtons_VAA.TabIndex = 0;
            // 
            // panelTask_VAA
            // 
            this.panelTask_VAA.Controls.Add(this.groupBoxTask_VAA);
            this.panelTask_VAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_VAA.Location = new System.Drawing.Point(0, 74);
            this.panelTask_VAA.Name = "panelTask_VAA";
            this.panelTask_VAA.Size = new System.Drawing.Size(800, 75);
            this.panelTask_VAA.TabIndex = 1;
            // 
            // panelIn_VAA
            // 
            this.panelIn_VAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelIn_VAA.Controls.Add(this.groupBoxIn_VAA);
            this.panelIn_VAA.Location = new System.Drawing.Point(0, 149);
            this.panelIn_VAA.Name = "panelIn_VAA";
            this.panelIn_VAA.Size = new System.Drawing.Size(377, 301);
            this.panelIn_VAA.TabIndex = 2;
            // 
            // panelRes_VAA
            // 
            this.panelRes_VAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRes_VAA.Controls.Add(this.groupBoxRes_VAA);
            this.panelRes_VAA.Location = new System.Drawing.Point(383, 149);
            this.panelRes_VAA.Name = "panelRes_VAA";
            this.panelRes_VAA.Size = new System.Drawing.Size(417, 301);
            this.panelRes_VAA.TabIndex = 3;
            // 
            // buttonOpenFile_VAA
            // 
            this.buttonOpenFile_VAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_VAA.Image")));
            this.buttonOpenFile_VAA.Location = new System.Drawing.Point(11, 12);
            this.buttonOpenFile_VAA.Name = "buttonOpenFile_VAA";
            this.buttonOpenFile_VAA.Size = new System.Drawing.Size(102, 55);
            this.buttonOpenFile_VAA.TabIndex = 0;
            this.toolTipButton_VAA.SetToolTip(this.buttonOpenFile_VAA, "Открыть файл для обработки данных в формате CSV");
            this.buttonOpenFile_VAA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_VAA.Click += new System.EventHandler(this.buttonOpenFile_VAA_Click);
            this.buttonOpenFile_VAA.MouseEnter += new System.EventHandler(this.buttonOpenFile_VAA_MouseEnter);
            // 
            // buttonDone_VAA
            // 
            this.buttonDone_VAA.Enabled = false;
            this.buttonDone_VAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_VAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_VAA.Image")));
            this.buttonDone_VAA.Location = new System.Drawing.Point(119, 12);
            this.buttonDone_VAA.Name = "buttonDone_VAA";
            this.buttonDone_VAA.Size = new System.Drawing.Size(106, 55);
            this.buttonDone_VAA.TabIndex = 1;
            this.toolTipButton_VAA.SetToolTip(this.buttonDone_VAA, "Выполнить обработку данных");
            this.buttonDone_VAA.UseVisualStyleBackColor = true;
            this.buttonDone_VAA.Click += new System.EventHandler(this.buttonDone_VAA_Click);
            this.buttonDone_VAA.MouseEnter += new System.EventHandler(this.buttonDone_VAA_MouseEnter);
            // 
            // buttonSaveFile_VAA
            // 
            this.buttonSaveFile_VAA.Enabled = false;
            this.buttonSaveFile_VAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile_VAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_VAA.Image")));
            this.buttonSaveFile_VAA.Location = new System.Drawing.Point(232, 12);
            this.buttonSaveFile_VAA.Name = "buttonSaveFile_VAA";
            this.buttonSaveFile_VAA.Size = new System.Drawing.Size(106, 55);
            this.buttonSaveFile_VAA.TabIndex = 2;
            this.toolTipButton_VAA.SetToolTip(this.buttonSaveFile_VAA, "Сохранить обработанные данные в файл в формате CSV");
            this.buttonSaveFile_VAA.UseVisualStyleBackColor = true;
            this.buttonSaveFile_VAA.Click += new System.EventHandler(this.buttonSaveFile_VAA_Click);
            this.buttonSaveFile_VAA.MouseEnter += new System.EventHandler(this.buttonSaveFile_VAA_MouseEnter);
            // 
            // buttonHelp_VAA
            // 
            this.buttonHelp_VAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_VAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_VAA.Image")));
            this.buttonHelp_VAA.Location = new System.Drawing.Point(681, 12);
            this.buttonHelp_VAA.Name = "buttonHelp_VAA";
            this.buttonHelp_VAA.Size = new System.Drawing.Size(106, 55);
            this.buttonHelp_VAA.TabIndex = 3;
            this.toolTipButton_VAA.SetToolTip(this.buttonHelp_VAA, "Сведения о программе");
            this.buttonHelp_VAA.UseVisualStyleBackColor = true;
            this.buttonHelp_VAA.Click += new System.EventHandler(this.buttonHelp_VAA_Click);
            this.buttonHelp_VAA.MouseEnter += new System.EventHandler(this.buttonHelp_VAA_MouseEnter);
            // 
            // groupBoxTask_VAA
            // 
            this.groupBoxTask_VAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTask_VAA.Controls.Add(this.textBoxTask_VAA);
            this.groupBoxTask_VAA.Location = new System.Drawing.Point(11, 6);
            this.groupBoxTask_VAA.Name = "groupBoxTask_VAA";
            this.groupBoxTask_VAA.Size = new System.Drawing.Size(776, 66);
            this.groupBoxTask_VAA.TabIndex = 0;
            this.groupBoxTask_VAA.TabStop = false;
            this.groupBoxTask_VAA.Text = "Условие:";
            // 
            // groupBoxIn_VAA
            // 
            this.groupBoxIn_VAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxIn_VAA.Controls.Add(this.dataGridViewIn_VAA);
            this.groupBoxIn_VAA.Location = new System.Drawing.Point(11, 6);
            this.groupBoxIn_VAA.Name = "groupBoxIn_VAA";
            this.groupBoxIn_VAA.Size = new System.Drawing.Size(357, 292);
            this.groupBoxIn_VAA.TabIndex = 0;
            this.groupBoxIn_VAA.TabStop = false;
            this.groupBoxIn_VAA.Text = "Ввод:";
            // 
            // groupBoxRes_VAA
            // 
            this.groupBoxRes_VAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRes_VAA.Controls.Add(this.dataGridViewOut_VAA);
            this.groupBoxRes_VAA.Location = new System.Drawing.Point(9, 6);
            this.groupBoxRes_VAA.Name = "groupBoxRes_VAA";
            this.groupBoxRes_VAA.Size = new System.Drawing.Size(395, 292);
            this.groupBoxRes_VAA.TabIndex = 0;
            this.groupBoxRes_VAA.TabStop = false;
            this.groupBoxRes_VAA.Text = "Вывод:";
            // 
            // textBoxTask_VAA
            // 
            this.textBoxTask_VAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTask_VAA.Location = new System.Drawing.Point(7, 22);
            this.textBoxTask_VAA.Multiline = true;
            this.textBoxTask_VAA.Name = "textBoxTask_VAA";
            this.textBoxTask_VAA.ReadOnly = true;
            this.textBoxTask_VAA.Size = new System.Drawing.Size(763, 40);
            this.textBoxTask_VAA.TabIndex = 0;
            this.textBoxTask_VAA.Text = resources.GetString("textBoxTask_VAA.Text");
            // 
            // dataGridViewIn_VAA
            // 
            this.dataGridViewIn_VAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewIn_VAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_VAA.ColumnHeadersVisible = false;
            this.dataGridViewIn_VAA.Location = new System.Drawing.Point(7, 22);
            this.dataGridViewIn_VAA.Name = "dataGridViewIn_VAA";
            this.dataGridViewIn_VAA.ReadOnly = true;
            this.dataGridViewIn_VAA.RowHeadersVisible = false;
            this.dataGridViewIn_VAA.RowHeadersWidth = 51;
            this.dataGridViewIn_VAA.RowTemplate.Height = 24;
            this.dataGridViewIn_VAA.Size = new System.Drawing.Size(344, 264);
            this.dataGridViewIn_VAA.TabIndex = 0;
            // 
            // dataGridViewOut_VAA
            // 
            this.dataGridViewOut_VAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOut_VAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_VAA.ColumnHeadersVisible = false;
            this.dataGridViewOut_VAA.Location = new System.Drawing.Point(7, 22);
            this.dataGridViewOut_VAA.Name = "dataGridViewOut_VAA";
            this.dataGridViewOut_VAA.ReadOnly = true;
            this.dataGridViewOut_VAA.RowHeadersVisible = false;
            this.dataGridViewOut_VAA.RowHeadersWidth = 51;
            this.dataGridViewOut_VAA.RowTemplate.Height = 24;
            this.dataGridViewOut_VAA.Size = new System.Drawing.Size(382, 264);
            this.dataGridViewOut_VAA.TabIndex = 0;
            // 
            // openFileDialogTask_VAA
            // 
            this.openFileDialogTask_VAA.FileName = "openFileDialog1";
            // 
            // toolTipButton_VAA
            // 
            this.toolTipButton_VAA.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolTipButton_VAA.IsBalloon = true;
            this.toolTipButton_VAA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_VAA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelRes_VAA);
            this.Controls.Add(this.panelIn_VAA);
            this.Controls.Add(this.panelTask_VAA);
            this.Controls.Add(this.panelButtons_VAA);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 9 |  Варова А. А.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelButtons_VAA.ResumeLayout(false);
            this.panelTask_VAA.ResumeLayout(false);
            this.panelIn_VAA.ResumeLayout(false);
            this.panelRes_VAA.ResumeLayout(false);
            this.groupBoxTask_VAA.ResumeLayout(false);
            this.groupBoxTask_VAA.PerformLayout();
            this.groupBoxIn_VAA.ResumeLayout(false);
            this.groupBoxRes_VAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_VAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_VAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_VAA;
        private System.Windows.Forms.Button buttonHelp_VAA;
        private System.Windows.Forms.Button buttonSaveFile_VAA;
        private System.Windows.Forms.Button buttonDone_VAA;
        private System.Windows.Forms.Button buttonOpenFile_VAA;
        private System.Windows.Forms.Panel panelTask_VAA;
        private System.Windows.Forms.GroupBox groupBoxTask_VAA;
        private System.Windows.Forms.TextBox textBoxTask_VAA;
        private System.Windows.Forms.Panel panelIn_VAA;
        private System.Windows.Forms.GroupBox groupBoxIn_VAA;
        private System.Windows.Forms.DataGridView dataGridViewIn_VAA;
        private System.Windows.Forms.Panel panelRes_VAA;
        private System.Windows.Forms.GroupBox groupBoxRes_VAA;
        private System.Windows.Forms.DataGridView dataGridViewOut_VAA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_VAA;
        private System.Windows.Forms.ToolTip toolTipButton_VAA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_VAA;
    }
}

