namespace StupidBalls
{
    partial class FormSimpleBall
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
            this.StartButton = new System.Windows.Forms.Button();
            this.CatchButton = new System.Windows.Forms.Button();
            this.labelNumLostBall = new System.Windows.Forms.Label();
            this.labelLost = new System.Windows.Forms.Label();
            this.timerLostBalls = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(38, 47);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // CatchButton
            // 
            this.CatchButton.Location = new System.Drawing.Point(800, 46);
            this.CatchButton.Name = "CatchButton";
            this.CatchButton.Size = new System.Drawing.Size(75, 23);
            this.CatchButton.TabIndex = 1;
            this.CatchButton.Text = "Catch";
            this.CatchButton.UseVisualStyleBackColor = true;
            this.CatchButton.Click += new System.EventHandler(this.CatchButton_Click);
            // 
            // labelNumLostBall
            // 
            this.labelNumLostBall.AutoSize = true;
            this.labelNumLostBall.Location = new System.Drawing.Point(308, 51);
            this.labelNumLostBall.Name = "labelNumLostBall";
            this.labelNumLostBall.Size = new System.Drawing.Size(13, 13);
            this.labelNumLostBall.TabIndex = 3;
            this.labelNumLostBall.Text = "0";
            // 
            // labelLost
            // 
            this.labelLost.AutoSize = true;
            this.labelLost.Location = new System.Drawing.Point(190, 51);
            this.labelLost.Name = "labelLost";
            this.labelLost.Size = new System.Drawing.Size(72, 13);
            this.labelLost.TabIndex = 4;
            this.labelLost.Text = "Num lost balls";
            // 
            // timerLostBalls
            // 
            this.timerLostBalls.Interval = 10;
            this.timerLostBalls.Tick += new System.EventHandler(this.timerLostBalls_Tick);
            // 
            // FormSimpleBall
            // 
            this.ClientSize = new System.Drawing.Size(1086, 499);
            this.Controls.Add(this.labelLost);
            this.Controls.Add(this.labelNumLostBall);
            this.Controls.Add(this.CatchButton);
            this.Controls.Add(this.StartButton);
            this.Name = "FormSimpleBall";
            this.Text = "Form for game StupidBall";
            this.Load += new System.EventHandler(this.FormSimpleBall_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonCatch;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button CatchButton;
        private System.Windows.Forms.Label labelNumLostBall;
        private System.Windows.Forms.Label labelLost;
        private System.Windows.Forms.Timer timerLostBalls;
    }
}

