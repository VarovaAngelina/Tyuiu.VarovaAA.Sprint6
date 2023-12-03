
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
            this.groupBoxTask_VAA = new System.Windows.Forms.GroupBox();
            this.groupBoxInput_VAA = new System.Windows.Forms.GroupBox();
            this.groupBoxOutput_VAA = new System.Windows.Forms.GroupBox();
            this.buttonSpravka_VAA = new System.Windows.Forms.Button();
            this.buttonDone_VAA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBoxTask_VAA
            // 
            this.groupBoxTask_VAA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_VAA.Name = "groupBoxTask_VAA";
            this.groupBoxTask_VAA.Size = new System.Drawing.Size(547, 246);
            this.groupBoxTask_VAA.TabIndex = 0;
            this.groupBoxTask_VAA.TabStop = false;
            this.groupBoxTask_VAA.Text = "Условие";
            // 
            // groupBoxInput_VAA
            // 
            this.groupBoxInput_VAA.Location = new System.Drawing.Point(13, 266);
            this.groupBoxInput_VAA.Name = "groupBoxInput_VAA";
            this.groupBoxInput_VAA.Size = new System.Drawing.Size(326, 74);
            this.groupBoxInput_VAA.TabIndex = 1;
            this.groupBoxInput_VAA.TabStop = false;
            this.groupBoxInput_VAA.Text = "Ввод данных";
            // 
            // groupBoxOutput_VAA
            // 
            this.groupBoxOutput_VAA.Location = new System.Drawing.Point(567, 13);
            this.groupBoxOutput_VAA.Name = "groupBoxOutput_VAA";
            this.groupBoxOutput_VAA.Size = new System.Drawing.Size(468, 327);
            this.groupBoxOutput_VAA.TabIndex = 2;
            this.groupBoxOutput_VAA.TabStop = false;
            this.groupBoxOutput_VAA.Text = "Вывод данных";
            // 
            // buttonSpravka_VAA
            // 
            this.buttonSpravka_VAA.Location = new System.Drawing.Point(347, 266);
            this.buttonSpravka_VAA.Name = "buttonSpravka_VAA";
            this.buttonSpravka_VAA.Size = new System.Drawing.Size(79, 74);
            this.buttonSpravka_VAA.TabIndex = 3;
            this.buttonSpravka_VAA.Text = "Справка";
            this.buttonSpravka_VAA.UseVisualStyleBackColor = true;
            // 
            // buttonDone_VAA
            // 
            this.buttonDone_VAA.Location = new System.Drawing.Point(431, 266);
            this.buttonDone_VAA.Name = "buttonDone_VAA";
            this.buttonDone_VAA.Size = new System.Drawing.Size(129, 74);
            this.buttonDone_VAA.TabIndex = 4;
            this.buttonDone_VAA.Text = "Выполнить";
            this.buttonDone_VAA.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 352);
            this.Controls.Add(this.buttonDone_VAA);
            this.Controls.Add(this.buttonSpravka_VAA);
            this.Controls.Add(this.groupBoxOutput_VAA);
            this.Controls.Add(this.groupBoxInput_VAA);
            this.Controls.Add(this.groupBoxTask_VAA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 2 | Вариант 19 |  Варова А. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_VAA;
        private System.Windows.Forms.GroupBox groupBoxInput_VAA;
        private System.Windows.Forms.GroupBox groupBoxOutput_VAA;
        private System.Windows.Forms.Button buttonSpravka_VAA;
        private System.Windows.Forms.Button buttonDone_VAA;
    }
}

