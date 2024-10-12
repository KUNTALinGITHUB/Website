using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");      
        string querry = @"SELECT * FROM [dbo].[admins] where [userid] = @userid and [password]=@password";
        SqlCommand cmd = new SqlCommand(querry, con);
        cmd.Parameters.AddWithValue("@userid", TextBox1.Text);
        cmd.Parameters.AddWithValue("@password", TextBox2.Text);
        con.Open();
        SqlDataReader reader = cmd.ExecuteReader();
       if (reader.HasRows) 
            {
                // If user exists, redirect to the next page
                
                Label7.Text = "Sucessfully Login";
                Label7.Visible = true;// Replace with your actual page
                Response.Redirect("~/AdminHomePage.aspx?userid=" + TextBox1.Text);
            }
            else
            {
                // If no user is found, show an error message
                Label6.Text = "Invalid username or password";
                Label6.Visible = true;
            }

            // Close the reader and connection
            reader.Close();
        
        con.Close();

    }
}