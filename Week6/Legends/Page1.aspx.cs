using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Genre1
{
    public partial class Page1 : System.Web.UI.Page
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                Dictionary<int, string> dict = new Dictionary<int, string>();
                dict.Add(1, "Comedy");
                dict.Add(2, "Romance");
                dict.Add(3, "Animated");
                DropDownList1.DataSource = dict;
                DropDownList1.DataTextField = "Value";
                this.DataBind();
              

            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Select Id,name from Legends where category=@cat", conn);
            command.Parameters.AddWithValue("cat", DropDownList1.SelectedItem.Text);
            SqlDataReader reader;
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                Dictionary<string, string> dict = new Dictionary<string, string>();
                while(reader.Read())
                {
                    dict.Add(reader["Id"].ToString(), reader["name"].ToString());
                }
                ListBox1.DataSource = dict;
                ListBox1.DataTextField = "Value";
                ListBox1.DataValueField = "Key";
                this.DataBind();
            }
            catch(Exception err)
            {
                Label1.Text = "Error retrieving data";
                Label1.Text += err.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Select age from Legends where Id=@id", conn);
            command.Parameters.AddWithValue("id", ListBox1.SelectedItem.Value);
            SqlDataReader reader;
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                reader.Read();
                TextBox1.Text = "Name:" + ListBox1.SelectedItem.Text;
                TextBox1.Text += " Age:" + reader["age"].ToString();
            }
            catch(Exception err)
            {
                Label2.Text = "Error retrieving data";
                Label2.Text += err.Message;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}