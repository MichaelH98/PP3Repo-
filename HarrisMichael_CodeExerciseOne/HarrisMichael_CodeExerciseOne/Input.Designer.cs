namespace HarrisMichael_CodeExerciseOne
{
    partial class Input
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
            this.UIControls = new System.Windows.Forms.GroupBox();
            this.ClassNameTB = new System.Windows.Forms.TextBox();
            this.ClassLB = new System.Windows.Forms.Label();
            this.UIControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // UIControls
            // 
            this.UIControls.Controls.Add(this.ClassLB);
            this.UIControls.Controls.Add(this.ClassNameTB);
            this.UIControls.Location = new System.Drawing.Point(12, 12);
            this.UIControls.Name = "UIControls";
            this.UIControls.Size = new System.Drawing.Size(412, 164);
            this.UIControls.TabIndex = 0;
            this.UIControls.TabStop = false;
            this.UIControls.Text = "Controls";
            // 
            // ClassNameTB
            // 
            this.ClassNameTB.Location = new System.Drawing.Point(169, 71);
            this.ClassNameTB.Name = "ClassNameTB";
            this.ClassNameTB.Size = new System.Drawing.Size(217, 31);
            this.ClassNameTB.TabIndex = 1;
            // 
            // ClassLB
            // 
            this.ClassLB.AutoSize = true;
            this.ClassLB.Location = new System.Drawing.Point(29, 74);
            this.ClassLB.Name = "ClassLB";
            this.ClassLB.Size = new System.Drawing.Size(134, 25);
            this.ClassLB.TabIndex = 2;
            this.ClassLB.Text = "Class Name:";
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 183);
            this.Controls.Add(this.UIControls);
            this.Name = "Input";
            this.Text = "Input";
            this.UIControls.ResumeLayout(false);
            this.UIControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UIControls;
        private System.Windows.Forms.Label ClassLB;
        private System.Windows.Forms.TextBox ClassNameTB;
    }
}