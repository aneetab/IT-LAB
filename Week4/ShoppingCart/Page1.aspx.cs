using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoppingCart
{
    public partial class Page1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!this.IsPostBack)
            {
                DropDownList1.Items.Add("");
                DropDownList1.Items.Add("Juice");
                DropDownList1.Items.Add("Chips");
                DropDownList1.Items.Add("Kettle");
                DropDownList1.Items.Add("Plate");
                DropDownList1.Items.Add("Soap");
                DropDownList1.Items.Add("FaceWash");
                DropDownList1.Items.Add("Moisturizer");
                DropDownList1.Items.Add("Hand Sanitizer");
            }
            HttpCookie cookie = Request.Cookies["Cart"];
            if (cookie==null)
            {
                Label1.Text = "Hello, new User";
               
            }
            else
            {
                string name = cookie["Name"];
                Label1.Text = "Hello," + name;
                int counter = int.Parse(cookie["Counter"]);
                Label2.Text = "Items in your cart are:\n";
                for(int i=0;i<counter;i++)
                {
                    string item = "Item" + i.ToString();
                    Label2.Text += cookie[item] + "\n";
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text=="")
            {
                Label2.Text = "Please enter name";
            }
            else if(DropDownList1.SelectedIndex==0)
            {
                Label2.Text = "Please select an item to add to cart";
            }
            else
            {
                HttpCookie cookie = Request.Cookies["Cart"];
                int counter = 0;
                if(cookie!=null)
                {
                    counter = int.Parse(cookie["Counter"]);
                    string itemName = "Item"+counter.ToString();
                    string value = DropDownList1.SelectedItem.Text;
                    cookie[itemName] = value;
                    counter++;
                    cookie["Counter"] = counter.ToString();
                    Label2.Text = "Items in your cart are:\n";
                    for(int i=0;i<counter;i++)
                    {
                        string item = "Item" + i.ToString();
                        Label2.Text += cookie[item] + "\n";
                    }



                }
                else
                {
                    cookie = new HttpCookie("Cart");
                    string name = TextBox1.Text;
                    cookie["Name"] = name;
                    string itemName = "Item0";
                    string value = DropDownList1.SelectedItem.Text;
                    cookie[itemName] = value;
                    counter++;
                    cookie["Counter"] = counter.ToString();
                    Label2.Text = "Items in your cart are:\n";
                    Label2.Text += cookie["Item0"] + "\n";
                }
                cookie.Expires = DateTime.Now.AddYears(1);
                Response.Cookies.Add(cookie);

            }
        }
    }
}