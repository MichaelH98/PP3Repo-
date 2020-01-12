namespace HarrisMichael_FinalApp
{
    partial class Form1
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
            this.AppBackGroundColor = new System.Windows.Forms.PictureBox();
            this.MoiveGB = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.AppBackGroundColor)).BeginInit();
            this.SuspendLayout();
            // 
            // AppBackGroundColor
            // 
            this.AppBackGroundColor.Location = new System.Drawing.Point(48, 167);
            this.AppBackGroundColor.Name = "AppBackGroundColor";
            this.AppBackGroundColor.Size = new System.Drawing.Size(575, 982);
            this.AppBackGroundColor.TabIndex = 0;
            this.AppBackGroundColor.TabStop = false;
            // 
            // MoiveGB
            // 
            this.MoiveGB.Location = new System.Drawing.Point(48, 245);
            this.MoiveGB.Name = "MoiveGB";
            this.MoiveGB.Size = new System.Drawing.Size(575, 904);
            this.MoiveGB.TabIndex = 1;
            this.MoiveGB.TabStop = false;
            this.MoiveGB.Text = "Moives";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::HarrisMichael_FinalApp.Properties.Resources.iPhone7Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 1280);
            this.Controls.Add(this.MoiveGB);
            this.Controls.Add(this.AppBackGroundColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AppBackGroundColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox AppBackGroundColor;
        private System.Windows.Forms.GroupBox MoiveGB;
    }
}

