
namespace Tyuiu.VarovaAA.Sprint6.Task0.V26
{
    partial class FormMain_VAA
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
            this.buttonDone_VAA = new System.Windows.Forms.Button();
            this.groupBoxUslovie_VAA = new System.Windows.Forms.GroupBox();
            this.labelUslovie_VAA = new System.Windows.Forms.Label();
            this.groupBoxInput_VAA = new System.Windows.Forms.GroupBox();
            this.labelVarX_VAA = new System.Windows.Forms.Label();
            this.textBoxVarX_VAA = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_VAA = new System.Windows.Forms.GroupBox();
            this.labelRes_VAA = new System.Windows.Forms.Label();
            this.textBoxRes_VAA = new System.Windows.Forms.TextBox();
            this.buttonVopros_VAA = new System.Windows.Forms.Button();
            this.pictureBoxFormula_VAA = new System.Windows.Forms.PictureBox();
            this.groupBoxUslovie_VAA.SuspendLayout();
            this.groupBoxInput_VAA.SuspendLayout();
            this.groupBoxOutput_VAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_VAA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone_VAA
            // 
            this.buttonDone_VAA.Location = new System.Drawing.Point(378, 339);
            this.buttonDone_VAA.Name = "buttonDone_VAA";
            this.buttonDone_VAA.Size = new System.Drawing.Size(221, 48);
            this.buttonDone_VAA.TabIndex = 0;
            this.buttonDone_VAA.Text = "Выполнить";
            this.buttonDone_VAA.UseVisualStyleBackColor = true;
            this.buttonDone_VAA.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // groupBoxUslovie_VAA
            // 
            this.groupBoxUslovie_VAA.Controls.Add(this.pictureBoxFormula_VAA);
            this.groupBoxUslovie_VAA.Controls.Add(this.labelUslovie_VAA);
            this.groupBoxUslovie_VAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUslovie_VAA.Name = "groupBoxUslovie_VAA";
            this.groupBoxUslovie_VAA.Size = new System.Drawing.Size(587, 165);
            this.groupBoxUslovie_VAA.TabIndex = 1;
            this.groupBoxUslovie_VAA.TabStop = false;
            this.groupBoxUslovie_VAA.Text = "Условие";
            this.groupBoxUslovie_VAA.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelUslovie_VAA
            // 
            this.labelUslovie_VAA.AutoSize = true;
            this.labelUslovie_VAA.Location = new System.Drawing.Point(9, 22);
            this.labelUslovie_VAA.Name = "labelUslovie_VAA";
            this.labelUslovie_VAA.Size = new System.Drawing.Size(241, 17);
            this.labelUslovie_VAA.TabIndex = 0;
            this.labelUslovie_VAA.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxInput_VAA
            // 
            this.groupBoxInput_VAA.Controls.Add(this.labelVarX_VAA);
            this.groupBoxInput_VAA.Controls.Add(this.textBoxVarX_VAA);
            this.groupBoxInput_VAA.Location = new System.Drawing.Point(14, 184);
            this.groupBoxInput_VAA.Name = "groupBoxInput_VAA";
            this.groupBoxInput_VAA.Size = new System.Drawing.Size(285, 125);
            this.groupBoxInput_VAA.TabIndex = 2;
            this.groupBoxInput_VAA.TabStop = false;
            this.groupBoxInput_VAA.Text = "Ввод данных";
            // 
            // labelVarX_VAA
            // 
            this.labelVarX_VAA.AutoSize = true;
            this.labelVarX_VAA.Location = new System.Drawing.Point(7, 22);
            this.labelVarX_VAA.Name = "labelVarX_VAA";
            this.labelVarX_VAA.Size = new System.Drawing.Size(108, 17);
            this.labelVarX_VAA.TabIndex = 1;
            this.labelVarX_VAA.Text = "Переменная X:";
            // 
            // textBoxVarX_VAA
            // 
            this.textBoxVarX_VAA.Location = new System.Drawing.Point(6, 48);
            this.textBoxVarX_VAA.Name = "textBoxVarX_VAA";
            this.textBoxVarX_VAA.Size = new System.Drawing.Size(130, 22);
            this.textBoxVarX_VAA.TabIndex = 0;
            // 
            // groupBoxOutput_VAA
            // 
            this.groupBoxOutput_VAA.Controls.Add(this.labelRes_VAA);
            this.groupBoxOutput_VAA.Controls.Add(this.textBoxRes_VAA);
            this.groupBoxOutput_VAA.Location = new System.Drawing.Point(305, 184);
            this.groupBoxOutput_VAA.Name = "groupBoxOutput_VAA";
            this.groupBoxOutput_VAA.Size = new System.Drawing.Size(294, 125);
            this.groupBoxOutput_VAA.TabIndex = 3;
            this.groupBoxOutput_VAA.TabStop = false;
            this.groupBoxOutput_VAA.Text = "Вывод данных";
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
            // textBoxRes_VAA
            // 
            this.textBoxRes_VAA.Location = new System.Drawing.Point(7, 47);
            this.textBoxRes_VAA.Name = "textBoxRes_VAA";
            this.textBoxRes_VAA.ReadOnly = true;
            this.textBoxRes_VAA.Size = new System.Drawing.Size(139, 22);
            this.textBoxRes_VAA.TabIndex = 0;
            // 
            // buttonVopros_VAA
            // 
            this.buttonVopros_VAA.Location = new System.Drawing.Point(315, 339);
            this.buttonVopros_VAA.Name = "buttonVopros_VAA";
            this.buttonVopros_VAA.Size = new System.Drawing.Size(57, 48);
            this.buttonVopros_VAA.TabIndex = 4;
            this.buttonVopros_VAA.Text = "?";
            this.buttonVopros_VAA.UseVisualStyleBackColor = true;
            this.buttonVopros_VAA.Click += new System.EventHandler(this.buttonVopros_VAA_Click);
            // 
            // pictureBoxFormula_VAA
            // 
            this.pictureBoxFormula_VAA.ErrorImage = null;
            this.pictureBoxFormula_VAA.Image = global::Tyuiu.VarovaAA.Sprint6.Task0.V26.Properties.Resources.Opera_Снимок_2023_12_02_212057_educon2_tyuiu_ru;
            this.pictureBoxFormula_VAA.InitialImage = null;
            this.pictureBoxFormula_VAA.Location = new System.Drawing.Point(400, 22);
            this.pictureBoxFormula_VAA.Name = "pictureBoxFormula_VAA";
            this.pictureBoxFormula_VAA.Size = new System.Drawing.Size(172, 79);
            this.pictureBoxFormula_VAA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFormula_VAA.TabIndex = 1;
            this.pictureBoxFormula_VAA.TabStop = false;
            // 
            // FormMain_VAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 399);
            this.Controls.Add(this.buttonVopros_VAA);
            this.Controls.Add(this.groupBoxOutput_VAA);
            this.Controls.Add(this.groupBoxInput_VAA);
            this.Controls.Add(this.groupBoxUslovie_VAA);
            this.Controls.Add(this.buttonDone_VAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_VAA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 26 | Варова А. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxUslovie_VAA.ResumeLayout(false);
            this.groupBoxUslovie_VAA.PerformLayout();
            this.groupBoxInput_VAA.ResumeLayout(false);
            this.groupBoxInput_VAA.PerformLayout();
            this.groupBoxOutput_VAA.ResumeLayout(false);
            this.groupBoxOutput_VAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_VAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_VAA;
        private System.Windows.Forms.GroupBox groupBoxUslovie_VAA;
        private System.Windows.Forms.Label labelUslovie_VAA;
        private System.Windows.Forms.GroupBox groupBoxInput_VAA;
        private System.Windows.Forms.Label labelVarX_VAA;
        private System.Windows.Forms.TextBox textBoxVarX_VAA;
        private System.Windows.Forms.GroupBox groupBoxOutput_VAA;
        private System.Windows.Forms.Label labelRes_VAA;
        private System.Windows.Forms.TextBox textBoxRes_VAA;
        private System.Windows.Forms.Button buttonVopros_VAA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_VAA;
    }
}

