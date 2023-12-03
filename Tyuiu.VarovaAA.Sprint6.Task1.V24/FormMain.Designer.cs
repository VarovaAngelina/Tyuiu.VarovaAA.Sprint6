
namespace Tyuiu.VarovaAA.Sprint6.Task1.V24
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
            this.groupBoxTask_VAA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_VAA = new System.Windows.Forms.TextBox();
            this.groupBoxRes_VAA = new System.Windows.Forms.GroupBox();
            this.labelRes_VAA = new System.Windows.Forms.Label();
            this.textBoxRes_VAA = new System.Windows.Forms.TextBox();
            this.groupBoxInput_VAA = new System.Windows.Forms.GroupBox();
            this.labelVarStop_VAA = new System.Windows.Forms.Label();
            this.labelInputVarStart_VAA = new System.Windows.Forms.Label();
            this.textBoxVarStop_VAA = new System.Windows.Forms.TextBox();
            this.textBoxVarStart_VAA = new System.Windows.Forms.TextBox();
            this.buttonHelp_VAA = new System.Windows.Forms.Button();
            this.buttonDone_VAA = new System.Windows.Forms.Button();
            this.groupBoxTask_VAA.SuspendLayout();
            this.groupBoxRes_VAA.SuspendLayout();
            this.groupBoxInput_VAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_VAA
            // 
            this.groupBoxTask_VAA.Controls.Add(this.textBoxTask_VAA);
            this.groupBoxTask_VAA.Location = new System.Drawing.Point(13, 14);
            this.groupBoxTask_VAA.Name = "groupBoxTask_VAA";
            this.groupBoxTask_VAA.Size = new System.Drawing.Size(523, 255);
            this.groupBoxTask_VAA.TabIndex = 0;
            this.groupBoxTask_VAA.TabStop = false;
            this.groupBoxTask_VAA.Text = "Условие";
            // 
            // textBoxTask_VAA
            // 
            this.textBoxTask_VAA.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxTask_VAA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxTask_VAA.Location = new System.Drawing.Point(7, 22);
            this.textBoxTask_VAA.Multiline = true;
            this.textBoxTask_VAA.Name = "textBoxTask_VAA";
            this.textBoxTask_VAA.Size = new System.Drawing.Size(491, 63);
            this.textBoxTask_VAA.TabIndex = 0;
            this.textBoxTask_VAA.Text = "Протаулировать функцию (Sin(x))/(x + 1,7) - Cos(x) * 4x - 6 на заданном диапазоне" +
    ".\r\nРезультат вывести в виде таблицы.";
            this.textBoxTask_VAA.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // groupBoxRes_VAA
            // 
            this.groupBoxRes_VAA.Controls.Add(this.labelRes_VAA);
            this.groupBoxRes_VAA.Controls.Add(this.textBoxRes_VAA);
            this.groupBoxRes_VAA.Location = new System.Drawing.Point(542, 14);
            this.groupBoxRes_VAA.Name = "groupBoxRes_VAA";
            this.groupBoxRes_VAA.Size = new System.Drawing.Size(246, 323);
            this.groupBoxRes_VAA.TabIndex = 1;
            this.groupBoxRes_VAA.TabStop = false;
            this.groupBoxRes_VAA.Text = "Вывод данных:";
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
            this.textBoxRes_VAA.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRes_VAA.Location = new System.Drawing.Point(8, 42);
            this.textBoxRes_VAA.Multiline = true;
            this.textBoxRes_VAA.Name = "textBoxRes_VAA";
            this.textBoxRes_VAA.ReadOnly = true;
            this.textBoxRes_VAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRes_VAA.Size = new System.Drawing.Size(233, 276);
            this.textBoxRes_VAA.TabIndex = 0;
            this.textBoxRes_VAA.TextChanged += new System.EventHandler(this.textBoxRes_VAA_TextChanged);
            // 
            // groupBoxInput_VAA
            // 
            this.groupBoxInput_VAA.Controls.Add(this.labelVarStop_VAA);
            this.groupBoxInput_VAA.Controls.Add(this.labelInputVarStart_VAA);
            this.groupBoxInput_VAA.Controls.Add(this.textBoxVarStop_VAA);
            this.groupBoxInput_VAA.Controls.Add(this.textBoxVarStart_VAA);
            this.groupBoxInput_VAA.Location = new System.Drawing.Point(13, 276);
            this.groupBoxInput_VAA.Name = "groupBoxInput_VAA";
            this.groupBoxInput_VAA.Size = new System.Drawing.Size(301, 75);
            this.groupBoxInput_VAA.TabIndex = 2;
            this.groupBoxInput_VAA.TabStop = false;
            this.groupBoxInput_VAA.Text = "Ввод данных:";
            // 
            // labelVarStop_VAA
            // 
            this.labelVarStop_VAA.AutoSize = true;
            this.labelVarStop_VAA.Location = new System.Drawing.Point(153, 21);
            this.labelVarStop_VAA.Name = "labelVarStop_VAA";
            this.labelVarStop_VAA.Size = new System.Drawing.Size(89, 17);
            this.labelVarStop_VAA.TabIndex = 3;
            this.labelVarStop_VAA.Text = "Конец шага:";
            // 
            // labelInputVarStart_VAA
            // 
            this.labelInputVarStart_VAA.AutoSize = true;
            this.labelInputVarStart_VAA.Location = new System.Drawing.Point(6, 24);
            this.labelInputVarStart_VAA.Name = "labelInputVarStart_VAA";
            this.labelInputVarStart_VAA.Size = new System.Drawing.Size(87, 17);
            this.labelInputVarStart_VAA.TabIndex = 2;
            this.labelInputVarStart_VAA.Text = "Старт шага:";
            // 
            // textBoxVarStop_VAA
            // 
            this.textBoxVarStop_VAA.Location = new System.Drawing.Point(153, 44);
            this.textBoxVarStop_VAA.Name = "textBoxVarStop_VAA";
            this.textBoxVarStop_VAA.Size = new System.Drawing.Size(142, 22);
            this.textBoxVarStop_VAA.TabIndex = 1;
            this.textBoxVarStop_VAA.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxVarStart_VAA
            // 
            this.textBoxVarStart_VAA.Location = new System.Drawing.Point(6, 44);
            this.textBoxVarStart_VAA.Name = "textBoxVarStart_VAA";
            this.textBoxVarStart_VAA.Size = new System.Drawing.Size(142, 22);
            this.textBoxVarStart_VAA.TabIndex = 0;
            this.textBoxVarStart_VAA.TextChanged += new System.EventHandler(this.textBoxVarStart_VAA_TextChanged);
            // 
            // buttonHelp_VAA
            // 
            this.buttonHelp_VAA.Location = new System.Drawing.Point(320, 276);
            this.buttonHelp_VAA.Name = "buttonHelp_VAA";
            this.buttonHelp_VAA.Size = new System.Drawing.Size(81, 75);
            this.buttonHelp_VAA.TabIndex = 3;
            this.buttonHelp_VAA.Text = "Справка";
            this.buttonHelp_VAA.UseVisualStyleBackColor = true;
            this.buttonHelp_VAA.Click += new System.EventHandler(this.buttonHelp_VAA_Click);
            // 
            // buttonDone_VAA
            // 
            this.buttonDone_VAA.Location = new System.Drawing.Point(407, 276);
            this.buttonDone_VAA.Name = "buttonDone_VAA";
            this.buttonDone_VAA.Size = new System.Drawing.Size(129, 75);
            this.buttonDone_VAA.TabIndex = 4;
            this.buttonDone_VAA.Text = "Выполнить";
            this.buttonDone_VAA.UseVisualStyleBackColor = true;
            this.buttonDone_VAA.Click += new System.EventHandler(this.buttonDone_VAA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 354);
            this.Controls.Add(this.buttonDone_VAA);
            this.Controls.Add(this.buttonHelp_VAA);
            this.Controls.Add(this.groupBoxInput_VAA);
            this.Controls.Add(this.groupBoxRes_VAA);
            this.Controls.Add(this.groupBoxTask_VAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 1 | Вариант 24 | Варова А. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_VAA.ResumeLayout(false);
            this.groupBoxTask_VAA.PerformLayout();
            this.groupBoxRes_VAA.ResumeLayout(false);
            this.groupBoxRes_VAA.PerformLayout();
            this.groupBoxInput_VAA.ResumeLayout(false);
            this.groupBoxInput_VAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_VAA;
        private System.Windows.Forms.GroupBox groupBoxRes_VAA;
        private System.Windows.Forms.GroupBox groupBoxInput_VAA;
        private System.Windows.Forms.TextBox textBoxVarStop_VAA;
        private System.Windows.Forms.TextBox textBoxVarStart_VAA;
        private System.Windows.Forms.Button buttonHelp_VAA;
        private System.Windows.Forms.Button buttonDone_VAA;
        private System.Windows.Forms.TextBox textBoxRes_VAA;
        private System.Windows.Forms.TextBox textBoxTask_VAA;
        private System.Windows.Forms.Label labelInputVarStart_VAA;
        private System.Windows.Forms.Label labelRes_VAA;
        private System.Windows.Forms.Label labelVarStop_VAA;
    }
}

