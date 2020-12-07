using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QUES3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        

        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                Dictionary<int, string> dic = new Dictionary<int, string>();
                dic.Add(1, "Maharashtra");
                dic.Add(2, "Kerala");
                dic.Add(3, "Karnataka");
                dic.Add(4, "Uttar Pradesh");
                dic.Add(5, "West Bengal");
                DropDownList1.DataSource = dic;
                DropDownList1.DataTextField = "Value";
                DropDownList1.DataValueField = "Key";
                
                this.DataBind();
            }

           
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = "Selected Details:<hr>";
            Label1.Text += "State:" + DropDownList1.SelectedItem.Text;
            Label1.Text += "<hr>City:" + DropDownList2.SelectedItem.Text;
        }
    }
}