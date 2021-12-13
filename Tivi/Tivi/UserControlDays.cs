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
        private User user;
        //from phpmyadmin
        String connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=tivi;";

        public static string static_day;

        public UserControlDays()
        {
            InitializeComponent();
        }

        public UserControlDays(User user)
        {
            InitializeComponent();
            this.user = new User(user);
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            //displaying all events/tasks on load
            string dateStr = CalendarForm.static_year + "-" + CalendarForm.static_month + "-" + this.daysLabel.Text;
            DisplayEvent(dateStr);     
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
            this.BackColor = (user.Colour.ToString() != "") ? ColorTranslator.FromHtml(user.Colour) : Color.White; //just in case
            this.eventRichTextBox.BackColor = (user.Colour.ToString() != "") ? ColorTranslator.FromHtml(user.Colour) : Color.White; //just in case
        }

        private void UserControlDays_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White; //resetting once mouse unfocus
            this.eventRichTextBox.BackColor = Color.White;
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = this.daysLabel.Text;
            EventPromptForm eventForm = new EventPromptForm(this.user);
            eventForm.ShowDialog();
      
        }

        //displaying event in richtextbox
        private void DisplayEvent(string dateStr)
        {
            String query = "SELECT * FROM event WHERE date = ? AND user_email = ?";
            DateTime date = DateTime.ParseExact(dateStr, "yyyy-MM-dd", CultureInfo.CurrentCulture);
            String email = user.Email;

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("date", date);
            command.Parameters.AddWithValue("user_email", email);

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string description = reader["description"].ToString();
                    int counter = 0;

                    //avoid infinite loop with timer's tick
                    if (!this.eventRichTextBox.Text.Contains(description) && counter <= 4) //not allowing more than 4 entries per day
                    {
                        eventRichTextBox.Text += description + "\n";
                        counter++;
                    }

                    //adding a checkbox for tasks
                    if (reader["type"].ToString().Equals("Task"))
                    {
                        int lineNumber = Array.IndexOf(this.eventRichTextBox.Lines, description);
                        CheckBox box = new CheckBox();
                        box.AutoSize = true;
                        box.Location = new Point(daysLabel.Location.X, this.eventRichTextBox.Location.Y + (lineNumber * 14));
                        this.Controls.Add(box);
                    }
                }
            }

            reader.Dispose();
            command.Dispose();
            connection.Close();
        }

        private void eventRichTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            static_day = this.daysLabel.Text;
            EventPromptForm eventForm = new EventPromptForm(this.user);
            eventForm.ShowDialog();
        }
    }
}