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
    public partial class StopWatchForm : Form
    {
        User user;
        private int seconds;
        private int minutes;
        private int hours;
        private int milliseconds;

        public StopWatchForm()
        {
            InitializeComponent();
            seconds = 0;
            minutes = 0;
            hours = 0;
            milliseconds = 0;
        }

        public StopWatchForm(User user)
        {
            InitializeComponent();
            seconds = 0;
            minutes = 0;
            hours = 0;
            milliseconds = 0;
            this.user = user;
            this.BackColor = ColorTranslator.FromHtml(user.Colour);
        }

        private void stopWatchTimer_Tick(object sender, EventArgs e)
        {
            seconds++;
            milliseconds++;

            if (milliseconds > 9)
            {
                seconds++;
                milliseconds = 0;
            }

            if (seconds > 59)
            {
                minutes++;
                seconds = 0;
            }
           
            if (minutes > 59)
            {
                hours++;
                minutes = 0;
            }

            hoursLabel.Text = appendZero(hours);
            minutesLabel.Text = appendZero(minutes);
            secondsLabel.Text = appendZero(seconds);
            millisecondsLabel.Text = appendZero(milliseconds);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            stopWatchTimer.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            stopWatchTimer.Stop();
            seconds = 0;
            minutes = 0;
            hours = 0;

            hoursLabel.Text = appendZero(hours);
            minutesLabel.Text = appendZero(minutes);
            secondsLabel.Text = appendZero(seconds);
        }

        private string appendZero(double str)
        {
            if (str <= 9)
            {
                return "0" + str;
            }
            else
            {
                return str.ToString();
            }

        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            stopWatchTimer.Stop();
        }

        private void returnToMainMenuButton_Click(object sender, EventArgs e)
        {
            OldUserForm form = new OldUserForm(this.user);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
