using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeePromotion
{
    public partial class Ques2 : System.Web.UI.Page
    {
        Dictionary<string, string> dic = new Dictionary<string, string>();
       
        
        
        
        
        protected void Page_Load(object sender, EventArgs e)
        {



            if (!this.IsPostBack)
            {
                DropDownList1.Items.Add(new ListItem("---", "Select an ID"));
                DropDownList1.Items.Add(new ListItem("123-01", "Claire M.Dunphy"));
                DropDownList1.Items.Add(new ListItem("123-02", "Jim Halpert"));
                DropDownList1.Items.Add(new ListItem("123-03", "Michael Scott"));
                DropDownList1.Items.Add(new ListItem("123-04", "Pam Beesly"));
                dic.Add("123-01", "Images/claire.png");
                dic.Add("123-02", "Images/jim.png");
                dic.Add("123-03", "Images/michael.png");
                dic.Add("123-04", "Images/pam.jpg");


            }
            else
            {
                dic.Add("000", "");
                dic.Add("123-01", "Images/claire.png");
                dic.Add("123-02", "Images/jim.png");
                dic.Add("123-03", "Images/michael.png");
                dic.Add("123-04", "Images/pam.png");
            }
            Label2.Text = "";


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox2.Text!="")
            {
                try
                {
                    DateTime mydate = DateTime.Parse(TextBox2.Text);
                    DateTime current = DateTime.Now;
                    TimeSpan t = current - mydate;
                    double days = t.TotalDays;
                    double check = 5 * 365.0;
                    int years = (int)days / 365;
                    if(days>=check)
                    {
                        Label1.Text = "You are eligible for a promotion as you have worked for " + years + " years";

                    }
                    else
                    {
                        Label1.Text = "You are not eligible for a promotion as you have worked for only " + years + " years";

                    }
                   // Label1.Text = mydate.ToString();


                }
                catch
                {
                    Label2.Text = "Please enter date in specified format";
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID = DropDownList1.SelectedItem.ToString();
            TextBox1.ReadOnly = true;
            if (ID == "---")
            {
                TextBox1.Text = "";
            }
            else
            {
                TextBox1.Text = DropDownList1.SelectedItem.Value;
                Image1.ImageUrl = dic[ID];
            }
            
           

            
         

        }
    }
}