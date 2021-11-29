﻿using System;
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
using System.Text.RegularExpressions;

namespace Tivi
{
    public partial class WelcomeForm : Form
    {
        //from phpmyadmin
        String connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=tivi;";
        static User user; //test for now

        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            String email = emailTextBox.Text;

            if (!User.EMAIL_REGEX.IsMatch(email))
                MessageBox.Show("Please enter a valid email!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void emailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            String firstName = string.Empty;
            String lastName = string.Empty;
            String colour = string.Empty;
            String email = emailTextBox.Text;

            if (e.KeyChar == (Int32)Keys.Enter)
            {
  
                if (!User.EMAIL_REGEX.IsMatch(email))
                    MessageBox.Show("Please enter a valid email!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                String query = "SELECT * FROM user WHERE email = ?";

                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand command = connection.CreateCommand();
                command.CommandText = query;
                command.Parameters.AddWithValue("email", email);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read(); //there will only be one row because email is primary key
                    firstName = reader["first_name"].ToString();
                    lastName = reader["last_name"].ToString();
                    colour = reader["colour"].ToString();
                    
                    //new old form and then close this one
                    //old form will probably take a user as a parameter

                }
                else
                {
                    //if no user is found
                    NewUserForm form = new NewUserForm(email);
                    form.Show();
                    //this.Close() -> releases resources before we manage to create new one, figure it out later
                }

                //just to make sure info retrieval is on the up and up
                MessageBox.Show($"first name: {firstName}, last name: {lastName}, colour: {colour}");

                reader.Dispose();
                command.Dispose();
                connection.Close();
            }

        }
    }
}