namespace HarrisMichael_CodeExerciseOne
{
    partial class IPhone
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
            this.CoreClassesLB = new System.Windows.Forms.ListBox();
            this.SpecialClassesLB = new System.Windows.Forms.ListBox();
            this.CoreButton = new System.Windows.Forms.Button();
            this.SpecialButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CoreClassesLB
            // 
            this.CoreClassesLB.FormattingEnabled = true;
            this.CoreClassesLB.ItemHeight = 25;
            this.CoreClassesLB.Location = new System.Drawing.Point(65, 315);
            this.CoreClassesLB.Name = "CoreClassesLB";
            this.CoreClassesLB.Size = new System.Drawing.Size(183, 579);
            this.CoreClassesLB.TabIndex = 0;
            // 
            // SpecialClassesLB
            // 
            this.SpecialClassesLB.FormattingEnabled = true;
            this.SpecialClassesLB.ItemHeight = 25;
            this.SpecialClassesLB.Location = new System.Drawing.Point(416, 315);
            this.SpecialClassesLB.Name = "SpecialClassesLB";
            this.SpecialClassesLB.Size = new System.Drawing.Size(183, 579);
            this.SpecialClassesLB.TabIndex = 1;
            // 
            // CoreButton
            // 
            this.CoreButton.Location = new System.Drawing.Point(294, 315);
            this.CoreButton.Name = "CoreButton";
            this.CoreButton.Size = new System.Drawing.Size(75, 128);
            this.CoreButton.TabIndex = 2;
            this.CoreButton.Text = "Core";
            this.CoreButton.UseVisualStyleBackColor = true;
            // 
            // SpecialButton
            // 
            this.SpecialButton.Location = new System.Drawing.Point(294, 544);
            this.SpecialButton.Name = "SpecialButton";
            this.SpecialButton.Size = new System.Drawing.Size(75, 128);
            this.SpecialButton.TabIndex = 3;
            this.SpecialButton.Text = "SPC";
            this.SpecialButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(294, 766);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 128);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // IPhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::HarrisMichael_CodeExerciseOne.Properties.Resources.iPhone7Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 1280);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SpecialButton);
            this.Controls.Add(this.CoreButton);
            this.Controls.Add(this.SpecialClassesLB);
            this.Controls.Add(this.CoreClassesLB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "IPhone";
            this.Text = "IPhone";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CoreClassesLB;
        private System.Windows.Forms.ListBox SpecialClassesLB;
        private System.Windows.Forms.Button CoreButton;
        private System.Windows.Forms.Button SpecialButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}

