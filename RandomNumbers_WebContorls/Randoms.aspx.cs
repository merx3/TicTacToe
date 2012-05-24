using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RandomNumbers_WebContorls
{
    public partial class Randoms : System.Web.UI.Page
    {
        protected void ButtonClicked(object sender, EventArgs e)
        {
            int minValue, maxValue;
            Random randomNumbers = new Random();
            if (int.TryParse(this.From.Text, out minValue) &&
                int.TryParse(this.To.Text, out maxValue) && (minValue < maxValue))
            {
                this.Result.Text = randomNumbers.Next(minValue, maxValue).ToString();
            }
            else
            {
                this.Result.Text = "Invalid input";
            }
        }
    }
}