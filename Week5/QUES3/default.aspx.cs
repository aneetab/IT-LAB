using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ques3
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                DropDownList1.Items.Add("");
                DropDownList1.Items.Add("Summer");
                DropDownList1.Items.Add("Monsoon");
                if(Session["Theme"]!=null)
                {
                    DropDownList1.Items.FindByText(Session["Theme"].ToString()).Selected = true;
                }
            }

        }
        protected void Page_PreInit(object sender,EventArgs e)
        {
            if(Session["Theme"]!=null)
            {
                Page.Theme = Session["Theme"].ToString();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["Theme"] = DropDownList1.SelectedValue;
            Response.Redirect(Request.FilePath);
        }
    }
}