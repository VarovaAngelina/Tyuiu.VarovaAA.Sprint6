
namespace Tyuiu.VarovaAA.Sprint6.Task6.V27
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.buttonOK_VAA = new System.Windows.Forms.Button();
            this.pictureBox_VAA = new System.Windows.Forms.PictureBox();
            this.labelInfo_VAA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_VAA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK_VAA
            // 
            this.buttonOK_VAA.Location = new System.Drawing.Point(498, 233);
            this.buttonOK_VAA.Name = "buttonOK_VAA";
            this.buttonOK_VAA.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_VAA.TabIndex = 0;
            this.buttonOK_VAA.Text = "Ok";
            this.buttonOK_VAA.UseVisualStyleBackColor = true;
            this.buttonOK_VAA.Click += new System.EventHandler(this.buttonOK_VAA_Click);
            // 
            // pictureBox_VAA
            // 
            this.pictureBox_VAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_VAA.Image")));
            this.pictureBox_VAA.Location = new System.Drawing.Point(13, 13);
            this.pictureBox_VAA.Name = "pictureBox_VAA";
            this.pictureBox_VAA.Size = new System.Drawing.Size(181, 243);
            this.pictureBox_VAA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_VAA.TabIndex = 1;
            this.pictureBox_VAA.TabStop = false;
            // 
            // labelInfo_VAA
            // 
            this.labelInfo_VAA.AutoSize = true;
            this.labelInfo_VAA.Location = new System.Drawing.Point(201, 31);
            this.labelInfo_VAA.Name = "labelInfo_VAA";
            this.labelInfo_VAA.Size = new System.Drawing.Size(364, 153);
            this.labelInfo_VAA.TabIndex = 2;
            this.labelInfo_VAA.Text = resources.GetString("labelInfo_VAA.Text");
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 268);
            this.Controls.Add(this.labelInfo_VAA);
            this.Controls.Add(this.pictureBox_VAA);
            this.Controls.Add(this.buttonOK_VAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_VAA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK_VAA;
        private System.Windows.Forms.PictureBox pictureBox_VAA;
        private System.Windows.Forms.Label labelInfo_VAA;
    }
}