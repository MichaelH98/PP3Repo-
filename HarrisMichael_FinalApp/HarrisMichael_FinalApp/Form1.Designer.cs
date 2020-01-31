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
            this.SaveDBButton = new System.Windows.Forms.Button();
            this.DirectorLB = new System.Windows.Forms.Label();
            this.DirectorTB = new System.Windows.Forms.TextBox();
            this.GenreTB = new System.Windows.Forms.TextBox();
            this.GenreLB = new System.Windows.Forms.Label();
            this.RatedLB = new System.Windows.Forms.Label();
            this.RatedTB = new System.Windows.Forms.TextBox();
            this.YearTB = new System.Windows.Forms.TextBox();
            this.YearLB = new System.Windows.Forms.Label();
            this.TitleLB = new System.Windows.Forms.Label();
            this.TitleTB = new System.Windows.Forms.TextBox();
            this.grabButton = new System.Windows.Forms.Button();
            this.urlTB = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AppBackGroundColor)).BeginInit();
            this.MoiveGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppBackGroundColor
            // 
            this.AppBackGroundColor.BackColor = System.Drawing.Color.Maroon;
            this.AppBackGroundColor.Location = new System.Drawing.Point(48, 167);
            this.AppBackGroundColor.Name = "AppBackGroundColor";
            this.AppBackGroundColor.Size = new System.Drawing.Size(575, 982);
            this.AppBackGroundColor.TabIndex = 0;
            this.AppBackGroundColor.TabStop = false;
            // 
            // MoiveGB
            // 
            this.MoiveGB.BackColor = System.Drawing.Color.Maroon;
            this.MoiveGB.Controls.Add(this.clearButton);
            this.MoiveGB.Controls.Add(this.SaveDBButton);
            this.MoiveGB.Controls.Add(this.DirectorLB);
            this.MoiveGB.Controls.Add(this.DirectorTB);
            this.MoiveGB.Controls.Add(this.GenreTB);
            this.MoiveGB.Controls.Add(this.GenreLB);
            this.MoiveGB.Controls.Add(this.RatedLB);
            this.MoiveGB.Controls.Add(this.RatedTB);
            this.MoiveGB.Controls.Add(this.YearTB);
            this.MoiveGB.Controls.Add(this.YearLB);
            this.MoiveGB.Controls.Add(this.TitleLB);
            this.MoiveGB.Controls.Add(this.TitleTB);
            this.MoiveGB.Controls.Add(this.grabButton);
            this.MoiveGB.Controls.Add(this.urlTB);
            this.MoiveGB.ForeColor = System.Drawing.Color.Goldenrod;
            this.MoiveGB.Location = new System.Drawing.Point(48, 225);
            this.MoiveGB.Name = "MoiveGB";
            this.MoiveGB.Size = new System.Drawing.Size(575, 924);
            this.MoiveGB.TabIndex = 1;
            this.MoiveGB.TabStop = false;
            this.MoiveGB.Text = "Film Nation";
            // 
            // SaveDBButton
            // 
            this.SaveDBButton.Image = global::HarrisMichael_FinalApp.Properties.Resources.download;
            this.SaveDBButton.Location = new System.Drawing.Point(137, 453);
            this.SaveDBButton.Name = "SaveDBButton";
            this.SaveDBButton.Size = new System.Drawing.Size(329, 92);
            this.SaveDBButton.TabIndex = 12;
            this.SaveDBButton.UseVisualStyleBackColor = true;
            this.SaveDBButton.Click += new System.EventHandler(this.SaveDBButton_Click);
            // 
            // DirectorLB
            // 
            this.DirectorLB.AutoSize = true;
            this.DirectorLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DirectorLB.Location = new System.Drawing.Point(13, 348);
            this.DirectorLB.Name = "DirectorLB";
            this.DirectorLB.Size = new System.Drawing.Size(93, 25);
            this.DirectorLB.TabIndex = 11;
            this.DirectorLB.Text = "Director:";
            // 
            // DirectorTB
            // 
            this.DirectorTB.BackColor = System.Drawing.Color.Goldenrod;
            this.DirectorTB.Location = new System.Drawing.Point(110, 345);
            this.DirectorTB.Name = "DirectorTB";
            this.DirectorTB.Size = new System.Drawing.Size(441, 31);
            this.DirectorTB.TabIndex = 10;
            // 
            // GenreTB
            // 
            this.GenreTB.BackColor = System.Drawing.Color.Goldenrod;
            this.GenreTB.Location = new System.Drawing.Point(110, 277);
            this.GenreTB.Name = "GenreTB";
            this.GenreTB.Size = new System.Drawing.Size(269, 31);
            this.GenreTB.TabIndex = 9;
            // 
            // GenreLB
            // 
            this.GenreLB.AutoSize = true;
            this.GenreLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.GenreLB.Location = new System.Drawing.Point(29, 280);
            this.GenreLB.Name = "GenreLB";
            this.GenreLB.Size = new System.Drawing.Size(77, 25);
            this.GenreLB.TabIndex = 8;
            this.GenreLB.Text = "Genre:";
            // 
            // RatedLB
            // 
            this.RatedLB.AutoSize = true;
            this.RatedLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RatedLB.Location = new System.Drawing.Point(29, 214);
            this.RatedLB.Name = "RatedLB";
            this.RatedLB.Size = new System.Drawing.Size(75, 25);
            this.RatedLB.TabIndex = 7;
            this.RatedLB.Text = "Rated:";
            // 
            // RatedTB
            // 
            this.RatedTB.BackColor = System.Drawing.Color.Goldenrod;
            this.RatedTB.Location = new System.Drawing.Point(110, 211);
            this.RatedTB.Name = "RatedTB";
            this.RatedTB.Size = new System.Drawing.Size(180, 31);
            this.RatedTB.TabIndex = 6;
            // 
            // YearTB
            // 
            this.YearTB.BackColor = System.Drawing.Color.Goldenrod;
            this.YearTB.Location = new System.Drawing.Point(110, 153);
            this.YearTB.Name = "YearTB";
            this.YearTB.Size = new System.Drawing.Size(135, 31);
            this.YearTB.TabIndex = 5;
            // 
            // YearLB
            // 
            this.YearLB.AutoSize = true;
            this.YearLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.YearLB.Location = new System.Drawing.Point(40, 156);
            this.YearLB.Name = "YearLB";
            this.YearLB.Size = new System.Drawing.Size(64, 25);
            this.YearLB.TabIndex = 4;
            this.YearLB.Text = "Year:";
            // 
            // TitleLB
            // 
            this.TitleLB.AutoSize = true;
            this.TitleLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TitleLB.Location = new System.Drawing.Point(45, 97);
            this.TitleLB.Name = "TitleLB";
            this.TitleLB.Size = new System.Drawing.Size(59, 25);
            this.TitleLB.TabIndex = 3;
            this.TitleLB.Text = "Title:";
            // 
            // TitleTB
            // 
            this.TitleTB.BackColor = System.Drawing.Color.Goldenrod;
            this.TitleTB.Location = new System.Drawing.Point(110, 94);
            this.TitleTB.Name = "TitleTB";
            this.TitleTB.Size = new System.Drawing.Size(441, 31);
            this.TitleTB.TabIndex = 2;
            // 
            // grabButton
            // 
            this.grabButton.BackColor = System.Drawing.Color.Goldenrod;
            this.grabButton.ForeColor = System.Drawing.Color.Maroon;
            this.grabButton.Location = new System.Drawing.Point(137, 561);
            this.grabButton.Name = "grabButton";
            this.grabButton.Size = new System.Drawing.Size(329, 91);
            this.grabButton.TabIndex = 1;
            this.grabButton.Text = "Search";
            this.grabButton.UseVisualStyleBackColor = false;
            this.grabButton.Click += new System.EventHandler(this.grabButton_Click);
            // 
            // urlTB
            // 
            this.urlTB.BackColor = System.Drawing.Color.Goldenrod;
            this.urlTB.Location = new System.Drawing.Point(6, 717);
            this.urlTB.Name = "urlTB";
            this.urlTB.Size = new System.Drawing.Size(563, 31);
            this.urlTB.TabIndex = 0;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Maroon;
            this.clearButton.Location = new System.Drawing.Point(53, 498);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(78, 92);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
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
            this.MoiveGB.ResumeLayout(false);
            this.MoiveGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox AppBackGroundColor;
        private System.Windows.Forms.GroupBox MoiveGB;
        private System.Windows.Forms.Button grabButton;
        private System.Windows.Forms.TextBox urlTB;
        private System.Windows.Forms.Label TitleLB;
        private System.Windows.Forms.TextBox TitleTB;
        private System.Windows.Forms.Label YearLB;
        private System.Windows.Forms.TextBox YearTB;
        private System.Windows.Forms.Label RatedLB;
        private System.Windows.Forms.TextBox RatedTB;
        private System.Windows.Forms.TextBox GenreTB;
        private System.Windows.Forms.Label GenreLB;
        private System.Windows.Forms.Label DirectorLB;
        private System.Windows.Forms.TextBox DirectorTB;
        private System.Windows.Forms.Button SaveDBButton;
        private System.Windows.Forms.Button clearButton;
    }
}

