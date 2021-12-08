namespace Tivi
{
    partial class StopWatchForm
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
            this.secondsLabel = new System.Windows.Forms.Label();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.stopWatchTimer = new System.Windows.Forms.Timer(this.components);
            this.colonLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.millisecondsLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Font = new System.Drawing.Font("Candara", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.secondsLabel.Location = new System.Drawing.Point(404, 34);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(101, 78);
            this.secondsLabel.TabIndex = 0;
            this.secondsLabel.Text = "00";
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Font = new System.Drawing.Font("Candara", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.minutesLabel.Location = new System.Drawing.Point(246, 34);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(101, 78);
            this.minutesLabel.TabIndex = 1;
            this.minutesLabel.Text = "00";
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Font = new System.Drawing.Font("Candara", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hoursLabel.Location = new System.Drawing.Point(84, 34);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(101, 78);
            this.hoursLabel.TabIndex = 2;
            this.hoursLabel.Text = "00";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(119, 134);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(121, 49);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseButton.Location = new System.Drawing.Point(303, 134);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(121, 49);
            this.pauseButton.TabIndex = 4;
            this.pauseButton.Text = "PAUSE";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(487, 134);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(121, 49);
            this.stopButton.TabIndex = 5;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // stopWatchTimer
            // 
            this.stopWatchTimer.Interval = 1300;
            this.stopWatchTimer.Tick += new System.EventHandler(this.stopWatchTimer_Tick);
            // 
            // colonLabel
            // 
            this.colonLabel.AutoSize = true;
            this.colonLabel.Font = new System.Drawing.Font("Candara", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colonLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colonLabel.Location = new System.Drawing.Point(340, 34);
            this.colonLabel.Name = "colonLabel";
            this.colonLabel.Size = new System.Drawing.Size(49, 78);
            this.colonLabel.TabIndex = 6;
            this.colonLabel.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(191, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 78);
            this.label1.TabIndex = 7;
            this.label1.Text = ":";
            // 
            // millisecondsLabel
            // 
            this.millisecondsLabel.AutoSize = true;
            this.millisecondsLabel.Font = new System.Drawing.Font("Candara", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.millisecondsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.millisecondsLabel.Location = new System.Drawing.Point(573, 34);
            this.millisecondsLabel.Name = "millisecondsLabel";
            this.millisecondsLabel.Size = new System.Drawing.Size(101, 78);
            this.millisecondsLabel.TabIndex = 8;
            this.millisecondsLabel.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(526, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 78);
            this.label2.TabIndex = 9;
            this.label2.Text = ":";
            // 
            // StopWatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 232);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.millisecondsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colonLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.secondsLabel);
            this.Name = "StopWatchForm";
            this.Text = "StopWatchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Timer stopWatchTimer;
        private System.Windows.Forms.Label colonLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label millisecondsLabel;
        private System.Windows.Forms.Label label2;
    }
}