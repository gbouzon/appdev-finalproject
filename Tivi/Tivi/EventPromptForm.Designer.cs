
namespace Tivi
{
    partial class EventPromptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventPromptForm));
            this.eventTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eventGroupBox = new System.Windows.Forms.GroupBox();
            this.taskRadioButton = new System.Windows.Forms.RadioButton();
            this.eventRadioButton = new System.Windows.Forms.RadioButton();
            this.saveButton = new System.Windows.Forms.Button();
            this.eventGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventTextBox
            // 
            this.eventTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventTextBox.Location = new System.Drawing.Point(21, 115);
            this.eventTextBox.Name = "eventTextBox";
            this.eventTextBox.Size = new System.Drawing.Size(294, 32);
            this.eventTextBox.TabIndex = 0;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTextBox.Location = new System.Drawing.Point(21, 49);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(294, 32);
            this.dateTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Event";
            // 
            // eventGroupBox
            // 
            this.eventGroupBox.Controls.Add(this.taskRadioButton);
            this.eventGroupBox.Controls.Add(this.eventRadioButton);
            this.eventGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventGroupBox.Location = new System.Drawing.Point(62, 162);
            this.eventGroupBox.Name = "eventGroupBox";
            this.eventGroupBox.Size = new System.Drawing.Size(210, 59);
            this.eventGroupBox.TabIndex = 4;
            this.eventGroupBox.TabStop = false;
            this.eventGroupBox.Text = "Type";
            // 
            // taskRadioButton
            // 
            this.taskRadioButton.AutoSize = true;
            this.taskRadioButton.Location = new System.Drawing.Point(118, 24);
            this.taskRadioButton.Name = "taskRadioButton";
            this.taskRadioButton.Size = new System.Drawing.Size(66, 24);
            this.taskRadioButton.TabIndex = 1;
            this.taskRadioButton.TabStop = true;
            this.taskRadioButton.Text = "Task";
            this.taskRadioButton.UseVisualStyleBackColor = true;
            // 
            // eventRadioButton
            // 
            this.eventRadioButton.AutoSize = true;
            this.eventRadioButton.Location = new System.Drawing.Point(3, 22);
            this.eventRadioButton.Name = "eventRadioButton";
            this.eventRadioButton.Size = new System.Drawing.Size(72, 24);
            this.eventRadioButton.TabIndex = 0;
            this.eventRadioButton.TabStop = true;
            this.eventRadioButton.Text = "Event";
            this.eventRadioButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(124, 237);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(83, 29);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // EventPromptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 278);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.eventGroupBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.eventTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EventPromptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add an Event";
            this.Load += new System.EventHandler(this.EventPromptForm_Load);
            this.eventGroupBox.ResumeLayout(false);
            this.eventGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eventTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox eventGroupBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RadioButton taskRadioButton;
        private System.Windows.Forms.RadioButton eventRadioButton;
    }
}