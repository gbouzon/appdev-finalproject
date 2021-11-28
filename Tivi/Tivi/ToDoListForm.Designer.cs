
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
            this.titleLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.clearCheckedButton = new System.Windows.Forms.Button();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLable
            // 
            this.titleLable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLable.BackColor = System.Drawing.Color.DarkSalmon;
            this.titleLable.Font = new System.Drawing.Font("Ink Free", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLable.ForeColor = System.Drawing.Color.White;
            this.titleLable.Location = new System.Drawing.Point(3, 9);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(605, 43);
            this.titleLable.TabIndex = 0;
            this.titleLable.Text = "To Do List";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter here your to-do\'s:";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(20, 143);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(330, 25);
            this.textBox.TabIndex = 2;
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(20, 183);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(508, 284);
            this.checkedListBox.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.LightSalmon;
            this.addButton.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(395, 132);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(133, 42);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // clearCheckedButton
            // 
            this.clearCheckedButton.BackColor = System.Drawing.Color.LightSalmon;
            this.clearCheckedButton.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearCheckedButton.ForeColor = System.Drawing.Color.White;
            this.clearCheckedButton.Location = new System.Drawing.Point(39, 519);
            this.clearCheckedButton.Name = "clearCheckedButton";
            this.clearCheckedButton.Size = new System.Drawing.Size(189, 42);
            this.clearCheckedButton.TabIndex = 6;
            this.clearCheckedButton.Text = "CLEAR CHECKED";
            this.clearCheckedButton.UseVisualStyleBackColor = false;
            this.clearCheckedButton.Click += new System.EventHandler(this.clearCheckedButton_Click);
            // 
            // clearAllButton
            // 
            this.clearAllButton.BackColor = System.Drawing.Color.LightSalmon;
            this.clearAllButton.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAllButton.ForeColor = System.Drawing.Color.White;
            this.clearAllButton.Location = new System.Drawing.Point(310, 519);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(189, 42);
            this.clearAllButton.TabIndex = 7;
            this.clearAllButton.Text = "CLEAR ALL";
            this.clearAllButton.UseVisualStyleBackColor = false;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Ink Free", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cleared 0 items";
            // 
            // ToDoListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(610, 583);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.clearCheckedButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLable);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ToDoListForm";
            this.Text = "Tivi";
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
    }
}