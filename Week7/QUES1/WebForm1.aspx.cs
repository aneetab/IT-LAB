using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QUES1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                List<string> fruits = new List<string>();
                fruits.Add("Apple");
                fruits.Add("Mango");
                fruits.Add("Banana");
                fruits.Add("Chikku");
                fruits.Add("Litchi");
                fruits.Add("Pineapple");
                List<ListItem> icrecream = new List<ListItem>();
                icrecream.Add(new ListItem("Butterscotch", "150.00"));
                icrecream.Add(new ListItem("Vanilla", "100.00"));
                icrecream.Add(new ListItem("Strawberry", "120.00"));
                CheckBoxList1.DataSource = fruits;
                RadioButtonList1.DataSource = icrecream;
                RadioButtonList1.DataTextField = "Text";
                RadioButtonList1.DataValueField = "Value";
                this.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(CheckBoxList1.SelectedIndex==-1||RadioButtonList1.SelectedIndex==-1)
            {
                Label1.Text += "Please slect a fruit and icecream flavour!";
            }
            else
            {
                Label1.Text = "Selected details are:<hr>";
                Label1.Text += "Fruit:" + CheckBoxList1.SelectedItem.Text;
                Label1.Text += "<hr>IceCream Flavour:" + RadioButtonList1.SelectedItem.Text;
                Label1.Text += "<hr>Price:" + RadioButtonList1.SelectedItem.Value;
            }
        }
    }
}