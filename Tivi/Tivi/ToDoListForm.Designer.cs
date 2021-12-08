
namespace Tivi
{
    partial class ToDoListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDoListForm));
            this.titleLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.clearCheckedButton = new System.Windows.Forms.Button();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.menuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLable
            // 
            this.titleLable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLable.BackColor = System.Drawing.SystemColors.Control;
            this.titleLable.Font = new System.Drawing.Font("Ink Free", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLable.ForeColor = System.Drawing.Color.Black;
            this.titleLable.Location = new System.Drawing.Point(3, 9);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(733, 66);
            this.titleLable.TabIndex = 0;
            this.titleLable.Text = "To Do List";
            this.titleLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter here your to-do\'s:";
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("SimSun", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox.Location = new System.Drawing.Point(15, 275);
            this.textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(444, 28);
            this.textBox.TabIndex = 2;
            // 
            // checkedListBox
            // 
            this.checkedListBox.Font = new System.Drawing.Font("SimSun", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(13, 350);
            this.checkedListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(707, 280);
            this.checkedListBox.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.Control;
            this.addButton.Font = new System.Drawing.Font("Ink Free", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.Black;
            this.addButton.Location = new System.Drawing.Point(521, 252);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(159, 76);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // clearCheckedButton
            // 
            this.clearCheckedButton.BackColor = System.Drawing.SystemColors.Control;
            this.clearCheckedButton.Font = new System.Drawing.Font("Ink Free", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearCheckedButton.ForeColor = System.Drawing.Color.Black;
            this.clearCheckedButton.Location = new System.Drawing.Point(424, 740);
            this.clearCheckedButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearCheckedButton.Name = "clearCheckedButton";
            this.clearCheckedButton.Size = new System.Drawing.Size(297, 57);
            this.clearCheckedButton.TabIndex = 6;
            this.clearCheckedButton.Text = "CLEAR CHECKED";
            this.clearCheckedButton.UseVisualStyleBackColor = false;
            this.clearCheckedButton.Click += new System.EventHandler(this.clearCheckedButton_Click);
            // 
            // clearAllButton
            // 
            this.clearAllButton.BackColor = System.Drawing.SystemColors.Control;
            this.clearAllButton.Font = new System.Drawing.Font("Ink Free", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAllButton.ForeColor = System.Drawing.Color.Black;
            this.clearAllButton.Location = new System.Drawing.Point(429, 669);
            this.clearAllButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(292, 57);
            this.clearAllButton.TabIndex = 7;
            this.clearAllButton.Text = "CLEAR ALL";
            this.clearAllButton.UseVisualStyleBackColor = false;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Ink Free", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 669);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 48);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cleared 0 items";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Ink Free", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(5, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(455, 44);
            this.label3.TabIndex = 10;
            this.label3.Text = "Choose the date: \r\n";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker.CustomFormat = "";
            this.dateTimePicker.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker.Location = new System.Drawing.Point(12, 162);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(447, 27);
            this.dateTimePicker.TabIndex = 11;
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.SystemColors.Control;
            this.menuButton.Font = new System.Drawing.Font("Ink Free", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.Color.Black;
            this.menuButton.Location = new System.Drawing.Point(15, 745);
            this.menuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(159, 44);
            this.menuButton.TabIndex = 12;
            this.menuButton.Text = "MENU";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // ToDoListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(736, 840);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.clearCheckedButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximumSize = new System.Drawing.Size(754, 887);
            this.Name = "ToDoListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To Do List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button clearCheckedButton;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button menuButton;
    }
}