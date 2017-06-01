using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoubleCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            double firstInput = double.Parse(value1.Text);
            double secondInput = double.Parse(value2.Text);
            double result = (firstInput + secondInput);
            resultLabel.Text = result.ToString();
        }

        protected void subtractButton_Click(object sender, EventArgs e)
        {
            double firstInput = double.Parse(value1.Text);
            double secondInput = double.Parse(value2.Text);
            double result = (firstInput - secondInput);
            resultLabel.Text = result.ToString();
        }

        protected void multiplyButton_Click(object sender, EventArgs e)
        {
            double firstValue = double.Parse(value1.Text);
            double secondValue = double.Parse(value2.Text);
            double result = (firstValue * secondValue);
            resultLabel.Text = result.ToString();
        }

        protected void divideButton_Click(object sender, EventArgs e)
        {
            double firstValue = double.Parse(value1.Text);
            double secondValue = double.Parse(value2.Text);
            double result = (firstValue / secondValue);
            resultLabel.Text = result.ToString();
        }
    }
}