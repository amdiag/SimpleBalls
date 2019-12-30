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
            this.components = new System.ComponentModel.Container();
            this.buttonDrawCircle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MoveCircle = new System.Windows.Forms.Button();
            this.moveRandomCircle = new System.Windows.Forms.Button();
            this.timerBall = new System.Windows.Forms.Timer(this.components);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Draw random circle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MoveCircle
            // 
            this.MoveCircle.Location = new System.Drawing.Point(600, 193);
            this.MoveCircle.Name = "MoveCircle";
            this.MoveCircle.Size = new System.Drawing.Size(75, 23);
            this.MoveCircle.TabIndex = 2;
            this.MoveCircle.Text = "Move Circle";
            this.MoveCircle.UseVisualStyleBackColor = true;
            this.MoveCircle.Click += new System.EventHandler(this.MoveCircle_Click);
            // 
            // moveRandomCircle
            // 
            this.moveRandomCircle.Location = new System.Drawing.Point(136, 193);
            this.moveRandomCircle.Name = "moveRandomCircle";
            this.moveRandomCircle.Size = new System.Drawing.Size(105, 23);
            this.moveRandomCircle.TabIndex = 3;
            this.moveRandomCircle.Text = "Stop Random Circle";
            this.moveRandomCircle.UseVisualStyleBackColor = true;
            this.moveRandomCircle.Click += new System.EventHandler(this.MoveRandomBall_Click);
            // 
            // timerBall
            // 
            this.timerBall.Tick += new System.EventHandler(this.timerBall_Tick);
            // 
            // FormDemoClassSimpleBall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.moveRandomCircle);
            this.Controls.Add(this.MoveCircle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDrawCircle);
            this.Name = "FormDemoClassSimpleBall";
            this.Text = "Demo Simple Balls";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormDemoClassSimpleBall_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDrawCircle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button MoveCircle;
        private System.Windows.Forms.Button moveRandomCircle;
        private System.Windows.Forms.Timer timerBall;
    }
}

