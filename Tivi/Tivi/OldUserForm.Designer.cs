namespace Tivi
{
    partial class OldUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OldUserForm));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.calendarButton = new System.Windows.Forms.Button();
            this.toDoListButton = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.timerButton = new System.Windows.Forms.Button();
            this.stopWatchButton = new System.Windows.Forms.Button();
            this.budgetingButton = new System.Windows.Forms.Button();
            this.noteButton = new System.Windows.Forms.Button();
            this.returnToMainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(16, 32);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(259, 43);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome back";
            // 
            // calendarButton
            // 
            this.calendarButton.BackColor = System.Drawing.SystemColors.Control;
            this.calendarButton.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarButton.Location = new System.Drawing.Point(80, 110);
            this.calendarButton.Margin = new System.Windows.Forms.Padding(2);
            this.calendarButton.Name = "calendarButton";
            this.calendarButton.Size = new System.Drawing.Size(213, 89);
            this.calendarButton.TabIndex = 1;
            this.calendarButton.Text = "Calendar";
            this.calendarButton.UseVisualStyleBackColor = false;
            this.calendarButton.Click += new System.EventHandler(this.calendarButton_Click);
            // 
            // toDoListButton
            // 
            this.toDoListButton.BackColor = System.Drawing.SystemColors.Control;
            this.toDoListButton.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDoListButton.Location = new System.Drawing.Point(80, 232);
            this.toDoListButton.Margin = new System.Windows.Forms.Padding(2);
            this.toDoListButton.Name = "toDoListButton";
            this.toDoListButton.Size = new System.Drawing.Size(213, 90);
            this.toDoListButton.TabIndex = 2;
            this.toDoListButton.Text = "To Do List";
            this.toDoListButton.UseVisualStyleBackColor = false;
            this.toDoListButton.Click += new System.EventHandler(this.toDoListButton_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Consolas", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(280, 32);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(0, 42);
            this.userLabel.TabIndex = 4;
            // 
            // timerButton
            // 
            this.timerButton.BackColor = System.Drawing.SystemColors.Control;
            this.timerButton.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerButton.Location = new System.Drawing.Point(376, 236);
            this.timerButton.Margin = new System.Windows.Forms.Padding(2);
            this.timerButton.Name = "timerButton";
            this.timerButton.Size = new System.Drawing.Size(211, 86);
            this.timerButton.TabIndex = 5;
            this.timerButton.Text = "Countdown Timer";
            this.timerButton.UseVisualStyleBackColor = false;
            this.timerButton.Click += new System.EventHandler(this.timerButton_Click);
            // 
            // stopWatchButton
            // 
            this.stopWatchButton.BackColor = System.Drawing.SystemColors.Control;
            this.stopWatchButton.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopWatchButton.Location = new System.Drawing.Point(80, 354);
            this.stopWatchButton.Margin = new System.Windows.Forms.Padding(2);
            this.stopWatchButton.Name = "stopWatchButton";
            this.stopWatchButton.Size = new System.Drawing.Size(213, 86);
            this.stopWatchButton.TabIndex = 6;
            this.stopWatchButton.Text = "StopWatch";
            this.stopWatchButton.UseVisualStyleBackColor = false;
            this.stopWatchButton.Click += new System.EventHandler(this.stopWatchButton_Click);
            // 
            // budgetingButton
            // 
            this.budgetingButton.BackColor = System.Drawing.SystemColors.Control;
            this.budgetingButton.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetingButton.Location = new System.Drawing.Point(376, 113);
            this.budgetingButton.Margin = new System.Windows.Forms.Padding(2);
            this.budgetingButton.Name = "budgetingButton";
            this.budgetingButton.Size = new System.Drawing.Size(211, 86);
            this.budgetingButton.TabIndex = 7;
            this.budgetingButton.Text = "Finance";
            this.budgetingButton.UseVisualStyleBackColor = false;
            this.budgetingButton.Click += new System.EventHandler(this.budgetingButton_Click);
            // 
            // noteButton
            // 
            this.noteButton.BackColor = System.Drawing.SystemColors.Control;
            this.noteButton.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteButton.Location = new System.Drawing.Point(374, 353);
            this.noteButton.Margin = new System.Windows.Forms.Padding(2);
            this.noteButton.Name = "noteButton";
            this.noteButton.Size = new System.Drawing.Size(213, 89);
            this.noteButton.TabIndex = 9;
            this.noteButton.Text = "Notes";
            this.noteButton.UseVisualStyleBackColor = false;
            this.noteButton.Click += new System.EventHandler(this.noteButton_Click);
            // 
            // returnToMainMenuButton
            // 
            this.returnToMainMenuButton.BackColor = System.Drawing.SystemColors.Control;
            this.returnToMainMenuButton.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToMainMenuButton.Location = new System.Drawing.Point(216, 478);
            this.returnToMainMenuButton.Margin = new System.Windows.Forms.Padding(2);
            this.returnToMainMenuButton.Name = "returnToMainMenuButton";
            this.returnToMainMenuButton.Size = new System.Drawing.Size(213, 89);
            this.returnToMainMenuButton.TabIndex = 10;
            this.returnToMainMenuButton.Text = "Back";
            this.returnToMainMenuButton.UseVisualStyleBackColor = false;
            this.returnToMainMenuButton.Click += new System.EventHandler(this.returnToMainMenuButton_Click);
            // 
            // OldUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 587);
            this.Controls.Add(this.returnToMainMenuButton);
            this.Controls.Add(this.noteButton);
            this.Controls.Add(this.budgetingButton);
            this.Controls.Add(this.stopWatchButton);
            this.Controls.Add(this.timerButton);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.toDoListButton);
            this.Controls.Add(this.calendarButton);
            this.Controls.Add(this.welcomeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(673, 626);
            this.MinimumSize = new System.Drawing.Size(673, 626);
            this.Name = "OldUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome Back!";
            this.Load += new System.EventHandler(this.OldUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button calendarButton;
        private System.Windows.Forms.Button toDoListButton;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button timerButton;
        private System.Windows.Forms.Button stopWatchButton;
        private System.Windows.Forms.Button budgetingButton;
        private System.Windows.Forms.Button noteButton;
        private System.Windows.Forms.Button returnToMainMenuButton;
    }
}