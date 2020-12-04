using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mobile
{
    public partial class Page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Mobile"].ToString() =="OnePlus Nord")
            {
                Screen.Text = "SCREEN:6.44-inch (1080x2400)<hr>";
                Memory.Text = "MEMORY:RAM-12GB<hr>";
                Camera.Text = "CAMERA:Rear Camera-48MP + 8MP + 5MP + 2MP Front Camera-32MP + 8MP<hr>";
                Battery.Text = "BATTERY:4115mAh<hr>";
                Image.ImageUrl = "Images/Oneplus.png";

            }
            else if (Session["Mobile"].ToString() == "Iphone 12")
            {
                Screen.Text = "SCREEN:6.1 1170x2532 pixels<hr>";
                Memory.Text = "MEMORY:4GB RAM<hr>";
                Camera.Text = "CAMERA:12MP<hr>";
                Battery.Text = "BATTERY:2815mAh<hr>";
                Image.ImageUrl = "Images/Iphone.png";
            }
            else
            {
                Screen.Text = "BLOOOOP";
                Memory.Text = "";
                Camera.Text = "";
                Battery.Text = "";
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
            
        }
    }
}