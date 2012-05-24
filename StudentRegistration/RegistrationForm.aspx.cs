using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace StudentRegistration
{
    public partial class RegistrationForm : System.Web.UI.Page
    {
        protected void GetData(object sender, EventArgs e)
        {
            string firstName, lastName;
            firstName = this.fName.Text.Trim();
            lastName = this.lName.Text.Trim();
            if (!CheckName(firstName) || !CheckName(lastName))                
            {
                this.results.InnerText = "Incorrect values";
                return;
            }

            string facultyStr = this.facNum.Text;
            for (int i = 0; i < facultyStr.Length; i++)
            {
                if (!Char.IsDigit(facultyStr[i]))
                {
                    this.results.InnerText = "Incorrect values";
                    return;
                }    
            }
            if (facultyStr.Length == 0)
            {
                this.results.InnerText = "Incorrect values";
                return;
            }    


            string university = Server.HtmlEncode(this.university.Text);
            string specialty = Server.HtmlEncode(this.specialty.Text);

            StringBuilder courses = new StringBuilder();
            ListItemCollection items = this.courses.Items;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Selected)
                {
                    courses.AppendLine(" -" + items[i].Text + "<br />");
                }
            }

            this.results.InnerHtml = "<h3>Student names: " + firstName + " " + lastName + "<br /></h3>" +
                "<p>Studying in " + university + ", " + specialty + " with faculty<br />  number " +
                facultyStr + "<br /></p>" + "<p>Signed for courses:<br />" +
                courses.ToString() + "</p>";
        }
                
        private bool CheckName(string name)
        {
            if (name.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < name.Length; i++)
            {
                if (!Char.IsLetter(name[i]))
                    return false;
            }
            return true;
        }
    }
}