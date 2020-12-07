using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QUES2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ListBox1.SelectedIndex == -1)
                Label1.Text = "Please select a package";
            else
            {
                string id = ListBox1.SelectedItem.Text;
                string url = "WebForm2.aspx?id=" + id;
                Response.Redirect(url);
            }
        }
    }
}