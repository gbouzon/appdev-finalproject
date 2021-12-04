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

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            checkedListBox.Items.Clear();
            label2.Text = "Cleared all items";
        }

        private void clearCheckedButton_Click(object sender, EventArgs e)
        {
            int totalItems = checkedListBox.Items.Count;
            int checkedItems = checkedListBox.CheckedIndices.Count;

            while (checkedListBox.CheckedItems.Count > 0)
            {
                checkedListBox.Items.Remove(checkedListBox.CheckedItems[0]);
            }

            
            label2.Text = "Cleared " + checkedItems + " items of a total of " + totalItems + " items";
        }

      
    }
}