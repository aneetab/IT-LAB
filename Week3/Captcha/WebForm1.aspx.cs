using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Captcha
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static int count=0;
        string captcha = "LHGFHS";
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if(!this.IsPostBack)
            {
                count = 3; 
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            count--;
            string inp = TextBox1.Text;
            if(string.Equals(captcha,inp))
            {
                Label2.Text = "Success!";
                count = 3;
            }
            else if(count==0)
            {
                Label2.Text = "Incorrect Captcha!";
                TextBox1.Enabled = false;
            }
            else
            {
                Label2.Text = "Incorrect Captcha!You've got "+count+"more attempts.";
            }
            

        }
    }
}