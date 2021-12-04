using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tivi
{
    public partial class UserControlLarge : UserControl
    {
        private RichTextBox eventRichTextBox;

        public UserControlLarge()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.eventRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // eventRichTextBox
            // 
            this.eventRichTextBox.Enabled = false;
            this.eventRichTextBox.Location = new System.Drawing.Point(3, 3);
            this.eventRichTextBox.Name = "eventRichTextBox";
            this.eventRichTextBox.Size = new System.Drawing.Size(205, 214);
            this.eventRichTextBox.TabIndex = 0;
            this.eventRichTextBox.Text = "";
            // 
            // UserControlLarge
            // 
            this.BackColor = System.Drawing.Color.Bisque;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.eventRichTextBox);
            this.Name = "UserControlLarge";
            this.Size = new System.Drawing.Size(211, 220);
            this.Click += new System.EventHandler(this.UserControlLarge_Click);
            this.ResumeLayout(false);

        }

        private void UserControlLarge_Click(object sender, EventArgs e)
        {
            SchedulerEventForm schedulerEventForm = new SchedulerEventForm();
            schedulerEventForm.Show();
        }
    }
}
