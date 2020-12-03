using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Add1
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text=="")
            {
                Label1.Text = "Username is Required!";
            }
            else
            {
                Session["Name"] = TextBox1.Text;
                Session["Email"] = TextBox3.Text;
                Session["Phone"] = TextBox4.Text;
                Response.Redirect("Success.aspx");
            }
        }
    }
}