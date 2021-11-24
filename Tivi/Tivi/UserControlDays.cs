using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tivi
{
    public partial class UserControlDays : UserControl
    {
        private Color userColour; //set this using user object later
        public static string static_day;

        public UserControlDays()
        {
            InitializeComponent();
        }

        public void Days(int numDay)
        {
            if (numDay < 9)
                daysLabel.Text = "0" + numDay.ToString(); //to maintain format mm/dd/yyy
            else
                daysLabel.Text = numDay.ToString();
        }

        private void UserControlDays_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Green; //change this to user's favorite color later
            this.eventRichTextBox.BackColor = Color.Green; //including richtextbox
            //richtextbox is invisible for the time being -> db update first
        }

        private void UserControlDays_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White; //resetting once mouse unfocus
            this.eventRichTextBox.BackColor = Color.White;
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = daysLabel.Text;
            EventPromptForm eventForm = new EventPromptForm();
            eventForm.Show();
        }
    }
}
