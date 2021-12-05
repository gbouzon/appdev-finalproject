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
        private int seconds;
        private int minutes;
        private int hours;
        private int microseconds;

        public StopWatchForm()
        {
            InitializeComponent();
            seconds = 0;
            minutes = 0;
            hours = 0;
            microseconds = 0;

        }

        private void stopWatchTimer_Tick(object sender, EventArgs e)
        {
            seconds++;

            microseconds++;

            if (microseconds > 9)
            {
                seconds++;
                microseconds = 0;
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
            microSecondsLabel.Text = appendZero(microseconds);
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
            microSecondsLabel.Text = appendZero(microseconds);
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
    }
}
