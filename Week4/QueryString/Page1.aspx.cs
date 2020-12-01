using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueryString
{
    public partial class Page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                DropDownList1.Items.Add("");
                DropDownList1.Items.Add("Hyundai");
                DropDownList1.Items.Add("Honda");
                DropDownList1.Items.Add("Toyota");
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TextBox2.Text=="")
            {
                Label1.Text = "Please enter model name";
            }
            else if (DropDownList1.SelectedIndex==0)
            {
                Label1.Text = "Please seelct an item";
            }
            else
            {
                string url = "Page2.aspx?model=";
                url += Server.UrlEncode(TextBox2.Text);
                url += "&manuf=";
                url += Server.UrlEncode(DropDownList1.SelectedItem.Text);
                Response.Redirect(url);

            }
            

        }
    }
}