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
    public partial class UserControlDays : UserControl
    {
        //from phpmyadmin
        String connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=tivi;";

        private Color userColour; //set this using user object later
        public static string static_day;

        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            //displaying all events/tasks on load
           // if (!String.IsNullOrEmpty(this.daysLabel.Text))
           // {
                string dateStr = CalendarForm.static_year + "-" + CalendarForm.static_month + "-" + this.daysLabel.Text;
                DisplayEvent(dateStr);
           // }
        }

        public void Days(int numDay)
        {
            if (numDay < 10)
                daysLabel.Text = "0" + numDay.ToString(); //to maintain format mm/dd/yyy
            else
                daysLabel.Text = numDay.ToString();
        }

        private void UserControlDays_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Green; //change this to user's favorite color later
            this.eventRichTextBox.BackColor = Color.Green; //including richtextbox
        }

        private void UserControlDays_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White; //resetting once mouse unfocus
            this.eventRichTextBox.BackColor = Color.White;
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            timer1.Start();
            static_day = daysLabel.Text;
            EventPromptForm eventForm = new EventPromptForm();
            eventForm.Show();
        }

        //displaying event in richtextbox
        private void DisplayEvent(string dateStr)
        {
            String query = "SELECT * FROM event WHERE date = ?";
            DateTime date = DateTime.ParseExact(dateStr, "yyyy-MM-dd", CultureInfo.CurrentCulture);

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("date", date);

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                    //avoid infinite loop with timer's tick
                    if (!this.eventRichTextBox.Text.Contains(reader["description"].ToString()))
                        eventRichTextBox.Text += reader["description"].ToString() + "\n";
            }

            reader.Dispose();
            command.Dispose();
            connection.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string dateStr = CalendarForm.static_year + "-" + CalendarForm.static_month + "-" + static_day;
            DisplayEvent(dateStr);
        }
    }
}