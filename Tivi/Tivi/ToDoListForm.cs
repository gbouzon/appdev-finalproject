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
        public ToDoListForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string newTodo = textBox.Text;

            if (newTodo == "")
            {
                MessageBox.Show("Please Input Some Text!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                checkedListBox.Items.Add(newTodo);
                textBox.Text = "";
                newTodo = "";
                //textBox.SelectAll();
            }
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            checkedListBox.Items.Clear();
            //textBox.SelectAll();
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

            //textBox.SelectAll();
            label2.Text = "Cleared " + checkedItems + " items of a total of " + totalItems + " items";
        }
    }
}