using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MagazineFront
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                DropDownList1.Items.Add(new ListItem("None", ""));
                DropDownList1.Items.Add(new ListItem("Dog", "Images/dog.png"));
                DropDownList1.Items.Add(new ListItem("Home Decor", "Images/decor.png"));
                DropDownList1.Items.Add(new ListItem("Fashion", "Images/fashion.png"));

                DropDownList2.Items.Add("Blue");
                DropDownList2.Items.Add("Orange");
                DropDownList2.Items.Add("Pink");
                DropDownList2.Items.Add("Black");
                DropDownList2.Items.Add("Red");

                DropDownList3.Items.Add("Black");
                DropDownList3.Items.Add("Brown");
                DropDownList3.Items.Add("Red");
                DropDownList3.Items.Add("Grey");
                DropDownList3.Items.Add("Dark Blue");
            }






        }

        protected void Update_Click(object sender, EventArgs e)
        {
            UpdateCard();
        }
        public void UpdateCard()
        {
            if(DropDownList1.SelectedItem.Text!="None")
            {
                Image1.ImageUrl =DropDownList1.SelectedItem.Value;
                Panel1.BackColor = Color.FromName(DropDownList2.SelectedItem.ToString());
                if(TextBox1.Text!="" && int.Parse(TextBox1.Text)>0)
                {
                    Label1.Font.Size = FontUnit.Point(int.Parse(TextBox1.Text));
                }
                Panel1.ForeColor = Color.FromName(DropDownList3.SelectedItem.Text);
                Label1.Text = TextBox2.Text;
                string[] names = { "Verdana", "Times New Roman", "Calibri" };
                Label1.Font.Names = names;
            }
        }
    }
}