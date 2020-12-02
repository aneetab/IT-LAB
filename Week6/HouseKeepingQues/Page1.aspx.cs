using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HouseKeepingQues
{

    public partial class Page1 : System.Web.UI.Page
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["HouseKeeping"].ConnectionString;
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                SqlConnection myConnection = new SqlConnection(connectionString);
                try
                {
                    DropDownList1.Items.Add("");
                    myConnection.Open();
                    SqlCommand command = new SqlCommand("Select DISTINCT StaffID from Staff", myConnection);
                   // SqlDataReader reader;
                    //reader = command.ExecuteReader();
                    //while(reader.Read())
                    //{
                      //  DropDownList1.Items.Add(reader["StaffID"].ToString());
                    //}
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(ds, "staff_ids");
                    DropDownList1.DataSource = ds.Tables["staff_ids"];
                    DropDownList1.DataTextField = "StaffID";
                  //  DropDownList1.DataValueField = "StaffID";
                    DropDownList1.DataBind();
                    
                    //DropDownList1.DataBind();

              
                }
                catch (Exception err)
                {
                    Label1.Text = "Error reaing the database";
                    Label1.Text += err.Message;
                }
                finally
                {
                    myConnection.Close();
                  
                }


                ListBox1.Items.Add("Bangalore");
                ListBox1.Items.Add("Chennai");
                ListBox1.Items.Add("Hyderabad");
                ListBox1.Items.Add("kolkata");
                ListBox1.Items.Add("Delhi");
                ListBox1.Items.Add("Nagpur");
            }
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Select FirstName,LastName,DNo,Street,City,State,ZipCode from Staff where StaffID=@staffid", myConnection);
            command.Parameters.AddWithValue("@staffid", DropDownList1.SelectedItem.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            try
            {
                myConnection.Open();
                adapter.Fill(ds, "staff_details");
                GridView1.DataSource = ds.Tables["staff_details"];
                GridView1.DataBind();
            }
            catch(Exception err)
            {
                Label1.Text = "Error reading details";
                Label1.Text += err.Message;
            }
            finally
            {
                myConnection.Close();
            }
            


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex == 0)
            {
                Label1.Text = "You need to select an staff";
            }
           else if (ListBox1.SelectedIndex==-1)
            {
                Label1.Text = "You need to select new city to update";
            }
            else
            {
                SqlConnection myConnection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("Update Staff set City=@city where StaffID=@staffid", myConnection);
                command.Parameters.AddWithValue("city", ListBox1.SelectedItem.Text);
                command.Parameters.AddWithValue("staffid", DropDownList1.SelectedItem.Text);
                try
                {
                    myConnection.Open();
                    int updated = command.ExecuteNonQuery();
                    Label1.Text = updated.ToString() + "record(s) updated";
                }
                catch(Exception err)
                {
                    Label1.Text = "Error updating table";
                    Label1.Text += err.Message;
                }
                finally
                {
                    myConnection.Close();
                }
                
            }
           
        }

        
    }
}