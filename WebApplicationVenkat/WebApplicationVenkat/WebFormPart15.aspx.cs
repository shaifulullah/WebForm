using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationVenkat
{
    public partial class WebForm1Part15 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button1.Click += Button1_Click;
            Button1.Command += Button1_Command;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Button click event <br/>");
        }

        protected void Button1_Command(object sender, CommandEventArgs e)
        {
            Response.Write("Button Command event <br/>");
        }

        protected void CommandButton_Click(object sender, CommandEventArgs e)
        {
            e.
        }
    }
}