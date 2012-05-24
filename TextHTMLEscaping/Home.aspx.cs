using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TextHTMLEscaping
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.input.Attributes.Add("onFocus", "this.value=''");
        }

        protected void Submit(object sender, EventArgs e)
        {
            this.resultTxt.Text = this.input.Text;
            this.resultLbl.Text = Server.HtmlEncode(this.input.Text);
        }
    }
}