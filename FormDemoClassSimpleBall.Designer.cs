using System;
using System.Drawing;

namespace SimpleBalls
{
    partial class FormDemoClassSimpleBall
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
            this.buttonDrawCircle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDrawCircle
            // 
            this.buttonDrawCircle.Location = new System.Drawing.Point(600, 92);
            this.buttonDrawCircle.Name = "buttonDrawCircle";
            this.buttonDrawCircle.Size = new System.Drawing.Size(75, 23);
            this.buttonDrawCircle.TabIndex = 0;
            this.buttonDrawCircle.Text = "Draw Circle";
            this.buttonDrawCircle.UseVisualStyleBackColor = true;
            this.buttonDrawCircle.Click += new System.EventHandler(this.buttonDrawCircle_Click);
            // 
            // FormDemoClassSimpleBall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.buttonDrawCircle);
            this.Name = "FormDemoClassSimpleBall";
            this.Text = "Demo Simple Balls";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDrawCircle;
    }
}

