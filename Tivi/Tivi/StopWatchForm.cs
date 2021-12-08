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
        private int x;
        System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();

        public StopWatchForm(User user)
        {
            InitializeComponent();
            this.user = user;
            this.BackColor = ColorTranslator.FromHtml(user.Colour);
        }

        private void stopWatchTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan Elapsed = stopwatch.Elapsed;
            lbl_time.Text = "Timer : " + string.Format("{0:00}:{1:00}:{2:00}:{3:00}", Math.Floor(Elapsed.TotalHours), Elapsed.Minutes, Elapsed.Seconds, Elapsed.Milliseconds);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            stopWatchTimer.Start();
            stopwatch.Start();
        }

        private void returnToMainMenuButton_Click(object sender, EventArgs e)
        {
            OldUserForm form = new OldUserForm(this.user);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btn_capture_Click(object sender, EventArgs e)
        {
            x += 1;
            listBox1.Items.Add( x + "-" + lbl_time.Text);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            lbl_time.Text = "Timer : 0:00:00:000";
            listBox1.Items.Clear();
            x = 0;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            stopWatchTimer.Stop();
            stopwatch.Stop();
        }
    }
}
