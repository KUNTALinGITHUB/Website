using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class AdminHomePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string userId = Request.QueryString["userid"];
            if (!string.IsNullOrEmpty(userId))
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;Persist Security Info=True;User ID=sa;Password=12345678");
                string querry = @"select [img],[name],[userid] FROM [dbo].[admins] where [userid]=@userid";
                SqlCommand cmd = new SqlCommand(querry, con);
                cmd.Parameters.AddWithValue("@userid", userId);


                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Read image data and set the image control
                        byte[] imgData = (byte[])reader["img"];
                        string base64Image = Convert.ToBase64String(imgData);
                        Image1.ImageUrl = "data:image/jpeg;base64," + base64Image;

                        // Set text for the labels
                        Label2.Text = reader["name"].ToString();
                        Label3.Text = reader["userid"].ToString();
                    }
                }

                reader.Close();

            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeachersDetails.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("StudentsDetails.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("ApplicationDetails.aspx");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("ClassRutineDetails.aspx");
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("FeesStructureDetails.aspx");
        
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("HolidayDetails.aspx");
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("OnlineLibraryDetails.aspx");
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        Response.Redirect("NoticeDetails.aspx");
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        Response.Redirect("ContuctDetails.aspx");
    }

    protected void Button10_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
}