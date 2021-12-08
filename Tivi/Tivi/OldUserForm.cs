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
    public partial class OldUserForm : Form
    {
        private User user;

        public OldUserForm()
        {
            InitializeComponent();
        }

        public OldUserForm(User user)
        {
            InitializeComponent();
            this.user = user; //deep copy, fix copy constructor
            this.BackColor = ColorTranslator.FromHtml(user.Colour);
        }

        private void OldUserForm_Load(object sender, EventArgs e)
        {
            userLabel.Text = user.FirstName + "!";
        }

        private void calendarButton_Click(object sender, EventArgs e)
        {
            CalendarForm form = new CalendarForm(this.user);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void toDoListButton_Click(object sender, EventArgs e)
        {
            ToDoListForm form = new ToDoListForm(this.user);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void budgetingButton_Click(object sender, EventArgs e)
        {
            BudgetingForm form = new BudgetingForm(this.user);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void timerButton_Click(object sender, EventArgs e)
        {
            CountdownForm form = new CountdownForm(this.user);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void stopWatchButton_Click(object sender, EventArgs e)
        {
            StopWatchForm form = new StopWatchForm(this.user);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void noteButton_Click(object sender, EventArgs e)
        {
            Notepad form = new Notepad(); //not yet implemented nor designed
            //this.Hide();
            form.ShowDialog();
            //this.Close(); -> no way to go back for now
        }

        private void returnToMainMenuButton_Click(object sender, EventArgs e)
        {
            WelcomeForm form = new WelcomeForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}