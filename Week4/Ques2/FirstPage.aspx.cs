using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ques2
{
    public partial class FirstPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                DropDownList1.Items.Add("");
                DropDownList1.Items.Add("Science");
                DropDownList1.Items.Add("Maths");
                DropDownList1.Items.Add("Computer Science");
                DropDownList1.Items.Add("Chemistry");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
                Label1.Text = "Please enter name";
            else if (TextBox2.Text == "")
                Label1.Text = "Please enter roll no";
            else if (DropDownList1.SelectedIndex ==0)
                Label1.Text = "Please select a subject";
            else
            {
                string name = TextBox1.Text;
                Session["Name"]=name;
                string roll = TextBox2.Text;
                Session["Roll"] = roll;
                string sub = DropDownList1.SelectedItem.Text;
                Session["Sub"] = sub;
                Response.Redirect("Second.aspx");
            }
        }
    }
}