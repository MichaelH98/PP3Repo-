﻿namespace HarrisMichael_CodeExerciseOne
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.CoreButton.Click += new System.EventHandler(this.CoreButton_Click);
            // 
            // SpecialButton
            // 
            this.SpecialButton.Location = new System.Drawing.Point(294, 544);
            this.SpecialButton.Name = "SpecialButton";
            this.SpecialButton.Size = new System.Drawing.Size(75, 128);
            this.SpecialButton.TabIndex = 3;
            this.SpecialButton.Text = "SPC";
            this.SpecialButton.UseVisualStyleBackColor = true;
            this.SpecialButton.Click += new System.EventHandler(this.SpecialButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(294, 766);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 128);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.newToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(661, 42);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadListToolStripMenuItem,
            this.saveListToolStripMenuItem,
            this.printListToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(83, 38);
            this.newToolStripMenuItem.Text = "New";
            // 
            // classToolStripMenuItem
            // 
            this.classToolStripMenuItem.Name = "classToolStripMenuItem";
            this.classToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.classToolStripMenuItem.Text = "Class";
            this.classToolStripMenuItem.Click += new System.EventHandler(this.classToolStripMenuItem_Click);
            // 
            // loadListToolStripMenuItem
            // 
            this.loadListToolStripMenuItem.Name = "loadListToolStripMenuItem";
            this.loadListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadListToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.loadListToolStripMenuItem.Text = "Load List";
            this.loadListToolStripMenuItem.Click += new System.EventHandler(this.loadListToolStripMenuItem_Click);
            // 
            // saveListToolStripMenuItem
            // 
            this.saveListToolStripMenuItem.Name = "saveListToolStripMenuItem";
            this.saveListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveListToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.saveListToolStripMenuItem.Text = "Save List";
            this.saveListToolStripMenuItem.Click += new System.EventHandler(this.saveListToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // printListToolStripMenuItem
            // 
            this.printListToolStripMenuItem.Name = "printListToolStripMenuItem";
            this.printListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printListToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.printListToolStripMenuItem.Text = "Print List";
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
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "IPhone";
            this.Text = "IPhone";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CoreClassesLB;
        private System.Windows.Forms.ListBox SpecialClassesLB;
        private System.Windows.Forms.Button CoreButton;
        private System.Windows.Forms.Button SpecialButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printListToolStripMenuItem;
    }
}

