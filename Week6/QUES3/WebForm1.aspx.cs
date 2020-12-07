using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace QUES3
{
    public partial class WebForm1 : System.Web.UI.Page 
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["Products"].ConnectionString;


        protected void Page_Load(object sender, EventArgs e)
        {

            if (!this.IsPostBack)
                UpdateTable();
        }

        public void UpdateTable()
        {

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Select * from Items", conn);
            SqlDataReader reader;
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                Table1.Controls.Clear();
                TableRow newRow = new TableRow();
                Table1.Controls.Add(newRow);
                TableCell cellNew = new TableCell();
                cellNew.Text = "ItemID";
                cellNew.BorderStyle = BorderStyle.Inset;
                cellNew.BorderWidth = Unit.Pixel(1);
                newRow.Controls.Add(cellNew);
                cellNew = new TableCell();
                cellNew.Text = "Flavour";
                cellNew.BorderStyle = BorderStyle.Inset;
                cellNew.BorderWidth = Unit.Pixel(1);
                newRow.Controls.Add(cellNew);
                cellNew = new TableCell();
                cellNew.Text = "Price";
                cellNew.BorderStyle = BorderStyle.Inset;
                cellNew.BorderWidth = Unit.Pixel(1);
                newRow.Controls.Add(cellNew);
                cellNew = new TableCell();
                cellNew.Text = "Taste";
                cellNew.BorderStyle = BorderStyle.Inset;
                cellNew.BorderWidth = Unit.Pixel(1);
                newRow.Controls.Add(cellNew);



                while (reader.Read())
                {
                    newRow = new TableRow();
                    Table1.Controls.Add(newRow);
                    cellNew = new TableCell();
                    cellNew.Text = reader["itemID"].ToString();
                    newRow.Controls.Add(cellNew);
                    cellNew = new TableCell();
                    cellNew.Text = reader["flavour"].ToString();
                    newRow.Controls.Add(cellNew);
                    cellNew = new TableCell();
                    cellNew.Text = reader["price"].ToString();
                    newRow.Controls.Add(cellNew);
                    cellNew = new TableCell();
                    cellNew.Text = reader["taste"].ToString();
                    newRow.Controls.Add(cellNew);

                }

            }
            catch (Exception err)
            {
                Label1.Text = "Error retrieving records<hr>";
                Label1.Text += err.Message;
            }
            finally
            {
                conn.Close();
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Update Items set price=@price where itemID=11", conn);
            //command.Parameters.AddWithValue("ID", 11);
            command.Parameters.AddWithValue("price", int.Parse(TextBox1.Text));
         
            
            try
            {
                conn.Open();
                int added = 0;
                added = command.ExecuteNonQuery();
                if (added > 0)
                    Label1.Text = added.ToString() + " row(s) updated";
                UpdateTable();
            }
            catch(Exception err)
            {
                Label1.Text = "Error updating database";
                Label1.Text += err.Message;
            }
            finally
            {
                conn.Close();
            }
            
        }
    }
}