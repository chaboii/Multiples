﻿namespace multiples_finder
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.equasionBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(295, 242);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(191, 58);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(295, 111);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(190, 20);
            this.numberBox.TabIndex = 1;
            // 
            // equasionBox
            // 
            this.equasionBox.Enabled = false;
            this.equasionBox.Location = new System.Drawing.Point(295, 154);
            this.equasionBox.Name = "equasionBox";
            this.equasionBox.Size = new System.Drawing.Size(190, 20);
            this.equasionBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.equasionBox);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = "Multiple Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.TextBox equasionBox;
    }
}
