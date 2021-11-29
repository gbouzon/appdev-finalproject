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
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(21, 21);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(279, 43);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome back,\r\n";
            // 
            // calendarButton
            // 
            this.calendarButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.calendarButton.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarButton.Location = new System.Drawing.Point(249, 118);
            this.calendarButton.Name = "calendarButton";
            this.calendarButton.Size = new System.Drawing.Size(208, 89);
            this.calendarButton.TabIndex = 1;
            this.calendarButton.Text = "Calendar";
            this.calendarButton.UseVisualStyleBackColor = false;
            // 
            // toDoListButton
            // 
            this.toDoListButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toDoListButton.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDoListButton.Location = new System.Drawing.Point(249, 235);
            this.toDoListButton.Name = "toDoListButton";
            this.toDoListButton.Size = new System.Drawing.Size(208, 90);
            this.toDoListButton.TabIndex = 2;
            this.toDoListButton.Text = "To Do List";
            this.toDoListButton.UseVisualStyleBackColor = false;
            // 
            // schedulerButton
            // 
            this.schedulerButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.schedulerButton.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedulerButton.Location = new System.Drawing.Point(249, 364);
            this.schedulerButton.Name = "schedulerButton";
            this.schedulerButton.Size = new System.Drawing.Size(208, 90);
            this.schedulerButton.TabIndex = 3;
            this.schedulerButton.Text = "Scheduler";
            this.schedulerButton.UseVisualStyleBackColor = false;
            // 
            // OldUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 535);
            this.Controls.Add(this.schedulerButton);
            this.Controls.Add(this.toDoListButton);
            this.Controls.Add(this.calendarButton);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "OldUserForm";
            this.Text = "OldUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button calendarButton;
        private System.Windows.Forms.Button toDoListButton;
        private System.Windows.Forms.Button schedulerButton;
    }
}