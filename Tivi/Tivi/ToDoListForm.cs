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
    public partial class ToDoListForm : Form
    {
        private User user;
        //from phpmyadmin
        String connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=tivi;";
        public ToDoListForm()
        {
            InitializeComponent();
        }

        public ToDoListForm(User user)
        {
            InitializeComponent();
            this.user = user;
            LoadTasks();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker.Value;
            string newTodo = textBox.Text;
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "MM/dd/yyyy";

            if (newTodo == "")
            {
                MessageBox.Show("Please Input Some Text!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                checkedListBox.Items.Add($"{newTodo,-40} {date.ToLongDateString(),20}");
    
                MySqlConnection connection = new MySqlConnection(connectionString);
                String insertStatement = "INSERT INTO to_do(description, date, user_email) values(?, ?, ?)";
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = insertStatement;

                //inserting new row into database with info entered by user
                command.Parameters.AddWithValue("description", newTodo);
                command.Parameters.AddWithValue("date", date);
                command.Parameters.AddWithValue("user_email", user.Email);
                command.ExecuteNonQuery();

                command.Dispose();
                connection.Close();

                textBox.Text = "";
                newTodo = "";
            }
        }

        private void LoadTasks() //DO NOT TOUCH GIU'S BRAIN NEEDS TO FUCKING FIX THIS THANKS
        {
            String query = "SELECT * FROM to_do WHERE user_email = ?";
            String email = user.Email;

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("user_email", email);

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string description = reader["description"].ToString();
                    DateTime date = DateTime.Parse(reader["date"].ToString());
                    checkedListBox.Items.Add($"{description,-40} {date.ToLongDateString(),20}");
                }
            }

            reader.Dispose();
            command.Dispose();
            connection.Close();
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            checkedListBox.Items.Clear();
            label2.Text = "Cleared all items";

            MySqlConnection connection = new MySqlConnection(connectionString);
            String deleteStatement = "DELETE FROM to_do WHERE user_email = ?";
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = deleteStatement;

            command.Parameters.AddWithValue("user_email", user.Email);
            command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
        }

        private void clearCheckedButton_Click(object sender, EventArgs e) //refactor this shit pls later giu you have db operations everywhere ya dumbass 
        {
            //DO NOT TOUCH GIU'S BRAIN NEEDS TO FUCKING FIX THIS THANKS
            int totalItems = checkedListBox.Items.Count;
            int checkedItems = checkedListBox.CheckedIndices.Count;
            var itemsChecked = checkedListBox.CheckedItems;

            MySqlConnection connection = new MySqlConnection(connectionString);
            String query = "SELECT * FROM to_do where user_email = ?";

            String email = user.Email;

            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("user_email", email);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string description = reader["description"].ToString() + DateTime.Parse(reader["date"].ToString()).ToLongDateString();
                    foreach (object item in itemsChecked)
                    { //pls find a better way of doing this laters thank
                        //just want to say giu is a dumbass :/
                        MessageBox.Show(System.Text.RegularExpressions.Regex.Replace(item.ToString(), @"\s+", ""));
                        MessageBox.Show(description);
                        if (System.Text.RegularExpressions.Regex.Replace(description, @"\s+", "").Equals(System.Text.RegularExpressions.Regex.Replace(item.ToString(), @"\s+", "")))
                            DeleteFromDatabase(reader["task_id"].ToString());
                    }
                }


                reader.Dispose();
                command.Dispose();
                connection.Close();
            }

            while (checkedListBox.CheckedItems.Count > 0)
                checkedListBox.Items.Remove(checkedListBox.CheckedItems[0]);

            label2.Text = "Cleared " + checkedItems + " items of a total of " + totalItems + " items";
        }

        private void DeleteFromDatabase(string id) //DO NOT TOUCH GIU'S BRAIN NEEDS TO FUCKING FIX THIS THANKS
        {
            String deleteStatement = "DELETE FROM to_do WHERE task_id = ?";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = deleteStatement;

            command.Parameters.AddWithValue("task_id", id);
            command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            OldUserForm form = new OldUserForm(this.user);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}