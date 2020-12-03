using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mynta
{
    public partial class Electronics : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                DropDownList1.Items.Add("");
                DropDownList1.Items.Add("Mobiles");
                DropDownList1.Items.Add("Laptops");
                DropDownList1.Items.Add("Printers");
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DropDownList1.SelectedItem.Text=="Mobiles")
            {
                DropDownList2.Items.Clear();
                DropDownList2.Items.Add("");
                DropDownList2.Items.Add("Motorola");
                DropDownList2.Items.Add("OnePlus");
                DropDownList2.Items.Add("Nokia");
                DropDownList2.Items.Add("Samsung");
            }
            else if(DropDownList1.SelectedItem.Text=="Laptops")
            {
                DropDownList2.Items.Clear();
                DropDownList2.Items.Add("");
                DropDownList2.Items.Add("Dell");
                DropDownList2.Items.Add("HP");
                DropDownList2.Items.Add("Mac");
                DropDownList2.Items.Add("Asus");
            }
            else if (DropDownList1.SelectedItem.Text == "Printers")
            {
                DropDownList2.Items.Clear();
                DropDownList2.Items.Add("");
                DropDownList2.Items.Add("Epson");
                DropDownList2.Items.Add("HP");
                DropDownList2.Items.Add("Canon");
              
            }
            else
            {
                Label1.Text = "";
            }
            Label2.Text = "Select a vendor";
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
            
                Label1.Text = "You chose category:" + DropDownList1.SelectedItem.Text + " and vendor name is:" + DropDownList2.SelectedItem.Text;
            

        }
    }
}