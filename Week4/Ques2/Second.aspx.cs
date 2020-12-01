using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ques2
{
    public partial class Second : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                Label1.Text = "Entered details are:\n";
                Label1.Text += "Name:" + Session["Name"];
                Label1.Text += "\nRoll No:" + Session["Roll"];
                Label1.Text += "\nSubject:" + Session["Sub"];
                Label2.Text = "You've clicked the button 0 times";
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            HttpCookie cookie = Request.Cookies["Counter"];
            if(cookie==null)
            {
                count = 1;
                cookie = new HttpCookie("Counter");
                cookie.Expires = DateTime.Now.AddYears(1);
                

            }
            else
            {
                count = int.Parse(cookie["Counter"]);
                count += 1;
            }
            cookie["Counter"] = count.ToString();
            Response.Cookies.Add(cookie);
            Label2.Text = "You've pressed the button " + count.ToString() + " time(s)";
        }
    }
}