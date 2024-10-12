using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class AdminSignIn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(TextBox5.Text) || string.IsNullOrWhiteSpace(TextBox2.Text) ||
        string.IsNullOrWhiteSpace(TextBox3.Text) || string.IsNullOrWhiteSpace(TextBox4.Text))
        {
            Label9.Visible = true;
            Label9.Text= "Please fill in all fields before submitting.";
            return;  // Return early to prevent further processing
        }
        if (TextBox3.Text == TextBox4.Text)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
            string querry = @"INSERT INTO [dbo].[admins]
           (
[name],[emailid]
           ,[password]
           ,[c_password],[img]
           )
     VALUES
           (@name,@emailid,@password,@c_password,@img);
            SELECT SCOPE_IDENTITY();"; // This will return the ID of the newly inserted record

            SqlCommand cmd = new SqlCommand(querry, con);
            con.Open();
            cmd.Parameters.AddWithValue("@name", TextBox5.Text);
            cmd.Parameters.AddWithValue("@emailid", TextBox2.Text);
            cmd.Parameters.AddWithValue("@password", TextBox3.Text);
            cmd.Parameters.AddWithValue("@c_password", TextBox4.Text);
            // Check if a file was uploaded using the FileUpload control
            if (File1.HasFile)
            {
                // Read the uploaded file into a byte array
                byte[] imgData = File1.FileBytes;
                cmd.Parameters.AddWithValue("@img", imgData);
            }
            else
            {
                // Handle the case where no file was uploaded, set img to DBNull
                cmd.Parameters.AddWithValue("@img", DBNull.Value);
            }

            object userid = cmd.ExecuteScalar();  // ExecuteScalar to get the ID of the inserted record
            con.Close();

            if (userid != null)
            {
                string userId = userid.ToString();
                Response.Write("Password Match! Successfully submitted...");
                Response.Write("User ID: " + userId);  // Show the user ID
            }
        }
        else
        {
            Response.Write("Passwords do not match. Please try again.");
        }
    }
}