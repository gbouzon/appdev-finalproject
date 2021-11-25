using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace Tivi
{
    public partial class EventPromptForm : Form
    {
        String connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=tivi;";

        public EventPromptForm()
        {
            InitializeComponent();
        }

        private void EventPromptForm_Load(object sender, EventArgs e)
        {
            dateTextBox.Text = CalendarForm.static_month + "/" + UserControlDays.static_day + "/" + CalendarForm.static_year;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //test with phpmyadmin
            //to be refactored later - do not touch pls and thank
            MySqlConnection connection = new MySqlConnection(connectionString);
            String query = "INSERT INTO event(description, date, type) values(?, ?, ?)";
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("description", eventTextBox.Text);
            command.Parameters.AddWithValue("date", DateTime.ParseExact(dateTextBox.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture));
            command.Parameters.AddWithValue("type", eventGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(button => button.Checked).Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Saved", "Save Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //make message box close automatically later
            //think if we want to restart the db from scratch each time this runs
            command.Dispose();
            connection.Close();
        }
    }
}
