using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mobile
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                DropDownList1.Items.Add("");
                DropDownList1.Items.Add("OnePlus Nord");
                DropDownList1.Items.Add("Iphone 12");
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = "You've selected " + DropDownList1.SelectedItem.Text;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex == 0)
            {
                Label1.Text = "You must select a phone";
            }
            else
            {
                string phone = DropDownList1.SelectedItem.Text;
                Session["Mobile"] = phone;
                Response.Redirect("Page2.aspx");
            }

        }
    }
}