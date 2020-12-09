using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ADD1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["Staff_Details"].ConnectionString;
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("Select * from Institutes", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                try
                {
                    conn.Open();
                    adapter.Fill(ds, "institutes");
                    foreach(DataRow row in ds.Tables["institutes"].Rows)
                    {
                        ListItem item = new ListItem();
                        item.Text = row["name"].ToString();
                        ListBox1.Items.Add(item);
                    }

                }
                catch (Exception err)
                {
                    Label1.Text = err.Message;
                }
                finally
                {
                    conn.Close();
                }
            }

        }
    }
}