using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace QUES4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["Company"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox4.Text == "")
                Label2.Text = "Enter company name";
            else
            {
                SqlConnection conn = new SqlConnection(connectionString);
                string sqlString = "Select WORKS.person_name,city from WORKS,LIVES where WORKS.person_name=LIVES.person_name and company_name=@comp ";
                SqlCommand command = new SqlCommand(sqlString, conn);
                command.Parameters.AddWithValue("comp", TextBox4.Text);
                SqlDataReader reader;
                try
                {
                    conn.Open();
                    reader = command.ExecuteReader();
                    Table1.BorderStyle = BorderStyle.Inset;
                    Table1.BorderWidth = Unit.Pixel(2);
                    Table1.Controls.Clear();
                    TableHeaderRow row = new TableHeaderRow();
                    Table1.Controls.Add(row);
                    TableHeaderCell cell = new TableHeaderCell();
                    cell.Text = "NAME";
                    row.Controls.Add(cell);
                    cell = new TableHeaderCell();
                    cell.Text = "CITY";
                    row.Controls.Add(cell);
                    while (reader.Read())
                    {
                        TableRow row1 = new TableRow();
                        Table1.Controls.Add(row1);
                        TableCell cell1 = new TableCell();
                        cell1.Text = reader["person_name"].ToString();
                        row1.Controls.Add(cell1);
                        cell1 = new TableCell();
                        cell1.Text = reader["city"].ToString();
                        row1.Controls.Add(cell1);

                    }


                   

                }
                catch (Exception err)
                {
                    Label1.Text = "Error retreiving from database<hr>";
                    Label1.Text += err.Message;

                }
                finally
                {
                    conn.Close();
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == ""||TextBox5.Text==""||TextBox6.Text=="")
                Label1.Text = "Enter name of employee, name of the company,salary, city and street.";
            else
            {
                SqlConnection conn = new SqlConnection(connectionString);
                string sqlString = "Insert into WORKS(person_name,company_name,salary) values(@name,@company,@salary)";
                SqlCommand command = new SqlCommand(sqlString, conn);
                command.Parameters.AddWithValue("name",TextBox1.Text);
                command.Parameters.AddWithValue("company", TextBox2.Text);
                command.Parameters.AddWithValue("salary", int.Parse(TextBox3.Text));
                int inserted;
                try
                {
                    conn.Open();
                    inserted = command.ExecuteNonQuery();
                    sqlString = "Insert into LIVES(person_name,street,city) values(@name,@street,@city)";
                    command = new SqlCommand(sqlString, conn);
                    command.Parameters.AddWithValue("name", TextBox1.Text);
                    command.Parameters.AddWithValue("street", TextBox6.Text);
                    command.Parameters.AddWithValue("city", TextBox5.Text);
                    command.ExecuteNonQuery();
                    Label1.Text = inserted + " row(s) added";

                }
                catch(Exception err)
                {
                    Label1.Text = "Error inserting into database<hr>";
                    Label1.Text += err.Message;

                }
                finally
                {
                    conn.Close();
                }
               
            }
        }
    }
}