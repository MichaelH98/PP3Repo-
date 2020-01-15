namespace HarrisMichael_CodeExercise2
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.backgroundRed = new System.Windows.Forms.PictureBox();
            this.ControlsGB = new System.Windows.Forms.GroupBox();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.yearUD = new System.Windows.Forms.NumericUpDown();
            this.MovieLB = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.genreLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.yReleasedLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.genreTB = new System.Windows.Forms.TextBox();
            this.authorTB = new System.Windows.Forms.TextBox();
            this.pubTB = new System.Windows.Forms.TextBox();
            this.titleTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundRed)).BeginInit();
            this.ControlsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearUD)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundRed
            // 
            this.backgroundRed.BackColor = System.Drawing.Color.Maroon;
            this.backgroundRed.Location = new System.Drawing.Point(48, 168);
            this.backgroundRed.Name = "backgroundRed";
            this.backgroundRed.Size = new System.Drawing.Size(576, 973);
            this.backgroundRed.TabIndex = 0;
            this.backgroundRed.TabStop = false;
            // 
            // ControlsGB
            // 
            this.ControlsGB.BackColor = System.Drawing.Color.Maroon;
            this.ControlsGB.Controls.Add(this.ForwardButton);
            this.ControlsGB.Controls.Add(this.BackButton);
            this.ControlsGB.Controls.Add(this.deleteButton);
            this.ControlsGB.Controls.Add(this.saveButton);
            this.ControlsGB.Controls.Add(this.yearUD);
            this.ControlsGB.Controls.Add(this.MovieLB);
            this.ControlsGB.Controls.Add(this.genreLabel);
            this.ControlsGB.Controls.Add(this.authorLabel);
            this.ControlsGB.Controls.Add(this.publisherLabel);
            this.ControlsGB.Controls.Add(this.yReleasedLabel);
            this.ControlsGB.Controls.Add(this.titleLabel);
            this.ControlsGB.Controls.Add(this.genreTB);
            this.ControlsGB.Controls.Add(this.authorTB);
            this.ControlsGB.Controls.Add(this.pubTB);
            this.ControlsGB.Controls.Add(this.titleTB);
            this.ControlsGB.Location = new System.Drawing.Point(56, 176);
            this.ControlsGB.Name = "ControlsGB";
            this.ControlsGB.Size = new System.Drawing.Size(554, 950);
            this.ControlsGB.TabIndex = 1;
            this.ControlsGB.TabStop = false;
            this.ControlsGB.Text = "Controls";
            // 
            // ForwardButton
            // 
            this.ForwardButton.Location = new System.Drawing.Point(490, 299);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(35, 39);
            this.ForwardButton.TabIndex = 15;
            this.ForwardButton.Text = ">";
            this.ForwardButton.UseVisualStyleBackColor = true;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(29, 299);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(35, 39);
            this.BackButton.TabIndex = 14;
            this.BackButton.Text = "<";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(288, 344);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(237, 42);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(29, 344);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(253, 42);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // yearUD
            // 
            this.yearUD.Location = new System.Drawing.Point(191, 118);
            this.yearUD.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.yearUD.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.yearUD.Name = "yearUD";
            this.yearUD.Size = new System.Drawing.Size(261, 31);
            this.yearUD.TabIndex = 11;
            this.yearUD.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // MovieLB
            // 
            this.MovieLB.HideSelection = false;
            this.MovieLB.LargeImageList = this.imageList1;
            this.MovieLB.Location = new System.Drawing.Point(29, 409);
            this.MovieLB.Name = "MovieLB";
            this.MovieLB.Size = new System.Drawing.Size(496, 518);
            this.MovieLB.SmallImageList = this.imageList1;
            this.MovieLB.TabIndex = 10;
            this.MovieLB.UseCompatibleStateImageBehavior = false;
            this.MovieLB.DoubleClick += new System.EventHandler(this.MovieLB_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "google.png");
            this.imageList1.Images.SetKeyName(1, "netflix.png");
            this.imageList1.Images.SetKeyName(2, "apple.png");
            this.imageList1.Images.SetKeyName(3, "amazon.png");
            this.imageList1.Images.SetKeyName(4, "facebook.png");
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(104, 294);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(77, 25);
            this.genreLabel.TabIndex = 9;
            this.genreLabel.Text = "Genre:";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(104, 234);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(81, 25);
            this.authorLabel.TabIndex = 8;
            this.authorLabel.Text = "Author:";
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(77, 175);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(108, 25);
            this.publisherLabel.TabIndex = 7;
            this.publisherLabel.Text = "Publisher:";
            // 
            // yReleasedLabel
            // 
            this.yReleasedLabel.AutoSize = true;
            this.yReleasedLabel.Location = new System.Drawing.Point(24, 120);
            this.yReleasedLabel.Name = "yReleasedLabel";
            this.yReleasedLabel.Size = new System.Drawing.Size(161, 25);
            this.yReleasedLabel.TabIndex = 6;
            this.yReleasedLabel.Text = "Year Released:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(62, 58);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(123, 25);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Movie Title:";
            // 
            // genreTB
            // 
            this.genreTB.Location = new System.Drawing.Point(191, 291);
            this.genreTB.Name = "genreTB";
            this.genreTB.Size = new System.Drawing.Size(261, 31);
            this.genreTB.TabIndex = 4;
            // 
            // authorTB
            // 
            this.authorTB.Location = new System.Drawing.Point(191, 231);
            this.authorTB.Name = "authorTB";
            this.authorTB.Size = new System.Drawing.Size(261, 31);
            this.authorTB.TabIndex = 3;
            // 
            // pubTB
            // 
            this.pubTB.Location = new System.Drawing.Point(191, 172);
            this.pubTB.Name = "pubTB";
            this.pubTB.Size = new System.Drawing.Size(261, 31);
            this.pubTB.TabIndex = 2;
            // 
            // titleTB
            // 
            this.titleTB.Location = new System.Drawing.Point(191, 55);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(261, 31);
            this.titleTB.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::HarrisMichael_CodeExercise2.Properties.Resources.iPhone7Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 1280);
            this.Controls.Add(this.ControlsGB);
            this.Controls.Add(this.backgroundRed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.backgroundRed)).EndInit();
            this.ControlsGB.ResumeLayout(false);
            this.ControlsGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox backgroundRed;
        private System.Windows.Forms.GroupBox ControlsGB;
        private System.Windows.Forms.TextBox authorTB;
        private System.Windows.Forms.TextBox pubTB;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label yReleasedLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox genreTB;
        private System.Windows.Forms.ListView MovieLB;
        private System.Windows.Forms.NumericUpDown yearUD;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button BackButton;
    }
}

