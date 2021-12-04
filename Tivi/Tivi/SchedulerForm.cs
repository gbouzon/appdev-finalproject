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
    public partial class SchedulerForm : Form
    {
        DateTime datetime = DateTime.Now;
        private User user;
        public SchedulerForm()
        {
            InitializeComponent();
        }
        public SchedulerForm(User user)
        {
            InitializeComponent();
        }
        private void SchedulerForm_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 24; i++)
            {
                UserControlLarge boxUserControl = new UserControlLarge();
                schedulerFlowLayoutPanel.Controls.Add(boxUserControl);
            }


            // IF SUNDAY THEN GENERATE THE DATES (going forward)
            if (datetime.DayOfWeek == DayOfWeek.Sunday)
            {
                sundayDate.Text = "" + datetime.Date;
                mondayDate.Text = "" + datetime.AddDays(1).Date;
                tuesdayDate.Text = "" + datetime.AddDays(2).Date;
                wednesdayDate.Text = "" + datetime.AddDays(3).Date;
                thursdayDate.Text = "" + datetime.AddDays(4).Date;
                fridayDate.Text = "" + datetime.AddDays(5).Date;
                saturdayDate.Text = "" + datetime.AddDays(6).Date;

            }

            // IF NOT SUNDAY THEN GET PREVIOUS SUNDAY and then add dates going forward
            else
            {
                int dayInWeek = (int)datetime.DayOfWeek;
                DateTime prevMonday = datetime.AddDays(-(((dayInWeek + 6) % 7) + 7));
                DateTime prevSunday = prevMonday.AddDays(6);

                DateTime initial = prevSunday;
                sundayDate.Text = "" + initial;
                mondayDate.Text = "" + initial.AddDays(1).Date;
                tuesdayDate.Text = "" + initial.AddDays(2).Date;
                wednesdayDate.Text = "" + initial.AddDays(3).Date;
                thursdayDate.Text = "" + initial.AddDays(4).Date;
                fridayDate.Text = "" + initial.AddDays(5).Date;
                saturdayDate.Text = "" + initial.AddDays(6).Date;

                datetime = prevSunday;   // set the datetime to previous sunday
            }

        }

        // get next week 
        private void nextButton_Click(object sender, EventArgs e)
        {
            // start from previous sunday to next sunday
            DateTime nextSunday = datetime.AddDays(7 - (int)datetime.DayOfWeek);

            sundayDate.Text = "" + nextSunday.Date;
            mondayDate.Text = "" + nextSunday.AddDays(1).Date;
            tuesdayDate.Text = "" + nextSunday.AddDays(2).Date;
            wednesdayDate.Text = "" + nextSunday.AddDays(3).Date;
            thursdayDate.Text = "" + nextSunday.AddDays(4).Date;
            fridayDate.Text = "" + nextSunday.AddDays(5).Date;
            saturdayDate.Text = "" + nextSunday.AddDays(6).Date;
            datetime = nextSunday;
           
  
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            int dayInWeek = (int)datetime.DayOfWeek;
            DateTime prevMonday = datetime.AddDays(-(((dayInWeek + 6) % 7) + 7));
            DateTime prevSunday = prevMonday.AddDays(6);

            DateTime initial = prevSunday;
    
            sundayDate.Text = "" + initial.Date;
            mondayDate.Text = "" + initial.AddDays(1).Date;
            tuesdayDate.Text = "" + initial.AddDays(2).Date;
            wednesdayDate.Text = "" + initial.AddDays(3).Date;
            thursdayDate.Text = "" + initial.AddDays(4).Date;
            fridayDate.Text = "" + initial.AddDays(5).Date;
            saturdayDate.Text = "" + initial.AddDays(6).Date;
            datetime = prevSunday;
        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
