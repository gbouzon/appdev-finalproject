namespace Tivi
{
    partial class CountdownForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountdownForm));
            this.secondsComboBox = new System.Windows.Forms.ComboBox();
            this.minutesComboBox = new System.Windows.Forms.ComboBox();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.bigLabel = new System.Windows.Forms.Label();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.pomodoroPictureBox = new System.Windows.Forms.PictureBox();
            this.returnToMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pomodoroPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // secondsComboBox
            // 
            this.secondsComboBox.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsComboBox.FormattingEnabled = true;
            this.secondsComboBox.Location = new System.Drawing.Point(318, 76);
            this.secondsComboBox.Name = "secondsComboBox";
            this.secondsComboBox.Size = new System.Drawing.Size(122, 34);
            this.secondsComboBox.TabIndex = 0;
            // 
            // minutesComboBox
            // 
            this.minutesComboBox.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesComboBox.FormattingEnabled = true;
            this.minutesComboBox.Location = new System.Drawing.Point(120, 76);
            this.minutesComboBox.Name = "minutesComboBox";
            this.minutesComboBox.Size = new System.Drawing.Size(120, 34);
            this.minutesComboBox.TabIndex = 1;
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesLabel.Location = new System.Drawing.Point(113, 18);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(137, 39);
            this.minutesLabel.TabIndex = 2;
            this.minutesLabel.Text = "Minutes:";
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsLabel.Location = new System.Drawing.Point(311, 18);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(139, 39);
            this.secondsLabel.TabIndex = 3;
            this.secondsLabel.Text = "Seconds:";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(110, 234);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(130, 57);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(318, 234);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(130, 57);
            this.stopButton.TabIndex = 5;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // bigLabel
            // 
            this.bigLabel.Font = new System.Drawing.Font("Candara", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel.Location = new System.Drawing.Point(157, 127);
            this.bigLabel.Name = "bigLabel";
            this.bigLabel.Size = new System.Drawing.Size(248, 104);
            this.bigLabel.TabIndex = 6;
            this.bigLabel.Text = "00:00";
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // pomodoroPictureBox
            // 
            this.pomodoroPictureBox.Image = global::Tivi.Properties.Resources.pomodorotechnique;
            this.pomodoroPictureBox.Location = new System.Drawing.Point(27, 303);
            this.pomodoroPictureBox.Name = "pomodoroPictureBox";
            this.pomodoroPictureBox.Size = new System.Drawing.Size(500, 300);
            this.pomodoroPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pomodoroPictureBox.TabIndex = 7;
            this.pomodoroPictureBox.TabStop = false;
            // 
            // returnToMainMenu
            // 
            this.returnToMainMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.returnToMainMenu.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToMainMenu.Location = new System.Drawing.Point(158, 629);
            this.returnToMainMenu.Name = "returnToMainMenu";
            this.returnToMainMenu.Size = new System.Drawing.Size(206, 82);
            this.returnToMainMenu.TabIndex = 8;
            this.returnToMainMenu.Text = "Back To Main Menu";
            this.returnToMainMenu.UseVisualStyleBackColor = false;
            this.returnToMainMenu.Click += new System.EventHandler(this.returnToMainMenu_Click);
            // 
            // CountdownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 723);
            this.Controls.Add(this.returnToMainMenu);
            this.Controls.Add(this.pomodoroPictureBox);
            this.Controls.Add(this.bigLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.minutesComboBox);
            this.Controls.Add(this.secondsComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(568, 762);
            this.MinimumSize = new System.Drawing.Size(568, 762);
            this.Name = "CountdownForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Countdown";
            this.Load += new System.EventHandler(this.CountdownForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pomodoroPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox secondsComboBox;
        private System.Windows.Forms.ComboBox minutesComboBox;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label bigLabel;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.PictureBox pomodoroPictureBox;
        private System.Windows.Forms.Button returnToMainMenu;
    }
}