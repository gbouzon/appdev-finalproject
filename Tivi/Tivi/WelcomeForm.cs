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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void emailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Int32) Keys.Enter)
                MessageBox.Show("Enter Pressed");
        }
    }
}
