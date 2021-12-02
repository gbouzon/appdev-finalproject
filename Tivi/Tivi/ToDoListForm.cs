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
    public partial class ToDoListForm : Form
    {
        private User user;
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

            if (newTodo == "")
            {
                MessageBox.Show("Please Input Some Text!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                checkedListBox.Items.Add($"{newTodo,-30} {date.ToLongDateString(),20}");
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