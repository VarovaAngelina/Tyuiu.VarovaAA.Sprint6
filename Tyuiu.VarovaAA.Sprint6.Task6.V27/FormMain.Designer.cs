
namespace Tyuiu.VarovaAA.Sprint6.Task6.V27
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonOpenFile_VAA = new System.Windows.Forms.Button();
            this.buttonDone_VAA = new System.Windows.Forms.Button();
            this.buttonHelp_VAA = new System.Windows.Forms.Button();
            this.groupBoxTask_VAA = new System.Windows.Forms.GroupBox();
            this.groupBoxIn_VAA = new System.Windows.Forms.GroupBox();
            this.groupBoxOut_VAA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_VAA = new System.Windows.Forms.TextBox();
            this.textBoxIn_VAA = new System.Windows.Forms.TextBox();
            this.textBoxOut_VAA = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_VAA = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_VAA = new System.Windows.Forms.ToolTip(this.components);
            this.splitterInOut_VAA = new System.Windows.Forms.Splitter();
            this.panelButtons_VAA.SuspendLayout();
            this.panelTask_VAA.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBoxTask_VAA.SuspendLayout();
            this.groupBoxIn_VAA.SuspendLayout();
            this.groupBoxOut_VAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons_VAA
            // 
            this.panelButtons_VAA.Controls.Add(this.buttonHelp_VAA);
            this.panelButtons_VAA.Controls.Add(this.buttonDone_VAA);
            this.panelButtons_VAA.Controls.Add(this.buttonOpenFile_VAA);
            this.panelButtons_VAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_VAA.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_VAA.Name = "panelButtons_VAA";
            this.panelButtons_VAA.Size = new System.Drawing.Size(982, 84);
            this.panelButtons_VAA.TabIndex = 0;
            // 
            // panelTask_VAA
            // 
            this.panelTask_VAA.Controls.Add(this.groupBoxTask_VAA);
            this.panelTask_VAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_VAA.Location = new System.Drawing.Point(0, 84);
            this.panelTask_VAA.Name = "panelTask_VAA";
            this.panelTask_VAA.Size = new System.Drawing.Size(982, 100);
            this.panelTask_VAA.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBoxIn_VAA);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 184);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(490, 326);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBoxOut_VAA);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(490, 184);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(492, 326);
            this.panel4.TabIndex = 3;
            // 
            // buttonOpenFile_VAA
            // 
            this.buttonOpenFile_VAA.Location = new System.Drawing.Point(3, 3);
            this.buttonOpenFile_VAA.Name = "buttonOpenFile_VAA";
            this.buttonOpenFile_VAA.Size = new System.Drawing.Size(138, 75);
            this.buttonOpenFile_VAA.TabIndex = 0;
            this.buttonOpenFile_VAA.Text = "Открыть файл";
            this.toolTip_VAA.SetToolTip(this.buttonOpenFile_VAA, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile_VAA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_VAA.Click += new System.EventHandler(this.buttonOpenFile_VAA_Click);
            // 
            // buttonDone_VAA
            // 
            this.buttonDone_VAA.Location = new System.Drawing.Point(147, 3);
            this.buttonDone_VAA.Name = "buttonDone_VAA";
            this.buttonDone_VAA.Size = new System.Drawing.Size(138, 75);
            this.buttonDone_VAA.TabIndex = 1;
            this.buttonDone_VAA.Text = "Выполнить";
            this.toolTip_VAA.SetToolTip(this.buttonDone_VAA, "Производит поиск в файле вхождений символа \"H\"\r\nи выводит слова, в которых находи" +
        "т этот символ, \r\nв одну строку.");
            this.buttonDone_VAA.UseVisualStyleBackColor = true;
            this.buttonDone_VAA.Click += new System.EventHandler(this.buttonDone_VAA_Click);
            // 
            // buttonHelp_VAA
            // 
            this.buttonHelp_VAA.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonHelp_VAA.Location = new System.Drawing.Point(841, 3);
            this.buttonHelp_VAA.Name = "buttonHelp_VAA";
            this.buttonHelp_VAA.Size = new System.Drawing.Size(138, 75);
            this.buttonHelp_VAA.TabIndex = 2;
            this.buttonHelp_VAA.Text = "Справка";
            this.toolTip_VAA.SetToolTip(this.buttonHelp_VAA, "Сведения о программе");
            this.buttonHelp_VAA.UseVisualStyleBackColor = true;
            this.buttonHelp_VAA.Click += new System.EventHandler(this.buttonHelp_VAA_Click);
            // 
            // groupBoxTask_VAA
            // 
            this.groupBoxTask_VAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTask_VAA.Controls.Add(this.textBoxTask_VAA);
            this.groupBoxTask_VAA.Location = new System.Drawing.Point(4, 7);
            this.groupBoxTask_VAA.Name = "groupBoxTask_VAA";
            this.groupBoxTask_VAA.Size = new System.Drawing.Size(975, 87);
            this.groupBoxTask_VAA.TabIndex = 0;
            this.groupBoxTask_VAA.TabStop = false;
            this.groupBoxTask_VAA.Text = "Условие:";
            // 
            // groupBoxIn_VAA
            // 
            this.groupBoxIn_VAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxIn_VAA.Controls.Add(this.textBoxIn_VAA);
            this.groupBoxIn_VAA.Location = new System.Drawing.Point(4, 7);
            this.groupBoxIn_VAA.Name = "groupBoxIn_VAA";
            this.groupBoxIn_VAA.Size = new System.Drawing.Size(477, 316);
            this.groupBoxIn_VAA.TabIndex = 0;
            this.groupBoxIn_VAA.TabStop = false;
            this.groupBoxIn_VAA.Text = "Ввод:";
            // 
            // groupBoxOut_VAA
            // 
            this.groupBoxOut_VAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOut_VAA.Controls.Add(this.textBoxOut_VAA);
            this.groupBoxOut_VAA.Location = new System.Drawing.Point(3, 7);
            this.groupBoxOut_VAA.Name = "groupBoxOut_VAA";
            this.groupBoxOut_VAA.Size = new System.Drawing.Size(486, 316);
            this.groupBoxOut_VAA.TabIndex = 1;
            this.groupBoxOut_VAA.TabStop = false;
            this.groupBoxOut_VAA.Text = "Вывод:";
            // 
            // textBoxTask_VAA
            // 
            this.textBoxTask_VAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTask_VAA.Location = new System.Drawing.Point(7, 22);
            this.textBoxTask_VAA.Multiline = true;
            this.textBoxTask_VAA.Name = "textBoxTask_VAA";
            this.textBoxTask_VAA.ReadOnly = true;
            this.textBoxTask_VAA.Size = new System.Drawing.Size(962, 59);
            this.textBoxTask_VAA.TabIndex = 0;
            this.textBoxTask_VAA.Text = resources.GetString("textBoxTask_VAA.Text");
            // 
            // textBoxIn_VAA
            // 
            this.textBoxIn_VAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIn_VAA.Location = new System.Drawing.Point(9, 22);
            this.textBoxIn_VAA.Multiline = true;
            this.textBoxIn_VAA.Name = "textBoxIn_VAA";
            this.textBoxIn_VAA.ReadOnly = true;
            this.textBoxIn_VAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIn_VAA.Size = new System.Drawing.Size(462, 285);
            this.textBoxIn_VAA.TabIndex = 0;
            // 
            // textBoxOut_VAA
            // 
            this.textBoxOut_VAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOut_VAA.Location = new System.Drawing.Point(7, 22);
            this.textBoxOut_VAA.Multiline = true;
            this.textBoxOut_VAA.Name = "textBoxOut_VAA";
            this.textBoxOut_VAA.ReadOnly = true;
            this.textBoxOut_VAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut_VAA.Size = new System.Drawing.Size(473, 288);
            this.textBoxOut_VAA.TabIndex = 0;
            // 
            // openFileDialogTask_VAA
            // 
            this.openFileDialogTask_VAA.FileName = "openFileDialog1";
            // 
            // toolTip_VAA
            // 
            this.toolTip_VAA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_VAA.ToolTipTitle = "Подсказка";
            // 
            // splitterInOut_VAA
            // 
            this.splitterInOut_VAA.Location = new System.Drawing.Point(490, 184);
            this.splitterInOut_VAA.Name = "splitterInOut_VAA";
            this.splitterInOut_VAA.Size = new System.Drawing.Size(3, 326);
            this.splitterInOut_VAA.TabIndex = 4;
            this.splitterInOut_VAA.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 510);
            this.Controls.Add(this.splitterInOut_VAA);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelTask_VAA);
            this.Controls.Add(this.panelButtons_VAA);
            this.MinimumSize = new System.Drawing.Size(1000, 557);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 27 |  Варова А. А.";
            this.panelButtons_VAA.ResumeLayout(false);
            this.panelTask_VAA.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBoxTask_VAA.ResumeLayout(false);
            this.groupBoxTask_VAA.PerformLayout();
            this.groupBoxIn_VAA.ResumeLayout(false);
            this.groupBoxIn_VAA.PerformLayout();
            this.groupBoxOut_VAA.ResumeLayout(false);
            this.groupBoxOut_VAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_VAA;
        private System.Windows.Forms.Panel panelTask_VAA;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonHelp_VAA;
        private System.Windows.Forms.Button buttonDone_VAA;
        private System.Windows.Forms.Button buttonOpenFile_VAA;
        private System.Windows.Forms.GroupBox groupBoxTask_VAA;
        private System.Windows.Forms.TextBox textBoxTask_VAA;
        private System.Windows.Forms.GroupBox groupBoxIn_VAA;
        private System.Windows.Forms.GroupBox groupBoxOut_VAA;
        private System.Windows.Forms.TextBox textBoxIn_VAA;
        private System.Windows.Forms.TextBox textBoxOut_VAA;
        private System.Windows.Forms.ToolTip toolTip_VAA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_VAA;
        private System.Windows.Forms.Splitter splitterInOut_VAA;
    }
}

