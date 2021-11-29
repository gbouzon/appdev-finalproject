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
            this.user = new User(user); //deep copy
        }

        private void OldUserForm_Load(object sender, EventArgs e)
        {
            userLabel.Text = user.FirstName + "!";
        }

        private void calendarButton_Click(object sender, EventArgs e)
        {
            CalendarForm form = new CalendarForm();
            form.Show();
        }

        private void toDoListButton_Click(object sender, EventArgs e)
        {
            ToDoListForm form = new ToDoListForm();
            form.Show();
        }
    }
}