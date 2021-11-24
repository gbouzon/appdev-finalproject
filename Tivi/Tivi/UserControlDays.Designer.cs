
namespace Tivi
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.daysLabel = new System.Windows.Forms.Label();
            this.eventRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysLabel.Location = new System.Drawing.Point(17, 9);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(38, 25);
            this.daysLabel.TabIndex = 0;
            this.daysLabel.Text = "00";
            // 
            // eventRichTextBox
            // 
            this.eventRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eventRichTextBox.Location = new System.Drawing.Point(43, 37);
            this.eventRichTextBox.Name = "eventRichTextBox";
            this.eventRichTextBox.Size = new System.Drawing.Size(112, 71);
            this.eventRichTextBox.TabIndex = 1;
            this.eventRichTextBox.Text = "";
            this.eventRichTextBox.Visible = false;
            this.eventRichTextBox.MouseEnter += new System.EventHandler(this.UserControlDays_MouseEnter);
            this.eventRichTextBox.MouseLeave += new System.EventHandler(this.UserControlDays_MouseLeave);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.eventRichTextBox);
            this.Controls.Add(this.daysLabel);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(175, 120);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.MouseEnter += new System.EventHandler(this.UserControlDays_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UserControlDays_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.RichTextBox eventRichTextBox;
    }
}
