
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
            this.components = new System.ComponentModel.Container();
            this.daysLabel = new System.Windows.Forms.Label();
            this.eventRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysLabel.Location = new System.Drawing.Point(13, 7);
            this.daysLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(28, 18);
            this.daysLabel.TabIndex = 0;
            this.daysLabel.Text = "00";
            // 
            // eventRichTextBox
            // 
            this.eventRichTextBox.BackColor = System.Drawing.Color.White;
            this.eventRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eventRichTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.eventRichTextBox.Location = new System.Drawing.Point(32, 30);
            this.eventRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.eventRichTextBox.Name = "eventRichTextBox";
            this.eventRichTextBox.ReadOnly = true;
            this.eventRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.eventRichTextBox.Size = new System.Drawing.Size(84, 54);
            this.eventRichTextBox.TabIndex = 1;
            this.eventRichTextBox.Text = "";
            this.eventRichTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.eventRichTextBox_MouseClick);
            this.eventRichTextBox.MouseEnter += new System.EventHandler(this.UserControlDays_MouseEnter);
            this.eventRichTextBox.MouseLeave += new System.EventHandler(this.UserControlDays_MouseLeave);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.eventRichTextBox);
            this.Controls.Add(this.daysLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(131, 98);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
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
