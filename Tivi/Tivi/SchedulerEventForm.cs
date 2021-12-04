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
    public partial class SchedulerEventForm : Form
    {
        private String dayState;
        private User user;
        private String connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=tivi;";
        public SchedulerEventForm()
        {
            InitializeComponent();
        }

        public SchedulerEventForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        // check if its monday, tuesday, wednesday, thursday, friday, saturday, sunday
        private void saveButton_Click(object sender, EventArgs e)
        {
           if  (timePicker.Value.DayOfWeek.Equals(DayOfWeek.Monday)) {
                checkDayState();
           }

            if (timePicker.Value.DayOfWeek.Equals(DayOfWeek.Tuesday)) {
                checkDayState();
            }

            if (timePicker.Value.DayOfWeek.Equals(DayOfWeek.Wednesday)) {
                checkDayState();
            }

            if (timePicker.Value.DayOfWeek.Equals(DayOfWeek.Thursday)) {
                checkDayState();
            }

            if (timePicker.Value.DayOfWeek.Equals(DayOfWeek.Friday)) {
                checkDayState();
            }
            if (timePicker.Value.DayOfWeek.Equals(DayOfWeek.Saturday)) {
                checkDayState();
            }

        }

        // check if its morning, afternoon, or evening
        private void checkDayState()
        {
            if (timePicker.Value.Hour >= 1 && timePicker.Value.Hour <= 12)
            {
                dayState = "Morning";
            }
            if (timePicker.Value.Hour >= 12 && timePicker.Value.Hour <= 16)
            {
                dayState = "Afternoon";
            }
            if (timePicker.Value.Hour >= 16 && timePicker.Value.Hour <= 24)
            {
                dayState = "Evening";
            }
        }
    }

        
}
