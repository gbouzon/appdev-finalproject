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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.calendarButton = new System.Windows.Forms.Button();
            this.toDoListButton = new System.Windows.Forms.Button();
            this.schedulerButton = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.timerButton = new System.Windows.Forms.Button();
            this.stopWatchButton = new System.Windows.Forms.Button();
            this.budgetingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(16, 17);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(259, 43);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome back";
            // 
            // calendarButton
            // 
            this.calendarButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.calendarButton.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarButton.Location = new System.Drawing.Point(24, 85);
            this.calendarButton.Margin = new System.Windows.Forms.Padding(2);
            this.calendarButton.Name = "calendarButton";
            this.calendarButton.Size = new System.Drawing.Size(200, 89);
            this.calendarButton.TabIndex = 1;
            this.calendarButton.Text = "Calendar";
            this.calendarButton.UseVisualStyleBackColor = false;
            this.calendarButton.Click += new System.EventHandler(this.calendarButton_Click);
            // 
            // toDoListButton
            // 
            this.toDoListButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toDoListButton.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDoListButton.Location = new System.Drawing.Point(24, 193);
            this.toDoListButton.Margin = new System.Windows.Forms.Padding(2);
            this.toDoListButton.Name = "toDoListButton";
            this.toDoListButton.Size = new System.Drawing.Size(200, 90);
            this.toDoListButton.TabIndex = 2;
            this.toDoListButton.Text = "To Do List";
            this.toDoListButton.UseVisualStyleBackColor = false;
            this.toDoListButton.Click += new System.EventHandler(this.toDoListButton_Click);
            // 
            // schedulerButton
            // 
            this.schedulerButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.schedulerButton.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedulerButton.Location = new System.Drawing.Point(267, 85);
            this.schedulerButton.Margin = new System.Windows.Forms.Padding(2);
            this.schedulerButton.Name = "schedulerButton";
            this.schedulerButton.Size = new System.Drawing.Size(200, 89);
            this.schedulerButton.TabIndex = 3;
            this.schedulerButton.Text = "Scheduler";
            this.schedulerButton.UseVisualStyleBackColor = false;
            this.schedulerButton.Click += new System.EventHandler(this.schedulerButton_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Consolas", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(280, 18);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(0, 42);
            this.userLabel.TabIndex = 4;
            // 
            // timerButton
            // 
            this.timerButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.timerButton.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerButton.Location = new System.Drawing.Point(267, 197);
            this.timerButton.Margin = new System.Windows.Forms.Padding(2);
            this.timerButton.Name = "timerButton";
            this.timerButton.Size = new System.Drawing.Size(200, 86);
            this.timerButton.TabIndex = 5;
            this.timerButton.Text = "Timer";
            this.timerButton.UseVisualStyleBackColor = false;
            // 
            // stopWatchButton
            // 
            this.stopWatchButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.stopWatchButton.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopWatchButton.Location = new System.Drawing.Point(24, 306);
            this.stopWatchButton.Margin = new System.Windows.Forms.Padding(2);
            this.stopWatchButton.Name = "stopWatchButton";
            this.stopWatchButton.Size = new System.Drawing.Size(200, 86);
            this.stopWatchButton.TabIndex = 6;
            this.stopWatchButton.Text = "StopWatch";
            this.stopWatchButton.UseVisualStyleBackColor = false;
            // 
            // budgetingButton
            // 
            this.budgetingButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.budgetingButton.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetingButton.Location = new System.Drawing.Point(267, 306);
            this.budgetingButton.Margin = new System.Windows.Forms.Padding(2);
            this.budgetingButton.Name = "budgetingButton";
            this.budgetingButton.Size = new System.Drawing.Size(200, 86);
            this.budgetingButton.TabIndex = 7;
            this.budgetingButton.Text = "Budgeting";
            this.budgetingButton.UseVisualStyleBackColor = false;
            this.budgetingButton.Click += new System.EventHandler(this.budgetingButton_Click);
            // 
            // OldUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 435);
            this.Controls.Add(this.budgetingButton);
            this.Controls.Add(this.stopWatchButton);
            this.Controls.Add(this.timerButton);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.schedulerButton);
            this.Controls.Add(this.toDoListButton);
            this.Controls.Add(this.calendarButton);
            this.Controls.Add(this.welcomeLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(553, 474);
            this.Name = "OldUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OldUserForm";
            this.Load += new System.EventHandler(this.OldUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button calendarButton;
        private System.Windows.Forms.Button toDoListButton;
        private System.Windows.Forms.Button schedulerButton;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button timerButton;
        private System.Windows.Forms.Button stopWatchButton;
        private System.Windows.Forms.Button budgetingButton;
    }
}