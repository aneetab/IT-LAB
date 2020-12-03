using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Add1
{
    public partial class Success : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string name = Session["Name"].ToString();
                string email = Session["Email"].ToString();
                string phone = Session["Phone"].ToString();
                Label1.Text = "Welcome," + name;
                Label1.Text += "<hr>Your contact details are:<hr>Email ID:" + email + "<hr>Phone:" + phone;
            }
        }
    }
}