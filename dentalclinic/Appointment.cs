using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dentalclinic;

namespace dentalclinic
{
    public partial class Appointment : Form
    {
        int month, year;
        public Appointment()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displaydays();
        }
        private void displaydays()
        {
            DateTime now = new DateTime();
            month = now.Month;
            year = now.Year;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lBDATE.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlblank usblank = new UserControlblank();
                dayscontainer.Controls.Add(usblank);
            }
            for (int i = 1; i < days; i++)
            {
                UserControldays usdays = new UserControldays();
                usdays.days(i);
                dayscontainer.Controls.Add(usdays);
            }
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            dayscontainer.Controls.Clear();
            month--;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lBDATE.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlblank usblank = new UserControlblank();
                dayscontainer.Controls.Add(usblank);
            }
            for (int i = 1; i < days; i++)
            {
                UserControldays usdays = new UserControldays();
                usdays.days(i);
                dayscontainer.Controls.Add(usdays);
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            dayscontainer.Controls.Clear();
            month++;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lBDATE.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlblank usblank = new UserControlblank();
                dayscontainer.Controls.Add(usblank);
            }
            for (int i = 1; i < days; i++)
            {
                UserControldays usdays = new UserControldays();
                usdays.days(i);
                dayscontainer.Controls.Add(usdays);
            }
        }
    }
}
