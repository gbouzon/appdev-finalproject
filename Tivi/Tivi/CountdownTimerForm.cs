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
    public partial class CountdownForm : Form
    {
        private int totalSeconds;
        User user;
        public CountdownForm()
        {
            InitializeComponent();
        }

        public CountdownForm(User user)
        {
            InitializeComponent();
            this.user = user;
            this.BackColor = ColorTranslator.FromHtml(user.Colour);
        }

        private void CountdownForm_Load(object sender, EventArgs e)
        {
            this.stopButton.Enabled = false;
         
            for (int i = 0; i < 60; i++)
            {
                this.minutesComboBox.Items.Add(i.ToString());
                this.secondsComboBox.Items.Add(i.ToString());
            }
            this.minutesComboBox.SelectedIndex = 59;
            this.secondsComboBox.SelectedIndex = 59;


        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.startButton.Enabled = false;
            this.stopButton.Enabled = true;
            int minutes = int.Parse(this.minutesComboBox.SelectedItem.ToString());
            int seconds = int.Parse(this.secondsComboBox.SelectedItem.ToString());

            totalSeconds = (minutes * 60) + seconds;

            this.countdownTimer.Enabled = true;

        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            this.stopButton.Enabled = false;
            this.startButton.Enabled = true;

            totalSeconds = 0;
            this.countdownTimer.Enabled = false;
        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0)
            {
                totalSeconds--;
                int minutes = totalSeconds / 60;
                int seconds = totalSeconds - (minutes * 60);
                this.bigLabel.Text = minutes.ToString() + ":" + seconds.ToString(); 
            }
            else 
            {
                this.countdownTimer.Stop();
                MessageBox.Show("Time's up!");
            }

        }

        private void returnToMainMenu_Click(object sender, EventArgs e)
        {
            OldUserForm form = new OldUserForm(this.user);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
