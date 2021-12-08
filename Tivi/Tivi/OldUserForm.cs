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

        private void schedulerButton_Click(object sender, EventArgs e)
        {
            SchedulerForm form = new SchedulerForm(this.user);
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
            CountdownForm form = new CountdownForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void stopWatchButton_Click(object sender, EventArgs e)
        {
            StopWatchForm form = new StopWatchForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void calculatorButton_Click(object sender, EventArgs e)
        {
            CalculatorForm form = new CalculatorForm();
            form.Show();
        }
    }
}