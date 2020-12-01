using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueryString
{
    public partial class Page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Model Name:";
            Label1.Text+=Request.QueryString["model"];
            Label2.Text = "Manufacturer Name:";
            Label2.Text+= Request.QueryString["manuf"];


        }
    }
}