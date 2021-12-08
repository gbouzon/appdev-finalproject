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

namespace Tivi
{
    public partial class CalendarForm : Form
    {
        private User user;
        private static readonly DateTime current = DateTime.Now;
        private int month = Convert.ToInt32(current.Month);
        private int year = Convert.ToInt32(current.Year);

        public static string static_month, static_year;

        public CalendarForm()
        {
            InitializeComponent();
        }
        public CalendarForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void CalendarForm_Load(object sender, EventArgs e)
        {
            DisplayDays(year, month);
        }


        private void DisplayDays(int displayYear, int displayMonth)
        {
            //setting calendar title to Month YEAR format
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(displayMonth);
            dateLabel.Text = monthName + " " + displayYear;

            static_month = displayMonth.ToString("d2");
            static_year = displayYear.ToString("d4");

            //first day of the month
            DateTime startOfMonth = new DateTime(displayYear, displayMonth, 1);

            //how many days are in the current month
            int days = DateTime.DaysInMonth(displayYear, displayMonth);

            //int conversion
            int dayOfWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;

            //blank user control
            for (int i = 1; i < dayOfWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays(user);
                ucdays.Days(i);
                dayContainer.Controls.Add(ucdays);
            }
        }

        private void ClearCalendar()
        {
            dayContainer.Controls.Clear();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            //if it's december then we move on to next year and reset month to january
            if (month == 12)
            {
                year++;
                month = 0;
            }

            month++;
            ClearCalendar();
            DisplayDays(year, month);
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            OldUserForm form = new OldUserForm(this.user);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            //if it's january then we go back to the previous year and reset month to december
            if (month == 1)
            {
                year--;
                month = 13;
            }

            month--;
            ClearCalendar();
            DisplayDays(year, month);
        }
    }
}