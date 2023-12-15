
namespace Tyuiu.VarovaAA.Sprint6.TaskReview.V25
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
            this.labelInfo_VAA = new System.Windows.Forms.Label();
            this.buttonOK_VAA = new System.Windows.Forms.Button();
            this.pictureBoxAftor_VAA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAftor_VAA)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo_VAA
            // 
            this.labelInfo_VAA.AutoSize = true;
            this.labelInfo_VAA.Location = new System.Drawing.Point(191, 48);
            this.labelInfo_VAA.Name = "labelInfo_VAA";
            this.labelInfo_VAA.Size = new System.Drawing.Size(384, 153);
            this.labelInfo_VAA.TabIndex = 0;
            this.labelInfo_VAA.Text = resources.GetString("labelInfo_VAA.Text");
            // 
            // buttonOK_VAA
            // 
            this.buttonOK_VAA.Location = new System.Drawing.Point(499, 244);
            this.buttonOK_VAA.Name = "buttonOK_VAA";
            this.buttonOK_VAA.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_VAA.TabIndex = 1;
            this.buttonOK_VAA.Text = "OK";
            this.buttonOK_VAA.UseVisualStyleBackColor = true;
            this.buttonOK_VAA.Click += new System.EventHandler(this.buttonOK_VAA_Click);
            // 
            // pictureBoxAftor_VAA
            // 
            this.pictureBoxAftor_VAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAftor_VAA.Image")));
            this.pictureBoxAftor_VAA.Location = new System.Drawing.Point(13, 24);
            this.pictureBoxAftor_VAA.Name = "pictureBoxAftor_VAA";
            this.pictureBoxAftor_VAA.Size = new System.Drawing.Size(172, 222);
            this.pictureBoxAftor_VAA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAftor_VAA.TabIndex = 2;
            this.pictureBoxAftor_VAA.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 279);
            this.Controls.Add(this.pictureBoxAftor_VAA);
            this.Controls.Add(this.buttonOK_VAA);
            this.Controls.Add(this.labelInfo_VAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(605, 326);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAftor_VAA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo_VAA;
        private System.Windows.Forms.Button buttonOK_VAA;
        private System.Windows.Forms.PictureBox pictureBoxAftor_VAA;
    }
}