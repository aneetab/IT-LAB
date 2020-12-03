using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HousePresident
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                DropDownList1.Items.Add("");
                DropDownList1.Items.Add("Aneeta");
                DropDownList1.Items.Add("Arushka");
                DropDownList1.Items.Add("Ahana");
                DropDownList1.Items.Add("Riya");
                DropDownList1.Items.Add("Sona");
                DropDownList1.Items.Add("Mitul");
                RadioButtonList1.Items.Add("Gryffindor");
                RadioButtonList1.Items.Add("Sytherin");
                RadioButtonList1.Items.Add("Ravenclaw");
                RadioButtonList1.Items.Add("Hufflepuff");

            }
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs e)
        {
            try
            {
                decimal value = decimal.Parse(e.Value.ToString());
                string val = e.Value.ToString();
                if (val.Length == 10)
                {
                    e.IsValid = true;

                }
                else
                    e.IsValid = false;

            }
            catch
            {
                e.IsValid = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                Label1.Text = "Successfully Submitted";
            }
        }
    }
}