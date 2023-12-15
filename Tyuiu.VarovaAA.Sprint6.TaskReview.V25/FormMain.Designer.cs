
namespace Tyuiu.VarovaAA.Sprint6.TaskReview.V25
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
            this.panelInPut_VAA = new System.Windows.Forms.Panel();
            this.panelRes_VAA = new System.Windows.Forms.Panel();
            this.buttonGenerateMatrix_VAA = new System.Windows.Forms.Button();
            this.buttonCalc_VAA = new System.Windows.Forms.Button();
            this.groupBoxTask_VAA = new System.Windows.Forms.GroupBox();
            this.buttonHelp_VAA = new System.Windows.Forms.Button();
            this.groupBoxInPut_VAA = new System.Windows.Forms.GroupBox();
            this.groupBoxRes_VAA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_VAA = new System.Windows.Forms.TextBox();
            this.textBoxInPutVarN_VAA = new System.Windows.Forms.TextBox();
            this.textBoxInPutVarM_VAA = new System.Windows.Forms.TextBox();
            this.textBoxInPutVarn1_VAA = new System.Windows.Forms.TextBox();
            this.textBoxInPutVarn2_VAA = new System.Windows.Forms.TextBox();
            this.textBoxInPutVarK_VAA = new System.Windows.Forms.TextBox();
            this.textBoxInPutVarL_VAA = new System.Windows.Forms.TextBox();
            this.textBoxInPutVarR_VAA = new System.Windows.Forms.TextBox();
            this.labelVarN_VAA = new System.Windows.Forms.Label();
            this.labelVarM_VAA = new System.Windows.Forms.Label();
            this.labelVarn1_VAA = new System.Windows.Forms.Label();
            this.labelVarn2_VAA = new System.Windows.Forms.Label();
            this.labelVarK_VAA = new System.Windows.Forms.Label();
            this.labelVarL_VAA = new System.Windows.Forms.Label();
            this.labelVarR_VAA = new System.Windows.Forms.Label();
            this.textBoxInPutVarX_VAA = new System.Windows.Forms.TextBox();
            this.labelVarX_VAA = new System.Windows.Forms.Label();
            this.dataGridViewRes_VAA = new System.Windows.Forms.DataGridView();
            this.toolTipButton_VAA = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxResSum_VAA = new System.Windows.Forms.TextBox();
            this.labelResSum_VAA = new System.Windows.Forms.Label();
            this.panelButtons_VAA.SuspendLayout();
            this.panelTask_VAA.SuspendLayout();
            this.panelInPut_VAA.SuspendLayout();
            this.panelRes_VAA.SuspendLayout();
            this.groupBoxTask_VAA.SuspendLayout();
            this.groupBoxInPut_VAA.SuspendLayout();
            this.groupBoxRes_VAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_VAA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons_VAA
            // 
            this.panelButtons_VAA.Controls.Add(this.buttonHelp_VAA);
            this.panelButtons_VAA.Controls.Add(this.buttonCalc_VAA);
            this.panelButtons_VAA.Controls.Add(this.buttonGenerateMatrix_VAA);
            this.panelButtons_VAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_VAA.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_VAA.Name = "panelButtons_VAA";
            this.panelButtons_VAA.Size = new System.Drawing.Size(825, 84);
            this.panelButtons_VAA.TabIndex = 0;
            // 
            // panelTask_VAA
            // 
            this.panelTask_VAA.Controls.Add(this.groupBoxTask_VAA);
            this.panelTask_VAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_VAA.Location = new System.Drawing.Point(0, 84);
            this.panelTask_VAA.Name = "panelTask_VAA";
            this.panelTask_VAA.Size = new System.Drawing.Size(825, 118);
            this.panelTask_VAA.TabIndex = 1;
            this.panelTask_VAA.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTask_VAA_Paint);
            // 
            // panelInPut_VAA
            // 
            this.panelInPut_VAA.Controls.Add(this.groupBoxInPut_VAA);
            this.panelInPut_VAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInPut_VAA.Location = new System.Drawing.Point(0, 202);
            this.panelInPut_VAA.Name = "panelInPut_VAA";
            this.panelInPut_VAA.Size = new System.Drawing.Size(253, 286);
            this.panelInPut_VAA.TabIndex = 2;
            // 
            // panelRes_VAA
            // 
            this.panelRes_VAA.Controls.Add(this.groupBoxRes_VAA);
            this.panelRes_VAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRes_VAA.Location = new System.Drawing.Point(253, 202);
            this.panelRes_VAA.Name = "panelRes_VAA";
            this.panelRes_VAA.Size = new System.Drawing.Size(572, 286);
            this.panelRes_VAA.TabIndex = 3;
            // 
            // buttonGenerateMatrix_VAA
            // 
            this.buttonGenerateMatrix_VAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonGenerateMatrix_VAA.Image")));
            this.buttonGenerateMatrix_VAA.Location = new System.Drawing.Point(12, 12);
            this.buttonGenerateMatrix_VAA.Name = "buttonGenerateMatrix_VAA";
            this.buttonGenerateMatrix_VAA.Size = new System.Drawing.Size(77, 66);
            this.buttonGenerateMatrix_VAA.TabIndex = 0;
            this.toolTipButton_VAA.SetToolTip(this.buttonGenerateMatrix_VAA, "Создать целочисленный двумерный массив N (N>1) на M (M>1) элементов, заполненный " +
        "случайными числами в заданном диапазоне.");
            this.buttonGenerateMatrix_VAA.UseVisualStyleBackColor = true;
            this.buttonGenerateMatrix_VAA.Click += new System.EventHandler(this.buttonGenerateMatrix_VAA_Click);
            // 
            // buttonCalc_VAA
            // 
            this.buttonCalc_VAA.Enabled = false;
            this.buttonCalc_VAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonCalc_VAA.Image")));
            this.buttonCalc_VAA.Location = new System.Drawing.Point(95, 12);
            this.buttonCalc_VAA.Name = "buttonCalc_VAA";
            this.buttonCalc_VAA.Size = new System.Drawing.Size(77, 66);
            this.buttonCalc_VAA.TabIndex = 1;
            this.toolTipButton_VAA.SetToolTip(this.buttonCalc_VAA, "Найти сумму нечётных элементов массива с номерами от K до L (нумерация начинается" +
        " с нуля) включительно в заданной строке R.");
            this.buttonCalc_VAA.UseVisualStyleBackColor = true;
            this.buttonCalc_VAA.Click += new System.EventHandler(this.buttonCalc_VAA_Click);
            // 
            // groupBoxTask_VAA
            // 
            this.groupBoxTask_VAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTask_VAA.Controls.Add(this.textBoxTask_VAA);
            this.groupBoxTask_VAA.Location = new System.Drawing.Point(13, 7);
            this.groupBoxTask_VAA.Name = "groupBoxTask_VAA";
            this.groupBoxTask_VAA.Size = new System.Drawing.Size(800, 105);
            this.groupBoxTask_VAA.TabIndex = 0;
            this.groupBoxTask_VAA.TabStop = false;
            this.groupBoxTask_VAA.Text = "Условие:";
            // 
            // buttonHelp_VAA
            // 
            this.buttonHelp_VAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_VAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_VAA.Image")));
            this.buttonHelp_VAA.Location = new System.Drawing.Point(737, 12);
            this.buttonHelp_VAA.Name = "buttonHelp_VAA";
            this.buttonHelp_VAA.Size = new System.Drawing.Size(77, 66);
            this.buttonHelp_VAA.TabIndex = 2;
            this.toolTipButton_VAA.SetToolTip(this.buttonHelp_VAA, "Сведения о программе");
            this.buttonHelp_VAA.UseVisualStyleBackColor = true;
            this.buttonHelp_VAA.Click += new System.EventHandler(this.buttonHelp_VAA_Click);
            // 
            // groupBoxInPut_VAA
            // 
            this.groupBoxInPut_VAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInPut_VAA.Controls.Add(this.labelVarX_VAA);
            this.groupBoxInPut_VAA.Controls.Add(this.textBoxInPutVarX_VAA);
            this.groupBoxInPut_VAA.Controls.Add(this.labelVarR_VAA);
            this.groupBoxInPut_VAA.Controls.Add(this.labelVarL_VAA);
            this.groupBoxInPut_VAA.Controls.Add(this.labelVarK_VAA);
            this.groupBoxInPut_VAA.Controls.Add(this.labelVarn2_VAA);
            this.groupBoxInPut_VAA.Controls.Add(this.labelVarn1_VAA);
            this.groupBoxInPut_VAA.Controls.Add(this.labelVarM_VAA);
            this.groupBoxInPut_VAA.Controls.Add(this.labelVarN_VAA);
            this.groupBoxInPut_VAA.Controls.Add(this.textBoxInPutVarR_VAA);
            this.groupBoxInPut_VAA.Controls.Add(this.textBoxInPutVarL_VAA);
            this.groupBoxInPut_VAA.Controls.Add(this.textBoxInPutVarK_VAA);
            this.groupBoxInPut_VAA.Controls.Add(this.textBoxInPutVarn2_VAA);
            this.groupBoxInPut_VAA.Controls.Add(this.textBoxInPutVarn1_VAA);
            this.groupBoxInPut_VAA.Controls.Add(this.textBoxInPutVarM_VAA);
            this.groupBoxInPut_VAA.Controls.Add(this.textBoxInPutVarN_VAA);
            this.groupBoxInPut_VAA.Location = new System.Drawing.Point(13, 7);
            this.groupBoxInPut_VAA.Name = "groupBoxInPut_VAA";
            this.groupBoxInPut_VAA.Size = new System.Drawing.Size(234, 276);
            this.groupBoxInPut_VAA.TabIndex = 0;
            this.groupBoxInPut_VAA.TabStop = false;
            this.groupBoxInPut_VAA.Text = "Ввод:";
            // 
            // groupBoxRes_VAA
            // 
            this.groupBoxRes_VAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRes_VAA.Controls.Add(this.labelResSum_VAA);
            this.groupBoxRes_VAA.Controls.Add(this.textBoxResSum_VAA);
            this.groupBoxRes_VAA.Controls.Add(this.dataGridViewRes_VAA);
            this.groupBoxRes_VAA.Location = new System.Drawing.Point(10, 7);
            this.groupBoxRes_VAA.Name = "groupBoxRes_VAA";
            this.groupBoxRes_VAA.Size = new System.Drawing.Size(550, 276);
            this.groupBoxRes_VAA.TabIndex = 0;
            this.groupBoxRes_VAA.TabStop = false;
            this.groupBoxRes_VAA.Text = "Вывод:";
            // 
            // textBoxTask_VAA
            // 
            this.textBoxTask_VAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTask_VAA.Location = new System.Drawing.Point(7, 22);
            this.textBoxTask_VAA.Multiline = true;
            this.textBoxTask_VAA.Name = "textBoxTask_VAA";
            this.textBoxTask_VAA.ReadOnly = true;
            this.textBoxTask_VAA.Size = new System.Drawing.Size(787, 77);
            this.textBoxTask_VAA.TabIndex = 0;
            this.textBoxTask_VAA.Text = resources.GetString("textBoxTask_VAA.Text");
            // 
            // textBoxInPutVarN_VAA
            // 
            this.textBoxInPutVarN_VAA.Location = new System.Drawing.Point(7, 42);
            this.textBoxInPutVarN_VAA.Name = "textBoxInPutVarN_VAA";
            this.textBoxInPutVarN_VAA.Size = new System.Drawing.Size(100, 22);
            this.textBoxInPutVarN_VAA.TabIndex = 0;
            this.textBoxInPutVarN_VAA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxInPutVarM_VAA
            // 
            this.textBoxInPutVarM_VAA.Location = new System.Drawing.Point(114, 42);
            this.textBoxInPutVarM_VAA.Name = "textBoxInPutVarM_VAA";
            this.textBoxInPutVarM_VAA.Size = new System.Drawing.Size(100, 22);
            this.textBoxInPutVarM_VAA.TabIndex = 1;
            // 
            // textBoxInPutVarn1_VAA
            // 
            this.textBoxInPutVarn1_VAA.Location = new System.Drawing.Point(7, 97);
            this.textBoxInPutVarn1_VAA.Name = "textBoxInPutVarn1_VAA";
            this.textBoxInPutVarn1_VAA.Size = new System.Drawing.Size(100, 22);
            this.textBoxInPutVarn1_VAA.TabIndex = 2;
            // 
            // textBoxInPutVarn2_VAA
            // 
            this.textBoxInPutVarn2_VAA.Location = new System.Drawing.Point(114, 96);
            this.textBoxInPutVarn2_VAA.Name = "textBoxInPutVarn2_VAA";
            this.textBoxInPutVarn2_VAA.Size = new System.Drawing.Size(100, 22);
            this.textBoxInPutVarn2_VAA.TabIndex = 3;
            // 
            // textBoxInPutVarK_VAA
            // 
            this.textBoxInPutVarK_VAA.Location = new System.Drawing.Point(7, 192);
            this.textBoxInPutVarK_VAA.Name = "textBoxInPutVarK_VAA";
            this.textBoxInPutVarK_VAA.Size = new System.Drawing.Size(100, 22);
            this.textBoxInPutVarK_VAA.TabIndex = 4;
            // 
            // textBoxInPutVarL_VAA
            // 
            this.textBoxInPutVarL_VAA.Location = new System.Drawing.Point(114, 192);
            this.textBoxInPutVarL_VAA.Name = "textBoxInPutVarL_VAA";
            this.textBoxInPutVarL_VAA.Size = new System.Drawing.Size(100, 22);
            this.textBoxInPutVarL_VAA.TabIndex = 5;
            // 
            // textBoxInPutVarR_VAA
            // 
            this.textBoxInPutVarR_VAA.Location = new System.Drawing.Point(7, 237);
            this.textBoxInPutVarR_VAA.Name = "textBoxInPutVarR_VAA";
            this.textBoxInPutVarR_VAA.Size = new System.Drawing.Size(100, 22);
            this.textBoxInPutVarR_VAA.TabIndex = 6;
            // 
            // labelVarN_VAA
            // 
            this.labelVarN_VAA.AutoSize = true;
            this.labelVarN_VAA.Location = new System.Drawing.Point(7, 22);
            this.labelVarN_VAA.Name = "labelVarN_VAA";
            this.labelVarN_VAA.Size = new System.Drawing.Size(105, 17);
            this.labelVarN_VAA.TabIndex = 7;
            this.labelVarN_VAA.Text = "Переменная N";
            // 
            // labelVarM_VAA
            // 
            this.labelVarM_VAA.AutoSize = true;
            this.labelVarM_VAA.Location = new System.Drawing.Point(114, 22);
            this.labelVarM_VAA.Name = "labelVarM_VAA";
            this.labelVarM_VAA.Size = new System.Drawing.Size(106, 17);
            this.labelVarM_VAA.TabIndex = 8;
            this.labelVarM_VAA.Text = "Переменная M";
            // 
            // labelVarn1_VAA
            // 
            this.labelVarn1_VAA.AutoSize = true;
            this.labelVarn1_VAA.Location = new System.Drawing.Point(7, 71);
            this.labelVarn1_VAA.Name = "labelVarn1_VAA";
            this.labelVarn1_VAA.Size = new System.Drawing.Size(111, 17);
            this.labelVarn1_VAA.TabIndex = 9;
            this.labelVarn1_VAA.Text = "Переменная n1";
            // 
            // labelVarn2_VAA
            // 
            this.labelVarn2_VAA.AutoSize = true;
            this.labelVarn2_VAA.Location = new System.Drawing.Point(114, 71);
            this.labelVarn2_VAA.Name = "labelVarn2_VAA";
            this.labelVarn2_VAA.Size = new System.Drawing.Size(111, 17);
            this.labelVarn2_VAA.TabIndex = 10;
            this.labelVarn2_VAA.Text = "Переменная n2";
            // 
            // labelVarK_VAA
            // 
            this.labelVarK_VAA.AutoSize = true;
            this.labelVarK_VAA.Location = new System.Drawing.Point(7, 172);
            this.labelVarK_VAA.Name = "labelVarK_VAA";
            this.labelVarK_VAA.Size = new System.Drawing.Size(104, 17);
            this.labelVarK_VAA.TabIndex = 11;
            this.labelVarK_VAA.Text = "Переменная K";
            // 
            // labelVarL_VAA
            // 
            this.labelVarL_VAA.AutoSize = true;
            this.labelVarL_VAA.Location = new System.Drawing.Point(114, 172);
            this.labelVarL_VAA.Name = "labelVarL_VAA";
            this.labelVarL_VAA.Size = new System.Drawing.Size(103, 17);
            this.labelVarL_VAA.TabIndex = 12;
            this.labelVarL_VAA.Text = "Переменная L";
            // 
            // labelVarR_VAA
            // 
            this.labelVarR_VAA.AutoSize = true;
            this.labelVarR_VAA.Location = new System.Drawing.Point(7, 217);
            this.labelVarR_VAA.Name = "labelVarR_VAA";
            this.labelVarR_VAA.Size = new System.Drawing.Size(105, 17);
            this.labelVarR_VAA.TabIndex = 13;
            this.labelVarR_VAA.Text = "Переменная R";
            // 
            // textBoxInPutVarX_VAA
            // 
            this.textBoxInPutVarX_VAA.Location = new System.Drawing.Point(7, 147);
            this.textBoxInPutVarX_VAA.Name = "textBoxInPutVarX_VAA";
            this.textBoxInPutVarX_VAA.Size = new System.Drawing.Size(100, 22);
            this.textBoxInPutVarX_VAA.TabIndex = 14;
            // 
            // labelVarX_VAA
            // 
            this.labelVarX_VAA.AutoSize = true;
            this.labelVarX_VAA.Location = new System.Drawing.Point(7, 126);
            this.labelVarX_VAA.Name = "labelVarX_VAA";
            this.labelVarX_VAA.Size = new System.Drawing.Size(104, 17);
            this.labelVarX_VAA.TabIndex = 15;
            this.labelVarX_VAA.Text = "Переменная X";
            // 
            // dataGridViewRes_VAA
            // 
            this.dataGridViewRes_VAA.AllowUserToOrderColumns = true;
            this.dataGridViewRes_VAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRes_VAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes_VAA.ColumnHeadersVisible = false;
            this.dataGridViewRes_VAA.Location = new System.Drawing.Point(7, 56);
            this.dataGridViewRes_VAA.Name = "dataGridViewRes_VAA";
            this.dataGridViewRes_VAA.ReadOnly = true;
            this.dataGridViewRes_VAA.RowHeadersVisible = false;
            this.dataGridViewRes_VAA.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewRes_VAA.RowTemplate.Height = 24;
            this.dataGridViewRes_VAA.Size = new System.Drawing.Size(537, 214);
            this.dataGridViewRes_VAA.TabIndex = 0;
            this.dataGridViewRes_VAA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRes_VAA_CellContentClick);
            // 
            // toolTipButton_VAA
            // 
            this.toolTipButton_VAA.ToolTipTitle = "Подсказка";
            // 
            // textBoxResSum_VAA
            // 
            this.textBoxResSum_VAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResSum_VAA.Location = new System.Drawing.Point(414, 28);
            this.textBoxResSum_VAA.Name = "textBoxResSum_VAA";
            this.textBoxResSum_VAA.ReadOnly = true;
            this.textBoxResSum_VAA.Size = new System.Drawing.Size(129, 22);
            this.textBoxResSum_VAA.TabIndex = 1;
            // 
            // labelResSum_VAA
            // 
            this.labelResSum_VAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResSum_VAA.AutoSize = true;
            this.labelResSum_VAA.Location = new System.Drawing.Point(411, 8);
            this.labelResSum_VAA.Name = "labelResSum_VAA";
            this.labelResSum_VAA.Size = new System.Drawing.Size(133, 17);
            this.labelResSum_VAA.TabIndex = 2;
            this.labelResSum_VAA.Text = "Полученная сумма";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 488);
            this.Controls.Add(this.panelRes_VAA);
            this.Controls.Add(this.panelInPut_VAA);
            this.Controls.Add(this.panelTask_VAA);
            this.Controls.Add(this.panelButtons_VAA);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(843, 535);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | TaskReview | Вариант 25 |  Варова А. А.";
            this.panelButtons_VAA.ResumeLayout(false);
            this.panelTask_VAA.ResumeLayout(false);
            this.panelInPut_VAA.ResumeLayout(false);
            this.panelRes_VAA.ResumeLayout(false);
            this.groupBoxTask_VAA.ResumeLayout(false);
            this.groupBoxTask_VAA.PerformLayout();
            this.groupBoxInPut_VAA.ResumeLayout(false);
            this.groupBoxInPut_VAA.PerformLayout();
            this.groupBoxRes_VAA.ResumeLayout(false);
            this.groupBoxRes_VAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_VAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_VAA;
        private System.Windows.Forms.Button buttonGenerateMatrix_VAA;
        private System.Windows.Forms.Panel panelTask_VAA;
        private System.Windows.Forms.Panel panelInPut_VAA;
        private System.Windows.Forms.Panel panelRes_VAA;
        private System.Windows.Forms.Button buttonCalc_VAA;
        private System.Windows.Forms.Button buttonHelp_VAA;
        private System.Windows.Forms.GroupBox groupBoxTask_VAA;
        private System.Windows.Forms.TextBox textBoxTask_VAA;
        private System.Windows.Forms.GroupBox groupBoxInPut_VAA;
        private System.Windows.Forms.Label labelVarN_VAA;
        private System.Windows.Forms.TextBox textBoxInPutVarR_VAA;
        private System.Windows.Forms.TextBox textBoxInPutVarL_VAA;
        private System.Windows.Forms.TextBox textBoxInPutVarK_VAA;
        private System.Windows.Forms.TextBox textBoxInPutVarn2_VAA;
        private System.Windows.Forms.TextBox textBoxInPutVarn1_VAA;
        private System.Windows.Forms.TextBox textBoxInPutVarM_VAA;
        private System.Windows.Forms.TextBox textBoxInPutVarN_VAA;
        private System.Windows.Forms.GroupBox groupBoxRes_VAA;
        private System.Windows.Forms.Label labelVarR_VAA;
        private System.Windows.Forms.Label labelVarL_VAA;
        private System.Windows.Forms.Label labelVarK_VAA;
        private System.Windows.Forms.Label labelVarn2_VAA;
        private System.Windows.Forms.Label labelVarn1_VAA;
        private System.Windows.Forms.Label labelVarM_VAA;
        private System.Windows.Forms.Label labelVarX_VAA;
        private System.Windows.Forms.TextBox textBoxInPutVarX_VAA;
        private System.Windows.Forms.DataGridView dataGridViewRes_VAA;
        private System.Windows.Forms.ToolTip toolTipButton_VAA;
        private System.Windows.Forms.Label labelResSum_VAA;
        private System.Windows.Forms.TextBox textBoxResSum_VAA;
    }
}

