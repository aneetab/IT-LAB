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

        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {

                int age = (int)DataBinder.Eval(e.Row.DataItem, "Age");
                if (age > 35)
                {
                    e.Row.BackColor = System.Drawing.Color.DarkOrange;
                    e.Row.ForeColor = System.Drawing.Color.Black;
                    e.Row.Font.Bold = true;
                }
            }
        }
    }
}