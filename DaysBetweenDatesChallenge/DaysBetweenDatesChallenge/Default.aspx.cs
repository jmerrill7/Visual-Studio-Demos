using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DaysBetweenDatesChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            if (myCalendar1.SelectedDate < myCalendar2.SelectedDate)
            {
                TimeSpan result = myCalendar2.SelectedDate -
                myCalendar1.SelectedDate;

                resultLabel.Text = String.Format("{0} days have passed", result.TotalDays);
            }

            else if (myCalendar1.SelectedDate > myCalendar2.SelectedDate)
            {
                TimeSpan result = myCalendar1.SelectedDate -
                myCalendar2.SelectedDate;

                resultLabel.Text = String.Format("{0} days have passed", result.TotalDays);
            }
        }
    }
}