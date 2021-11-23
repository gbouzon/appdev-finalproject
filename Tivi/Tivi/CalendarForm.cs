﻿using System;
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
    public partial class CalendarForm : Form
    {
        
        private static readonly DateTime current = DateTime.Now;
        private int month = current.Month;
        private int year = current.Year;

        public CalendarForm()
        {
            InitializeComponent();
        }

        private void CalendarForm_Load(object sender, EventArgs e)
        {
            DisplayDays(year, month);
        }

        private void DisplayDays(int displayYear, int displayMonth)
        {
            month = current.Month;
            year = current.Year;

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
                UserControlDays ucdays = new UserControlDays();
                ucdays.Days(i);
                dayContainer.Controls.Add(ucdays);
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            month++;
        }
    }
}
