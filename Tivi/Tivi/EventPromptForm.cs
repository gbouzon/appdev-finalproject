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
using Microsoft.Data.SqlClient;

namespace Tivi
{
    public partial class EventPromptForm : Form
    {
        //must be connected 
        //private readonly CalendarDataSet calendarDataSet = new CalendarDataSet();
        //CalendarDataSetTableAdapters.EventTableAdapter eventTableAdapter = new CalendarDataSetTableAdapters.EventTableAdapter();
        
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
            /*check this later: not updating db
            CalendarDataSet.EventRow newRow = this.calendarDataSet.Event.NewEventRow();
            newRow.Description = eventTextBox.Text;
            newRow.Date = DateTime.ParseExact(dateTextBox.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture);
            newRow.Type = eventGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(button => button.Checked).Text;
            this.calendarDataSet.Event.Rows.Add(newRow);
            this.eventTableAdapter.Update(this.calendarDataSet.Event);
            */
            MessageBox.Show("Saved", "Save Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
