using System;
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
            addUserControls();

            // The week starts with Sunday -> IF SUNDAY THEN GENERATE THE DATES (going forward)
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

            // If the week does not start with Sunday, get previous Sunday and then add dates going forward
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
            clearScheduler();
            if (schedulerFlowLayoutPanel.Controls.Count == 0)
                addUserControls();
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

        // if the previous button is clicked
        private void previousButton_Click(object sender, EventArgs e)
        {
            // adding user controls? Do I add user controls all the time?
            if (schedulerFlowLayoutPanel.Controls.Count == 0)
                addUserControls();

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

        // adds 24 user controls in the container
        private void addUserControls()
        {
            for (int i = 1; i <= 24; i++)
            {
                UserControlLarge boxUserControl = new UserControlLarge();    // UserControl is named UserControlLarge
                schedulerFlowLayoutPanel.Controls.Add(boxUserControl);
            }
        }

        // Should I KEEP THIS?
        private void clearAllButton_Click(object sender, EventArgs e)
        {
            schedulerFlowLayoutPanel.Controls.Clear();
            addUserControls();
        }

        // removes all the UserControls
        private void clearScheduler()
        {
            schedulerFlowLayoutPanel.Controls.Clear();
        }


    }
}

/*USELESS PIECE OF SHITS these following codes :')
// mornings of the week
private void morningSundayUC_Load(object sender, EventArgs e)
{
    SchedulerEventForm morningSun = new SchedulerEventForm();
    morningSun.Show();
}

private void morningMondayUC_Load(object sender, EventArgs e)
{
    SchedulerEventForm morningMon = new SchedulerEventForm();
    morningMon.Show();
}

private void morningTuesdayUC_Load(object sender, EventArgs e)
{
    SchedulerEventForm morningTues = new SchedulerEventForm();
    morningTues.Show();
}

private void morningWednesdayUC_Load(object sender, EventArgs e)
{
    SchedulerEventForm morningWed = new SchedulerEventForm();
    morningWed.Show();
}

private void morningThursdayUC_Load(object sender, EventArgs e)
{
    SchedulerEventForm morningThurs = new SchedulerEventForm();
    morningThurs.Show();
}

private void morningFridayUC_Load(object sender, EventArgs e)
{
    SchedulerEventForm morningFri = new SchedulerEventForm();
    morningFri.Show();
}

private void morningSaturdayUC_Load(object sender, EventArgs e)
{
    SchedulerEventForm morningSat = new SchedulerEventForm();
    morningSat.Show();
}

private void afternoonSundayUC_Load(object sender, EventArgs e)
{
    SchedulerEventForm afternoonSun = new SchedulerEventForm();
    afternoonSun.Show();
}

private void afternoonMondayUC_Load(object sender, EventArgs e)
{
    SchedulerEventForm afternoonMon = new SchedulerEventForm();
    afternoonMon.Show();
}

private void afternoonTuesdayUC_Load(object sender, EventArgs e)
{
    SchedulerEventForm afternoonTues = new SchedulerEventForm();
    afternoonTues.Show();
}

private void wednesdayAfternoonUC_Load(object sender, EventArgs e)
{
    SchedulerEventForm afternoonWed = new SchedulerEventForm();
    afternoonWed.Show();
}

private void thursdayAfternoonUC_Load(object sender, EventArgs e)
{
    SchedulerEventForm afternoonThurs = new SchedulerEventForm();
    afternoonThurs.Show();
}

private void afternoonFridayUC_Load(object sender, EventArgs e)
{
    SchedulerEventForm afternoonFri = new SchedulerEventForm();
    afternoonFri.Show();
}

private void afternoonSaturdayUC_Load(object sender, EventArgs e)
{
    SchedulerEventForm afternoonSat = new SchedulerEventForm();
    afternoonSat.Show();
}


private void eveningSundayUC_Load(object sender, EventArgs e)
{
    SchedulerEventForm eveningSun = new SchedulerEventForm();
    eveningSun.Show();
}

private void eveningMondayUC_Load(object sender, EventArgs e)
{
    SchedulerEventForm eveningMon = new SchedulerEventForm();
    eveningMon.Show();
}

private void eveningTuesdayUC_Load(object sender, EventArgs e)
{
    SchedulerEventForm eveningTues = new SchedulerEventForm();
    eveningTues.Show();
}

private void eveningWednesdayUC_Load(object sender, EventArgs e)
{
    SchedulerEventForm eveningWed = new SchedulerEventForm();
    eveningWed.Show();
}

private void eveningThursdayUC_Load(object sender, EventArgs e)
{
    SchedulerEventForm eveningThurs = new SchedulerEventForm();
    eveningThurs.Show();
}

private void eveningFridayUC_Load(object sender, EventArgs e)
{
    SchedulerEventForm eveningFri = new SchedulerEventForm();
    eveningFri.Show();
}

private void eveningSaturdayUC_Load(object sender, EventArgs e)
{
    SchedulerEventForm eveningSat = new SchedulerEventForm();
    eveningSat.Show();
}


*/