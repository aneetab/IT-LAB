using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                Session["ErrorCounter"] = 3;
                Application["LoginCounter"] = 0;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox2.Text == "")
                Label1.Text = "Please enter valid username and password";
            if (TextBox1.Text == "Aneeta" && TextBox2.Text == "Binoy")
            {
                Label1.Text ="Login success!";
                int count = (int)Application["LoginCounter"];
                count++;
                Label1.Text += "<hr>Number of users who have logged in successfully:" + count;
                Application["LoginCounter"] = count;
                Session["ErrorCounter"] = 3;


            }
            else
            {
                int count = (int)Session["ErrorCounter"];
                count--;
              
                if (count == 0)
                {
                    Label1.Text= "Login Failed!<hr>You have used up all your attempts!";
                    TextBox1.Enabled = false;
                    TextBox2.Enabled = false;
                }
                else
                {
                    Label1.Text= "Login Failed!<hr>You have " + count + " attempt(s) left!";

                }
                Session["ErrorCounter"] = count;
            }
        }
    }
}