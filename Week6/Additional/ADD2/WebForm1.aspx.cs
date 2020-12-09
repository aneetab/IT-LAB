using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace ADD2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["Company"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                FillList();
            }
        }

        public void FillList()
        {
            DropDownList1.Items.Clear();
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Select FirstName from Human",conn);
            SqlDataReader reader;
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while(reader.Read())
                {
                    DropDownList1.Items.Add("");
                    ListItem item = new ListItem();
                    item.Text = reader["FirstName"].ToString();
                    DropDownList1.Items.Add(item);

                }

            }
            catch(Exception err)
            {
                Label1.Text = err.Message;
            }
            finally
            {
                conn.Close();
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Delete from Human where FirstName=@name",conn);
            command.Parameters.AddWithValue("name", TextBox1.Text);
            int deleted;
            try
            {
                conn.Open();
                deleted = command.ExecuteNonQuery();
                Label1.Text = deleted + " row(s) deleted";
                FillList();
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text==""|| TextBox2.Text==""|| TextBox3.Text == ""|| TextBox4.Text == ""|| TextBox5.Text == "")
            {
                Label1.Text = "All fields are required";
            }
            else
            {
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("Update Human set LastName=@last,Phone=@phone,Address=@add,City=@city where FirstName=@name",conn);
                command.Parameters.AddWithValue("last", TextBox2.Text);
                command.Parameters.AddWithValue("phone", TextBox3.Text);
                command.Parameters.AddWithValue("add", TextBox4.Text);
                command.Parameters.AddWithValue("city", TextBox5.Text);
                command.Parameters.AddWithValue("name", TextBox1.Text);
                int updated;
                try
                {
                    conn.Open();
                    updated = command.ExecuteNonQuery();
                    Label1.Text = updated + " row(s) updated";
                }
                catch(Exception err)
                {
                    Label1.Text = err.Message;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Select * from Human where FirstName=@name",conn);
            command.Parameters.AddWithValue("name", DropDownList1.SelectedItem.Text);
            SqlDataReader reader;
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                reader.Read();
                TextBox1.Text = reader["FirstName"].ToString();
                TextBox2.Text = reader["LastName"].ToString();
                TextBox3.Text = reader["Phone"].ToString();
                TextBox4.Text = reader["Address"].ToString();
                TextBox5.Text = reader["City"].ToString();

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