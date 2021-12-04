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
    public partial class NewUserForm : Form
    {
        private User user;
        private String colour;

        //from phpmyadmin
        String connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=tivi;";

        public NewUserForm()
        {
            InitializeComponent();
        }

        public NewUserForm(String email)
        {
            InitializeComponent();
            emailTextBox.Text = email; //so that the email entered in previous page is automatically entered
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            colour = "Red";
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            colour = "Green";
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            colour = "Blue";
        }

        private void orangeButton_Click(object sender, EventArgs e)
        {
            colour = "Orange";
        }

        private void purpleButton_Click(object sender, EventArgs e)
        {
            colour = "Purple";
        }

        private void pinkButton_Click(object sender, EventArgs e)
        {
            colour = "Pink";
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            colour = "Yellow";
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            user = new User(emailTextBox.Text, fnameTextBox.Text, lnameTextBox.Text, colour);

            //test
            MessageBox.Show($"email: {user.Email}, first name: {user.FirstName}, last name: {user.LastName}, colour: {user.Colour}");

            //adding user to database
            MySqlConnection connection = new MySqlConnection(connectionString);
            String insertStatement = "INSERT INTO user(email, first_name, last_name, colour) values(?, ?, ?, ?)";
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = insertStatement;

            command.Parameters.AddWithValue("email", user.Email);
            command.Parameters.AddWithValue("first_name", user.FirstName);
            command.Parameters.AddWithValue("last_name", user.LastName);
            command.Parameters.AddWithValue("colour", user.Colour);
            command.ExecuteNonQuery();

            MessageBox.Show("Saved", "Save Event", MessageBoxButtons.OK, MessageBoxIcon.Information);

            command.Dispose();
            connection.Close();

            //close form
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
